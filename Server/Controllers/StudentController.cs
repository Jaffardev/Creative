using Creative.Data;
using Creative.Data.Models;
using Creative.Shared;
using Creative.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mapster;
using static MudBlazor.CategoryTypes;

namespace Creative.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public StudentController(ILogger<StudentController> logger, ApplicationDbContext dbContext)
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
        public async Task<ApiResult<AdmissionModel>> GetStudentData(decimal studentId)
        {
            var regStudent = await _dbContext.AcpStudents.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == studentId);

            if (regStudent == null)
            {
                return new ApiResult<AdmissionModel>().Fail("Data not found");
            }

            var student = regStudent?.Adapt<AdmissionModel>();
            student.Exams = await (from stexam in _dbContext.AcpStuExms.AsNoTracking().Where(x => x.StuId == studentId)
                                   join sch in _dbContext.AcpExmSchedules.AsNoTracking() on stexam.ScheduleId equals sch.Id
                                   join exam in _dbContext.AcpExams.AsNoTracking() on sch.ExmId equals exam.Id
                                   join room in _dbContext.AcpExmRooms.AsNoTracking() on sch.RoomId equals room.Id
                                   select new ExamEditModel
                                   {
                                       Id = stexam.Id,
                                       Code = stexam.Code,
                                       Degree = stexam.Degree,
                                       Schedule = new()
                                       {
                                           ExamDate = sch.ExmDate,
                                           Exam = exam.Name1,
                                           Room = room.Name1,
                                           Id = sch.Id,
                                           Name = sch.Name1,
                                       },
                                       Notes = stexam.Notes,
                                       StuId = stexam.StuId
                                   }).ToListAsync();

            return new ApiResult<AdmissionModel>().Success(student);
        }

        [HttpPost]
        public async Task<ApiResult<decimal>> Post([FromBody] AdmissionModel model)
        {
            ApiResult<decimal> result = new();
            if (!ModelState.IsValid)
                return result.Fail("Invalid Input");

            try
            {
                DateTime currentTime = DateTime.Now;

                var student = model.Adapt<AcpStudent>();
                //{
                //    StuPayBy = model.StuPayBy.ToString(),
                //    Code = model.Code,
                //    StuStatus = model.StuStatus?.ToString(),
                //    ParentId = model.ParentId,
                //    Gender = model.Gender.ToString(),
                //    Name11 = model.Name11,
                //    Name12 = model.Name12,
                //    Name13 = model.Name13,
                //    Name14 = model.Name14,
                //    Name15 = model.Name15,
                //    Name1 = $"{model.Name11} {model.Name12} {model.Name13} {model.Name14} {model.Name15}",
                //    Name21 = model.Name21,
                //    Name22 = model.Name22,
                //    Name23 = model.Name23,
                //    Name24 = model.Name24,
                //    Name25 = model.Name25,
                //    Name2 = $"{model.Name21} {model.Name22} {model.Name23} {model.Name24} {model.Name25}",
                //    Notes = model.Notes,
                //    DeptNotes = model.DeptNotes,
                //    StuResult = model.Result?.ToString(),
                //    NationalId = model.NationalId,
                //    RelegionId = model.RelegionId,
                //    StuType = model.StudentType?.ToString(),
                //    AdmissionDate = model.AdmissionDate,
                //    RegistrationDate = model.RegistrationDate,
                //    JoinDate = model.JoinDate,
                //    BirthDate = model.BirthDate,
                //    ComeBranchId = model.ComeBranchId,
                //    ComeGradeId = model.ComeGradeId,
                //    ComeYearId = model.ComeYearId,
                //    CurBranchId = model.CurBranchId,
                //    CurGreadId = model.CurGradeId,
                //    CurYearId = model.CurYearId,
                //    CurClassId = model.CurClassId,
                //    HealthStatus = model.HealthStatus ? "1" : "0",
                //    HealthFileNo = model.HealthFileNo,
                //    EducationDecisionNo = model.EducationDecisionNo,
                //    DisablityAsPerTheDecision = model.DisablityAsPerTheDecisionId,
                //    ExaminationResult = model.ExaminationResult,
                //    EduDecisionDate = model.EduDecisionDate,
                //    NextVisitDate = model.NextVisitDate,
                //    DisablityCertificateId = model.DisablityCertificateId,
                //    EduProveDate = model.EduProveDate,
                //    EduProveEndDate = model.EduProveEndDate,
                //    MotherName = model.MotherName,
                //    MotherCivilID = model.MotherCivilID,
                //    Tel1 = model.Tel1,
                //    Tel2 = model.Tel2,
                //    Email = model.Email,
                //    Address1 = model.Address1,
                //    PassportDate = model.PassportDate,
                //    BirthPlace = model.BirthPlace,
                //    BirthDocPlace = model.BirthDocPlace,
                //    IdNo = model.IdNumber,
                //    EmpId = model.EmpId,
                //    IdEndDate = model.EndDate,
                //    ModifyDate = currentTime
                //};

             
                if (model.Id > 0)
                {
                    student.Id = model.Id;
                    _dbContext.Entry(student).State = EntityState.Modified;
                }
                else
                {
                    student.CreationDate = currentTime;
                    await _dbContext.AcpStudents.AddAsync(student);
                }

                await _dbContext.SaveChangesAsync();
                if (model.Exams.Count != 0)
                {
                    foreach (var item in model.Exams.Where(x => x.State == State.Edit && x.Id > 0))
                    {
                        var acpExam = await _dbContext.AcpStuExms.FirstOrDefaultAsync(x => x.Id == item.Id);

                        if (acpExam != null)
                        {
                            acpExam.ModifyDate = currentTime;
                            acpExam.Code = item.Code;
                            acpExam.Degree = item.Degree;
                            acpExam.Notes = item.Notes;
                            acpExam.StuId = student.Id;
                            acpExam.ScheduleId = item.Schedule.Id;
                        }
                    }

                    var newItems = model.Exams.Where(x => x.State == State.Add && x.Id == 0).Select(x => new AcpStuExm()
                    {
                        CreationDate = currentTime,
                        ModifyDate = currentTime,
                        Code = x.Code,
                        Degree = x.Degree,
                        Notes = x.Notes,
                        StuId = student.Id,
                        ScheduleId = x.Schedule.Id
                    });
                    if (newItems.Any())
                        await _dbContext.AcpStuExms.AddRangeAsync(newItems);

                    var deletedItems = model.Exams.Where(x => x.State == State.Delete && x.Id > 0).Select(x => x.Adapt<AcpStuExm>());
                    if (deletedItems.Any())
                        _dbContext.AcpStuExms.RemoveRange(deletedItems);

                    await _dbContext.SaveChangesAsync();

                  
                }

                return result.Success(student.Id);
            }
            //catch (DbEntityValidationException ex)
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

        [HttpDelete("{studentId:decimal}")]
        public async Task<ApiResult<bool>> Delete(decimal studentId)
        {
            using (var trans = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var deletedExams = _dbContext.AcpStuExms.Where(x => x.StuId == studentId);
                    if (deletedExams.Any())
                        _dbContext.AcpStuExms.RemoveRange(deletedExams);

                    //var deletedStudent = _dbContext.AcpStudents.FirstOrDefault(x => x.Id == studentId);
                    //if (deletedStudent != null)
                    _dbContext.AcpStudents.Remove(new AcpStudent { Id=studentId });

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


        [HttpGet("GetStuExams")]
        public async Task<ApiResult<IEnumerable<ExamEditModel>>> GetStuExams(decimal studentId)
        {
            var stuExams = (from exam in _dbContext.AcpStuExms.Where(x => x.StuId == studentId)
                            join sch in _dbContext.AcpExmSchedules on exam.ScheduleId equals sch.Id
                            join room in _dbContext.AcpExmRooms.AsNoTracking() on sch.RoomId equals room.Id
                            select new ExamEditModel
                            {
                                Id = exam.Id,
                                Code = exam.Code,
                                Degree = exam.Degree,
                                Notes = exam.Notes,
                                StuId = exam.StuId,
                                Schedule = new()
                                {
                                    ExamDate = sch.ExmDate,
                                    Exam = exam.Name1,
                                    Room = room.Name1,
                                    Id = sch.Id
                                }
                            });

            return new ApiResult<IEnumerable<ExamEditModel>>().Success(stuExams);
        }

        [HttpPost("InsertStuExams")]
        public async Task<ApiResult<decimal>> InsertStuExams(ExamEditModel request)
        {
            var stuExa = request.Adapt<AcpStuExm>();

            await _dbContext.AcpStuExms.AddAsync(stuExa);
            await _dbContext.SaveChangesAsync();


            // var stuExams = (from exam in _dbContext.AcpStuExms.Where(x => x.StuId == studentId)
            //                 join sch in _dbContext.AcpExmSchedules on exam.ScheduleId equals sch.Id
            //                 select new StudentExams
            //                 {
            //                     Code = exam.Code,
            //                     Degree = exam.Degree,
            //                     ExmDate = sch.ExmDate,
            //                     ExmId = sch.ExmId,
            //                     Id = exam.Id,
            //                     Notes = exam.Notes,
            //                     RoomId = sch.RoomId,
            //                     ScheduleId = sch.Id,
            //                     StuId = exam.StuId
            //                 });

            return new ApiResult<decimal>().Success(stuExa.Id);
        }

    }
}