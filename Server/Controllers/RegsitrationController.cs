using Creative.Data;
using Creative.Data.Models;
using Creative.Shared;
using Creative.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mapster;

namespace Creative.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationController : ControllerBase
    {

        private readonly ILogger<RegistrationController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public RegistrationController(ILogger<RegistrationController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            this._dbContext = dbContext;
        }

        [HttpGet("GetNewCode")]
        public async Task<ApiResult<decimal>> GetNewCode()
        {
            string code = (await _dbContext.AcpStudents.AsNoTracking().OrderByDescending(x => x.Id).FirstOrDefaultAsync())?.Code ?? "0";

            if (decimal.TryParse(code, out decimal _code))
                return new ApiResult<decimal>().Success(_code + 1);

            return new ApiResult<decimal>().Success(1);
        }


        [HttpGet("{studentId:decimal}")]
        public async Task<ApiResult<AdmissionModel>> GetStudent(decimal studentId)
        {
            var regStudent = await _dbContext.AcpStudents.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == studentId);

            if (regStudent == null)
            {
                return new ApiResult<AdmissionModel>().Fail("Data not found");
            }

            return new ApiResult<AdmissionModel>().Success(regStudent?.Adapt<AdmissionModel>());
        }



        [HttpGet("GetAll")]
        public async Task<IEnumerable<RegStudentModel>> GetStudent()
        {
            return await _dbContext.AcpStudents.AsNoTracking()
                .OrderByDescending(x => x.Id).Select(x => new RegStudentModel()
                {
                    Id = x.Id,
                    Name1 = x.Name1,
                    Name2 = x.Name2,
                    Tel1 = x.Tel1,
                    Tel2 = x.Tel2,
                    ResedenceNo = x.ResedenceNo,
                    FinanceName = x.FinanceName,
                    BranchId = x.CurBranchId,
                    GradeId = x.CurGreadId,
                    ClassId = x.CurClassId,
                    YearId = x.CurYearId
                }).Take(5).ToListAsync();
        }


        [HttpPost]
        public async Task<ApiResult<decimal>> Post([FromBody] AdmissionModel model)
        {
            ApiResult<decimal> result = new();
            if (!ModelState.IsValid)
                return result.Fail("Invalid Input");

            try
            {
                var student = new AcpStudent()
                {
                    Code = model.Code,
                    StuStatus = ((int)model.StuStatus).ToString(),
                    ParentId = model.ParentId,
                    Gender = model.Gender.ToString(),
                    Name1 = $"{model.Name11} {model.Name12} {model.Name13} {model.Name14}",
                    Name2 = $"{model.Name21} {model.Name22} {model.Name23} {model.Name24}",
                    Notes = model.Notes,
                    DeptNotes = model.DeptNotes,
                    StuResult = ((int)model.Result).ToString(),
                    NationalId = model.NationalId,
                    RelegionId = model.RelegionId,
                    StuType = model.StudentType.ToString(),
                    AdmissionDate = model.AdmissionDate,
                    RegistrationDate = model.RegistrationDate,
                    JoinDate = model.JoinDate,
                    BirthDate = model.BirthDate,
                    ComeBranchId = model.ComeBranchId,
                    ComeGradeId = model.ComeGradeId,
                    ComeYearId = model.ComeYearId,
                    CurBranchId = model.ComeBranchId,
                    CurGreadId = model.ComeGradeId,
                    CurYearId = model.ComeYearId,
                    CurClassId = model.CurClassId,
                    HealthStatus = model.HealthStatus ? "1" : "0",
                    HealthFileNo = model.HealthFileNo,
                    EducationDecisionNo = model.EducationDecisionNo,
                    DisablityAsPerTheDecision = model.DisablityAsPerTheDecisionId,
                    ExaminationResult = model.ExaminationResult,
                    EduDecisionDate = model.EduDecisionDate,
                    NextVisitDate = model.NextVisitDate,
                    DisablityCertificateId = model.DisablityCertificateId,
                    EduProveDate = model.EduProveDate,
                    EduProveEndDate = model.EduProveEndDate,
                    MotherName = model.MotherName,
                    MotherCivilID = model.MotherCivilID,
                    Tel1 = model.Tel1,
                    Tel2 = model.Tel2,
                    Email = model.Email,
                    Address1 = model.Address1,
                    PassportDate = model.PassportDate,
                    BirthPlace = model.BirthPlace,
                    BirthDocPlace = model.BirthDocPlace,
                    IdNo = model.IdNumber,
                    EmpId = model.EmpId,
                    IdEndDate = model.EndDate
                };
                var response = await _dbContext.AcpStudents.AddAsync(student);
                await _dbContext.SaveChangesAsync();

                if (model.Exams.Count != 0)
                {
                    foreach (var item in model.Exams.Where(x => x.Action == CRUDAction.Edit))
                    {
                        var acpExam = await _dbContext.AcpExams.FirstOrDefaultAsync(x => x.Id == item.Id);
                        acpExam.Code = item.Code;
                        acpExam.ModifyDate = DateTime.Now;
                        acpExam.Degree = item.Degree;
                        acpExam.Name1 = item.Name1;
                        acpExam.Name2 = item.Name2;
                        acpExam.Notes = item.Notes;
                        acpExam.TypeId = item.TypeId;
                    }
                    await _dbContext.SaveChangesAsync();

                    var newItems = model.Exams.Where(x => x.Action == CRUDAction.Add).Select(x => new AcpExam()
                    {
                        Code = x.Code,
                        CreationDate = DateTime.Now,
                        Degree = x.Degree,
                        Name1 = x.Name1,
                        Name2 = x.Name2,
                        Notes = x.Notes,
                        TypeId = x.TypeId,

                        ExmStartTime = x.ExmStartTime.ToDateTime(TimeOnly.MinValue)
                    });

                    if (newItems.Any())
                        await _dbContext.AcpExams.AddRangeAsync(newItems);

                    var deleteItems = model.Exams.Where(x => x.Action == CRUDAction.Delete);

                    if (deleteItems.Any())
                        await _dbContext.AcpExams.Where(x => deleteItems.Any(di => di.Id == x.Id)).ExecuteDeleteAsync();
                }

                return result.Success(student.Id);
            }
            //catch (DbEntityValidationException  ex)
            //{
            //    return result.Fail(ex.Message);
            //}
            catch (Exception ex)
            {
                var entries = _dbContext.ChangeTracker.Entries().Where(e => e.State != Microsoft.EntityFrameworkCore.EntityState.Unchanged);
                foreach (var entry in entries)
                {
                    foreach (var prop in entry.CurrentValues.Properties)
                    {
                        var val = prop.PropertyInfo.GetValue(entry.Entity);
                        Console.WriteLine($"{prop.ToString()} ~ ({val?.ToString().Length})({val})");
                    }
                }
                return result.Fail(ex.Message);
            }

        }


        // [HttpGet("GetStuExams")]
        // public async Task<ApiResult<IEnumerable<StudentExams>>> GetStuExams(decimal studentId)
        // {
        //     var stuExams = (from exam in _dbContext.AcpStuExms.Where(x => x.StuId == studentId)
        //                     join sch in _dbContext.AcpExmSchedules on exam.ScheduleId equals sch.Id
        //                     select new StudentExams
        //                     {
        //                         Code = exam.Code,
        //                         Degree = exam.Degree,
        //                         ExmDate = sch.ExmDate,
        //                         ExmId = sch.ExmId,
        //                         Id = exam.Id,
        //                         Notes = exam.Notes,
        //                         RoomId = sch.RoomId,
        //                         ScheduleId = sch.Id,
        //                         StuId = exam.StuId
        //                     });

        //     return new ApiResult<IEnumerable<StudentExams>>().Success(stuExams);
        // }

        // [HttpPost("InsertStuExams")]
        // public async Task<ApiResult<decimal>> InsertStuExams(StudentExams request)
        // {
        //     var stuExa = request.Adapt<AcpStuExm>();

        //     await _dbContext.AcpStuExms.AddAsync(stuExa);
        //     await _dbContext.SaveChangesAsync();


        //     // var stuExams = (from exam in _dbContext.AcpStuExms.Where(x => x.StuId == studentId)
        //     //                 join sch in _dbContext.AcpExmSchedules on exam.ScheduleId equals sch.Id
        //     //                 select new StudentExams
        //     //                 {
        //     //                     Code = exam.Code,
        //     //                     Degree = exam.Degree,
        //     //                     ExmDate = sch.ExmDate,
        //     //                     ExmId = sch.ExmId,
        //     //                     Id = exam.Id,
        //     //                     Notes = exam.Notes,
        //     //                     RoomId = sch.RoomId,
        //     //                     ScheduleId = sch.Id,
        //     //                     StuId = exam.StuId
        //     //                 });

        //     return new ApiResult<decimal>().Success(stuExa.Id);
        // }

    }
}