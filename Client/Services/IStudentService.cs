using Creative.Shared;
using Creative.Shared.Models;
using Refit;

namespace Creative.Client.Services;

public interface IStudentService
{
    const string controller = "/api/Registration/";

    [Get($"{controller}{nameof(GetNewCode)}")]
    Task<ApiResult<decimal>> GetNewCode();

    [Get($"{controller}{nameof(GetAll)}")]
    Task<IEnumerable<RegStudentModel>> GetAll();

    [Post($"{controller}")]
    Task<ApiResult<decimal>> Post([Body] AdmissionModel model);

    [Get(controller + "{studentId}")]
    Task<ApiResult<AdmissionModel>> GetStudent(decimal studentId);

    //[Get($"{controller}{nameof(GetParentData)}")]
    //Task<ResponsibleModel> GetParentData(decimal parentId);
}
