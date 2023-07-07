using Creative.Data;
using Creative.Shared;
using Creative.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Refit;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using static MudBlazor.Defaults;

namespace Creative.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LookupController : ControllerBase
    {

        private readonly ILogger<LookupController> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly IDistributedCache _distributedCache;

        public LookupController(ILogger<LookupController> logger, ApplicationDbContext dbContext, IDistributedCache distributedCache)
        {
            _logger = logger;
            this._dbContext = dbContext;
            this._distributedCache = distributedCache;
        }

        private async Task<T> GetCache<T>(string key)
        {
            byte[] objectFromCache = await _distributedCache.GetAsync(key);

            if (objectFromCache == null)
                return default;

            // Deserialize it
            var jsonToDeserialize = System.Text.Encoding.UTF8.GetString(objectFromCache);
            var cachedResult = JsonSerializer.Deserialize<T>(jsonToDeserialize);
            if (cachedResult == null)
                return default;

            // If found, then return it
            return cachedResult;
        }
        private async Task SetCache<T>(string key, T result)
        {
            // serialize the response
            byte[] objectToCache = JsonSerializer.SerializeToUtf8Bytes(result);
            var cacheEntryOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(30))
                .SetAbsoluteExpiration(DateTime.Now.AddDays(1));

            // Cache it
            await _distributedCache.SetAsync(key, objectToCache, cacheEntryOptions);
        }

        [HttpGet("Many")]
        public async Task<ApiResult<AcademicLookups>> Get(Lookup[] lookups, string? searchTerm = "", int page = 1, int pageSize = 5)
        {
            ApiResult<AcademicLookups> result = new();
            try
            {
                List<Item>? grades = null, branches = null, years = null, classes = null, parents = null,
                    religions = null, nationals = null, employees = null, examTypes = null, Jobs = null, parentsAndStudent = null;

                Stopwatch stopwatch = Stopwatch.StartNew();
                foreach (Lookup lookup in lookups)
                {
                    if (lookup is (Lookup.Jobs or Lookup.All))
                    {
                        Jobs = await GetCache<List<Item>>(nameof(Jobs));
                        if (Jobs is null)
                        {
                            Jobs = await _dbContext.RegJobs.AsNoTracking().Select(x => new Item()
                            {
                                Id = x.Id,
                                Name = x.Name1
                            }).ToListAsync();

                            await SetCache(nameof(Jobs), Jobs);
                        }
                    }

                    if (lookup is (Lookup.All or Lookup.Religions))
                    {
                        religions = await GetCache<List<Item>>(nameof(religions));
                        if (religions is null)
                        {
                            religions = await _dbContext.RegRelegions.AsNoTracking().Select(x => new Item()
                            {
                                Id = x.Id,
                                Name = x.Name1
                            }).ToListAsync();
                            await SetCache(nameof(religions), religions);
                        }
                    }

                    if (lookup is (Lookup.All or Lookup.Classes))
                    {
                        classes = await GetCache<List<Item>>(nameof(classes));
                        if (classes is null)
                        {
                            classes = await _dbContext.RegClasses.AsNoTracking().Select(x => new Item()
                            {
                                Id = x.Id,
                                Name = x.Name1
                            }).ToListAsync();
                            await SetCache(nameof(classes), classes);
                        }
                    }

                    if (lookup is (Lookup.All or Lookup.Grades))
                    {
                        grades = await GetCache<List<Item>>(nameof(grades));
                        if (grades is null)
                        {
                            grades = await _dbContext.RegGreads.AsNoTracking().Select(x => new Item()
                            {
                                Id = x.Id,
                                Name = x.Name1
                            }).ToListAsync();
                            await SetCache(nameof(grades), grades);
                        }
                    }

                    if (lookup is (Lookup.All or Lookup.Years))
                    {
                        years = await GetCache<List<Item>>(nameof(years));
                        if (years is null)
                        {
                            years = await _dbContext.RegYears.AsNoTracking().Select(x => new Item()
                            {
                                Id = x.Id,
                                Name = x.Name1
                            }).ToListAsync();
                            await SetCache(nameof(years), years);
                        }
                    }

                    if (lookup is (Lookup.All or Lookup.Branches))
                    {
                        branches = await GetCache<List<Item>>(nameof(branches));
                        if (branches is null)
                        {
                            branches = await _dbContext.RegBranches.AsNoTracking().Select(x => new Item()
                            {
                                Id = x.Id,
                                Name = x.Name1
                            }).ToListAsync();
                            await SetCache(nameof(branches), branches);
                        }
                    }

                    if (lookup is (Lookup.All or Lookup.Parents))
                    {
                        parents = await _dbContext.AcpResponsibiles.AsNoTracking().Select(x => new { x.Id, x.Name1, x.Name2, x.Code, x.IdNo })
                                   .Union(_dbContext.RegResponsibiles.AsNoTracking().Select(x => new { x.Id, x.Name1, x.Name2, x.Code, x.IdNo }))
                                   .Where(x => searchTerm == "" || (searchTerm != null && (x.Name1.Contains(searchTerm) || x.IdNo.Contains(searchTerm) || x.Name2.Contains(searchTerm))))
                                   .Skip((page - 1) * pageSize)
                                   .Take(pageSize)
                                   .Select(x => new Item()
                                   {
                                       Id = x.Id,
                                       Name = x.Name1
                                   }).ToListAsync();
                    }

                    if (lookup is (Lookup.All or Lookup.ParentsAndStudent))
                    {
                        var parentsQuery = _dbContext.AcpStudents.AsNoTracking().Select(x => new { x.Id, x.Name1, x.Name2, x.Code, x.IdNo, Identity = Identity.Student });

                        if (lookup != Lookup.All)
                        {
                            parentsQuery = parentsQuery.Union(_dbContext.AcpResponsibiles.AsNoTracking().Select(x => new { x.Id, x.Name1, x.Name2, x.Code, x.IdNo, Identity = Identity.Parent }));
                        }

                        parentsAndStudent = await parentsQuery.Where(x => searchTerm == "" || (searchTerm != null && (x.Name1.Contains(searchTerm) || x.IdNo.Contains(searchTerm) || x.Name2.Contains(searchTerm))))
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .Select(x => new Item()
                                    {
                                        Id = x.Id,
                                        Name = x.Name1,
                                        Identity = x.Identity
                                    }).ToListAsync();
                    }

                    if (lookup is (Lookup.All or Lookup.Nationals))
                    {
                        // nationals = await GetCache<List<Item>>(nameof(nationals));

                        // if (nationals is null)
                        // {
                        nationals = await _dbContext.RegNationals.AsNoTracking().Select(x => new Item()
                        {
                            Id = x.Id,
                            Name = x.Name2
                        }).ToListAsync();
                        //     await SetCache(nameof(nationals), nationals);
                        // }
                    }

                    if (lookup is (Lookup.All or Lookup.Employees))
                    {
                        employees = await GetCache<List<Item>>(nameof(employees));

                        if (employees is null)
                        {

                            employees = await _dbContext.RegEmps.AsNoTracking().Select(x => new Item()
                            {
                                Id = x.Id,
                                Name = x.Name1
                            }).ToListAsync();
                            await SetCache(nameof(employees), employees);
                        }
                    }

                    if (lookup is (Lookup.All or Lookup.ExamTypes))
                    {
                        examTypes = await GetCache<List<Item>>(nameof(examTypes));

                        if (examTypes is null)
                        {
                            examTypes = await _dbContext.AcpExamTypes.AsNoTracking().Select(x => new Item()
                            {
                                Id = x.Id,
                                Name = x.Name2
                            }).ToListAsync();
                            await SetCache(nameof(examTypes), examTypes);
                        }
                    }
                }


                stopwatch.Stop();

                return result.Success(new AcademicLookups
                {
                    Jobs = Jobs,
                    Classes = classes,
                    Grades = grades,
                    Years = years,
                    Branches = branches,
                    Parents = parents,
                    Religions = religions,
                    Nationals = nationals,
                    Employees = employees,
                    ExamTypes = examTypes,
                    ExecutedIn = stopwatch.ElapsedMilliseconds
                });
            }
            catch (Exception ex)
            {
                return result.Fail(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ApiResult<AcademicLookups>> Get(Lookup lookup, string? searchTerm = "", int page = 1, int pageSize = 5)
        {
            ApiResult<AcademicLookups> result = new();
            try
            {
                List<Item>? grades = null, branches = null, years = null, classes = null, parents = null,
                    religions = null, nationals = null, employees = null, examTypes = null, Jobs = null, parentsAndStudent = null, handicapTypes = null;

                Stopwatch stopwatch = Stopwatch.StartNew();

                if (lookup is (Lookup.HandicapType or Lookup.All))
                {
                    handicapTypes = await GetCache<List<Item>>(nameof(handicapTypes));
                    if (handicapTypes is null)
                    {
                        handicapTypes = await _dbContext.RegHandicapeTypes.AsNoTracking().Select(x => new Item()
                        {
                            Id = x.Id,
                            Name = x.Name1
                        }).ToListAsync();

                        await SetCache(nameof(handicapTypes), handicapTypes);
                    }
                }

                if (lookup is (Lookup.Jobs or Lookup.All))
                {
                    Jobs = await GetCache<List<Item>>(nameof(Jobs));
                    if (Jobs is null)
                    {
                        Jobs = await _dbContext.RegJobs.AsNoTracking().Select(x => new Item()
                        {
                            Id = x.Id,
                            Name = x.Name1
                        }).ToListAsync();

                        await SetCache(nameof(Jobs), Jobs);
                    }
                }

                if (lookup is (Lookup.All or Lookup.Religions))
                {
                    religions = await GetCache<List<Item>>(nameof(religions));
                    if (religions is null)
                    {
                        religions = await _dbContext.RegRelegions.AsNoTracking().Select(x => new Item()
                        {
                            Id = x.Id,
                            Name = x.Name1
                        }).ToListAsync();
                        await SetCache(nameof(religions), religions);
                    }
                }



                if (lookup is (Lookup.All or Lookup.Grades))
                {
                    grades = await GetCache<List<Item>>(nameof(grades));
                    if (grades is null)
                    {
                        grades = await _dbContext.RegGreads.AsNoTracking().Select(x => new Item()
                        {
                            Id = x.Id,
                            Name = x.Name1
                        }).ToListAsync();
                        await SetCache(nameof(grades), grades);
                    }
                }

                if (lookup is (Lookup.All or Lookup.Years))
                {
                    years = await GetCache<List<Item>>(nameof(years));
                    if (years is null)
                    {
                        years = await _dbContext.RegYears.AsNoTracking().Select(x => new Item()
                        {
                            Id = x.Id,
                            Name = x.Name1
                        }).ToListAsync();
                        await SetCache(nameof(years), years);
                    }
                }

                if (lookup is (Lookup.All or Lookup.Branches))
                {
                    branches = await GetCache<List<Item>>(nameof(branches));

                    if (branches is null)
                    {
                        branches = await _dbContext.RegBranches.AsNoTracking().Select(x => new Item()
                        {
                            Id = x.Id,
                            Name = x.Name1
                        }).ToListAsync();
                        await SetCache(nameof(branches), branches);
                    }
                }

                if (lookup is (Lookup.All or Lookup.Parents))
                {
                    parents = await _dbContext.AcpResponsibiles.AsNoTracking().Select(x => new { x.Id, x.Name1, x.Name2, x.Code, x.IdNo })
                               .Union(_dbContext.RegResponsibiles.AsNoTracking().Select(x => new { x.Id, x.Name1, x.Name2, x.Code, x.IdNo }))
                               .Where(x => searchTerm == "" || (searchTerm != null && (x.Name1.Contains(searchTerm) || x.IdNo.Contains(searchTerm) || x.Name2.Contains(searchTerm))))
                               .Skip((page - 1) * pageSize)
                               .Take(pageSize)
                               .Select(x => new Item()
                               {
                                   Id = x.Id,
                                   Name = x.Name1
                               }).ToListAsync();
                }



                if (lookup is (Lookup.All or Lookup.Nationals))
                {
                    // nationals = await GetCache<List<Item>>(nameof(nationals));

                    // if (nationals is null)
                    // {
                    nationals = await _dbContext.RegNationals.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name2
                    }).ToListAsync();
                    await SetCache(nameof(nationals), nationals);
                    // }
                }

                if (lookup is (Lookup.All or Lookup.Employees))
                {
                    employees = await GetCache<List<Item>>(nameof(employees));

                    if (employees is null)
                    {

                        employees = await _dbContext.RegEmps.AsNoTracking().Select(x => new Item()
                        {
                            Id = x.Id,
                            Name = x.Name1
                        }).ToListAsync();
                        await SetCache(nameof(employees), employees);
                    }
                }

                if (lookup is (Lookup.All or Lookup.ExamTypes))
                {
                    examTypes = await GetCache<List<Item>>(nameof(examTypes));

                    if (examTypes is null)
                    {
                        examTypes = await _dbContext.AcpExamTypes.AsNoTracking().Select(x => new Item()
                        {
                            Id = x.Id,
                            Name = x.Name2
                        }).ToListAsync();
                        await SetCache(nameof(examTypes), examTypes);
                    }
                }

                stopwatch.Stop();

                return result.Success(new AcademicLookups
                {
                    Jobs = Jobs,
                    Classes = classes,
                    Grades = grades,
                    Years = years,
                    Branches = branches,
                    Parents = parents,
                    Religions = religions,
                    Nationals = nationals,
                    Employees = employees,
                    ExamTypes = examTypes,
                    HandicapTypes = handicapTypes,
                    ExecutedIn = stopwatch.ElapsedMilliseconds
                });
            }
            catch (Exception ex)
            {
                return result.Fail(ex.Message);
            }
        }

        [HttpGet("GetClass")]
        public async Task<ApiResult<IEnumerable<Item>>> GetClass(decimal gradeId, decimal branchId, string gender)
        {

            
               var classes = await _dbContext.RegClasses.AsNoTracking().Where(x => x.GreadId == gradeId && x.BranchId == branchId && x.StuSex == gender).Select(x => new Item()
                {
                    Id = x.Id,
                    Name = x.Name1
                }).ToListAsync();

            return new ApiResult<IEnumerable<Item>>().Success(classes);
        }

        [HttpGet("GetSchedules")]
        public async Task<ApiResult<IEnumerable<ScheduleItem>>> GetSchedules()
        {

            IEnumerable<ScheduleItem> scheduleItems = await GetCache<IEnumerable<ScheduleItem>>(nameof(scheduleItems));

            if (scheduleItems is null)
            {
                scheduleItems = await (from sch in _dbContext.AcpExmSchedules.AsNoTracking()
                                       join exam in _dbContext.AcpExams.AsNoTracking() on sch.ExmId equals exam.Id
                                       join room in _dbContext.AcpExmRooms.AsNoTracking() on sch.RoomId equals room.Id
                                       select new ScheduleItem
                                       {
                                           Id = sch.Id,
                                           Name = sch.Name1,
                                           Exam = exam.Name1,
                                           Room = room.Name1,
                                           ExamDate = sch.ExmDate
                                       }).ToListAsync();

                await SetCache(nameof(scheduleItems), scheduleItems);
            }

            return new ApiResult<IEnumerable<ScheduleItem>>().Success(scheduleItems);
        }



        [HttpGet("Search")]
        public async Task<ApiResult<IEnumerable<Item>>> Search(decimal branchId, string searchTerm, bool noStudent = false, int page = 1, int pageSize = 5)
        {
            ApiResult<IEnumerable<Item>> result = new();

            var studentQuery = _dbContext.AcpStudents.AsNoTracking();

            if (branchId > 0)
            {
                studentQuery = studentQuery.Where(x => x.CurBranchId == branchId);
            }


            var parentQuery = _dbContext.AcpResponsibiles.AsNoTracking();
            //   join student in studentQuery on parent.Id equals student.ParentId
            //   select parent;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                parentQuery = parentQuery.Where(ps => ps.Name1.Contains(searchTerm) ||
                ps.IdNo.Trim().Equals(searchTerm) ||
                ps.Name2.Trim().Contains(searchTerm) ||
                ps.Code.Trim().Equals(searchTerm) ||
                ps.Tel1.Trim().StartsWith(searchTerm) ||
                ps.Tel2.Trim().StartsWith(searchTerm)
               );

                studentQuery = studentQuery.Where(ps => ps.Name1.Contains(searchTerm) ||
                ps.IdNo.Trim().Equals(searchTerm) ||
                ps.Name2.Trim().Contains(searchTerm) ||
                ps.Code.Trim().Equals(searchTerm) ||
                ps.Tel1.Trim().StartsWith(searchTerm) ||
                ps.Tel2.Trim().StartsWith(searchTerm)
               );
            }

            if (!noStudent)
            {
                parentQuery = from parent in parentQuery
                              join student in studentQuery on parent.Id equals student.ParentId
                              select parent;
            }


            var allQuery = parentQuery.Select(x => new { x.Id, x.Name1, x.Name2, Identity = Identity.Parent })
                        .Union(studentQuery.Select(x => new { x.Id, x.Name1, x.Name2, Identity = Identity.Student }));

            var parentStundentsList = await allQuery.Skip((page - 1) * pageSize)
                         .Take(pageSize)
                         .Select(x => new Item()
                         {
                             Id = x.Id,
                             Name = x.Name1.Trim(),
                             Identity = x.Identity
                         }).ToListAsync();

            return result.Success(parentStundentsList);

        }


    }

}