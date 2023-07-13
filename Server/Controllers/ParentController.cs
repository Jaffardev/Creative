using Creative.Data.Models;
using Creative.Shared.Models;
using Creative.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Creative.Data;
using Mapster;
using System.Linq.Expressions;

namespace Creative.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ParentsController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet("GetNewCode")]
        public async Task<ApiResult<decimal>> GetNewCode()
        {
            string code = (await _dbContext.AcpResponsibiles.AsNoTracking().OrderByDescending(x => x.Id).FirstOrDefaultAsync())?.Code ?? "0";

            if (decimal.TryParse(code, out decimal _code))
                return new ApiResult<decimal>().Success(_code + 1);

            return new ApiResult<decimal>().Success(1);
        }

        [HttpGet("GetRecentParents")]
        public async Task<ApiResult<List<ParentModel>>> GetRecentParents()
        {
            List<ParentModel> parents = await _dbContext.AcpResponsibiles.AsNoTracking().OrderByDescending(x => x.Id).Take(5).ProjectToType<ParentModel>().ToListAsync();


            return new ApiResult<List<ParentModel>>().Success(parents);
        }

        [HttpGet("{parentId:decimal}")]
        public async Task<ApiResult<ParentModel>> GetParent(decimal parentId)
        {
            ApiResult<ParentModel> result = new();
            if (!ModelState.IsValid)
                return result.Fail("Invalid Input");

            try
            {
                var acpResponsible = await _dbContext.AcpResponsibiles.AsNoTracking().FirstOrDefaultAsync(p => p.Id == parentId);
                if (acpResponsible is null)
                    return result.Fail("Parent not found");


                var parent = acpResponsible.Adapt<ParentModel>();

                //parent.Students = students.ProjectToType<StudentModel>();

                parent.Students = (from student in _dbContext.AcpStudents.AsNoTracking().Where(x => x.ParentId == parentId)
                                   join grade in _dbContext.RegGreads.AsNoTracking() on student.CurGreadId equals grade.Id
                                   join year in _dbContext.RegYears.AsNoTracking() on student.CurYearId equals year.Id
                                   join branch in _dbContext.RegBranches.AsNoTracking() on student.CurBranchId equals branch.Id
                                   join section in _dbContext.RegClasses.AsNoTracking() on student.CurClassId equals section.Id into secGroup
                                   from sg in secGroup.DefaultIfEmpty()
                                   select new StudentModel()
                                   {
                                       Branch = branch.Name1,
                                       Code = student.Code,
                                       Grade = grade.Name1,
                                       Id = student.Id,
                                       Name2 = student.Name2,
                                       Section = sg.Name1,
                                       Status = Convert.ToInt16(student.TransferStatus ?? "0"),
                                       Year = year.Name1
                                   });


                return result.Success(parent);
            }
            catch (Exception ex)
            {
                return result.Fail(ex.Message);
                throw;
            }

        }

        [HttpPost]
        public async Task<ApiResult<decimal>> Post([FromBody] ParentModel model)
        {
            ApiResult<decimal> result = new();
            if (!ModelState.IsValid)
                return result.Fail("Invalid Input");

            var newParent = model.Adapt<AcpResponsibile>();
            try
            {
                newParent.Name1 = $"{newParent.Name11} {newParent.Name12} {newParent.Name13} {newParent.Name14}";
                newParent.Name2 = $"{newParent.Name21} {newParent.Name22} {newParent.Name23} {newParent.Name24}";
                //TODO : check validation against existing parent Id
                if (model.Id > 0)
                {
                    // AcpResponsibile? record = await _dbContext.AcpResponsibiles.FindAsync(model.Id);
                    // record = newParent;
                    _dbContext.AcpResponsibiles.Update(newParent);
                }
                else
                {
                    await _dbContext.AcpResponsibiles.AddAsync(newParent);
                }
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return result.Fail(ex.Message);
                throw;
            }

            return result.Success(newParent.Id);
        }


        [HttpDelete("{parentId:decimal}")]
        public async Task<ApiResult<bool>> Delete(decimal parentId)
        {
            using (var trans = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var deletedExams = _dbContext.AcpStuExms.Where(x => x.StuId == parentId);
                    if (deletedExams.Any())
                        _dbContext.AcpStuExms.RemoveRange(deletedExams);

                    var deletedStudents = _dbContext.AcpStudents.FirstOrDefault(x => x.ParentId == parentId);
                    if (deletedStudents != null)
                        _dbContext.AcpStudents.RemoveRange(deletedStudents);

                    var deletedParent = _dbContext.AcpResponsibiles.FirstOrDefault(x => x.Id == parentId);
                    if (deletedParent != null)
                        _dbContext.AcpResponsibiles.Remove(deletedParent);

                    await _dbContext.SaveChangesAsync();
                    await trans.CommitAsync();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return new ApiResult<bool>().Fail(ex.Message);
                }
            }

            return new ApiResult<bool>().Success(true);
        }

        [HttpGet]
        public async Task<ApiResult<IEnumerable<ParentModel>>> GetAll(string? searchTerm = "", string? sortColumn = "", string? sortOrder = "", int page = 1, int pageSize = 5)
        {
            ApiResult<IEnumerable<ParentModel>> result = new();

            if (!ModelState.IsValid)
                return result.Fail("Invalid Input");

            try
            {
                IQueryable<AcpResponsibile> parentsQuery = _dbContext.AcpResponsibiles;

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    parentsQuery = parentsQuery.Where(x => x.Name1.Contains(searchTerm) || x.Name2.Contains(searchTerm));
                }


                Expression<Func<AcpResponsibile, object>> keySelector = sortColumn switch
                {
                    "name" => parent => parent.Name1,
                    _ => parent => parent.Id
                };

                if (!string.IsNullOrEmpty(sortOrder) && sortOrder.ToLower() == "asc")
                    parentsQuery = parentsQuery.OrderBy(keySelector);
                else
                    parentsQuery = parentsQuery.OrderByDescending(keySelector);

                var parents = await parentsQuery.AsNoTracking()
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .Select(acpp => new ParentModel()
                    {
                        Id = acpp.Id,
                        Code = acpp.Code,
                        Address1 = acpp.Address1,
                        Name2 = acpp.Name2,
                        Name1 = acpp.Name1,
                        Tel1 = acpp.Tel1,
                        Tel2 = acpp.Tel2
                    }).ToListAsync();

                return result.Success(parents);
            }
            catch (Exception ex)
            {
                return result.Fail(ex.Message);
                throw;
            }


        }
    }
}

