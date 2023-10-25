using Creative.Data;
using Creative.Shared;
using Creative.Shared.Extensions;
using Creative.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Diagnostics;
using System.Text.Json;

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
        private async Task<T> SetCache<T>(string key, T result)
        {
            // serialize the response
            byte[] objectToCache = JsonSerializer.SerializeToUtf8Bytes(result);
            var cacheEntryOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(30))
                .SetAbsoluteExpiration(DateTime.Now.AddDays(1));

            // Cache it
            await _distributedCache.SetAsync(key, objectToCache, cacheEntryOptions);
            return result;
        }

        private async Task<T> SetCache<T>(T result)
        {
            // serialize the response
            byte[] objectToCache = JsonSerializer.SerializeToUtf8Bytes(result);
            var cacheEntryOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(30))
                .SetAbsoluteExpiration(DateTime.Now.AddDays(1));

            // Cache it
            await _distributedCache.SetAsync(nameof(result), objectToCache, cacheEntryOptions);
            return result;
        }

        [HttpGet]
        public async Task<ApiResult<List<Item>>> Get(Lookup lookup, string? searchTerm = "", int page = 1, int pageSize = 5)
        {
            ApiResult<List<Item>> result = new();
            try
            {

                List<Item>? data = await GetCache<List<Item>>(lookup.ToString());
                if (data is not null)
                    return result.Success(data);


                data = lookup switch
                {

                    Lookup.HandicapType => await _dbContext.RegHandicapeTypes.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name1
                    }).ToListAsync(),

                    Lookup.Jobs => await _dbContext.RegJobs.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name1
                    }).ToListAsync(),

                    Lookup.Religions => await _dbContext.RegRelegions.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name1
                    }).ToListAsync(),

                    Lookup.Grades => await _dbContext.RegGreads.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name1
                    }).ToListAsync(),

                    Lookup.Years => await _dbContext.RegYears.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name1
                    }).ToListAsync(),

                    Lookup.Branches => await (from branch in _dbContext.RegBranches.AsNoTracking()
                                              select new Item()
                                              {
                                                  Id = branch.Id,
                                                  Name = branch.Name1,
                                              }).ToListAsync(),

                    Lookup.Parents => await _dbContext.AcpResponsibiles.AsNoTracking().Select(x => new { x.Id, x.Name1, x.Name2, x.Code, x.IdNo })
                                   .Union(_dbContext.RegResponsibiles.AsNoTracking().Select(x => new { x.Id, x.Name1, x.Name2, x.Code, x.IdNo }))
                                   .Where(x => searchTerm == "" || (searchTerm != null && (x.Name1.Contains(searchTerm) || x.IdNo.Contains(searchTerm) || x.Name2.Contains(searchTerm))))
                                   .Skip((page - 1) * pageSize)
                                   .Take(pageSize)
                                   .Select(x => new Item()
                                   {
                                       Id = x.Id,
                                       Name = x.Name1
                                   }).ToListAsync(),

                    Lookup.Nationals => await _dbContext.RegNationals.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name2
                    }).ToListAsync(),

                    Lookup.Employees => await _dbContext.RegEmps.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name1
                    }).ToListAsync(),

                    Lookup.ExamTypes => await _dbContext.AcpExamTypes.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name2
                    }).ToListAsync(),

                    Lookup.Goverment => await _dbContext.RegGovers.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name2
                    }).ToListAsync(),

                    Lookup.Area => await _dbContext.RegAreas.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name2
                    }).ToListAsync(),
                    Lookup.Part => await _dbContext.RegParts.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name2
                    }).ToListAsync(),

                    Lookup.IdType => await _dbContext.RegIdTypes.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name2
                    }).ToListAsync(),

                    Lookup.AccAccounts => await _dbContext.AccAccounts.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name2
                    }).ToListAsync(),

                    Lookup.AccAnalyses => await _dbContext.AccAnalyses.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Name2
                    }).ToListAsync(),

                    Lookup.AccCost => await _dbContext.AccAccCosts.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Code
                    }).ToListAsync(),
                    Lookup.AccExpenses => await _dbContext.AccExpenses.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Code
                    }).ToListAsync(),
                    Lookup.BooksAccounts => await _dbContext.LibItemsBooks.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Code
                    }).ToListAsync(),
                    Lookup.BusAccount => await _dbContext.BusBus.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Code
                    }).ToListAsync(),
                    Lookup.AccAccCats => await _dbContext.AccAccCats.AsNoTracking().Select(x => new Item()
                    {
                        Id = x.Id,
                        Name = x.Code
                    }).ToListAsync(),
                };

                return result.Success(await SetCache(lookup.ToString(), data));

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

        [HttpGet("GetEligibleData")]
        public async Task<ApiResult<EligibleData>> GetEligibleData(DateTime dateOfBith, decimal branchId)
        {
            var acceptedDate = await (from ebranch in _dbContext.RegBranches
                                      join school in _dbContext.RegSchools on ebranch.SchoolId equals school.Id
                                      where ebranch.Id == branchId
                                      select school.DateAccept).FirstOrDefaultAsync();
            var result = new EligibleData()
            {
                AgeAtAdmission = dateOfBith.ToAgeString(acceptedDate),
                EliogibleGrade = _dbContext.RegGreads.FirstOrDefault(x => x.AcpFromDate <= dateOfBith && x.AcpToDate >= dateOfBith)?.Name1
            };


            return new ApiResult<EligibleData>().Success(result);
        }


        [HttpGet("Search")]
        public async Task<ApiResult<IEnumerable<Item>>> Search(decimal branchId, string searchTerm, bool noStudent = false, int page = 1, int pageSize = 50)
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
                ps.IdNo.Trim().Contains(searchTerm) ||
                ps.Name2.Trim().Contains(searchTerm) ||
                ps.Code.Trim().Contains(searchTerm) ||
                ps.Tel1.Trim().Contains(searchTerm) ||
                ps.Tel2.Trim().Contains(searchTerm)
               );

                studentQuery = studentQuery.Where(ps => ps.Name1.Contains(searchTerm) ||
                ps.IdNo.Trim().Contains(searchTerm) ||
                ps.Name2.Trim().Contains(searchTerm) ||
                ps.Code.Trim().Contains(searchTerm) ||
                ps.Tel1.Trim().Contains(searchTerm) ||
                ps.Tel2.Trim().Contains(searchTerm)
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