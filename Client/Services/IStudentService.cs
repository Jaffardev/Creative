﻿using Creative.Shared;
using Creative.Shared.Models;
using Refit;

namespace Creative.Client.Services;

public interface IStudentService
{
    const string controller = "/api/Student/";

    [Get($"{controller}{nameof(GetNewCode)}")]
    Task<ApiResult<decimal>> GetNewCode();

    [Get($"{controller}{nameof(GetNewExamCode)}")]
    Task<ApiResult<decimal>> GetNewExamCode();

    [Get($"{controller}{nameof(GetAll)}")]
    Task<IEnumerable<RegStudentModel>> GetAll();

    [Post($"{controller}")]
    Task<ApiResult<decimal>> Post([Body] AdmissionModel model);

    [Get(controller + "{studentId}")]
    Task<ApiResult<AdmissionModel>> GetStudent(decimal studentId);

    [Get($"{controller}{nameof(GetStuExams)}")]
    Task<ApiResult<IEnumerable<ExamEditModel>>> GetStuExams(decimal studentId);

    [Post($"{controller}{nameof(InsertStuExams)}")]
    Task<ApiResult<decimal>> InsertStuExams(ExamEditModel request);

    [Delete(controller + "{studentId}")]
    Task<ApiResult<bool>> Delete(decimal studentId);

}
