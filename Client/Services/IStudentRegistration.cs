using Creative.Data.Models;
using Creative.Shared;
using Creative.Shared.Models;
using Refit;

namespace Creative.Server.Services;

public interface IRegistrationService
{
    const string controller = "/api/Registration/";

    [Get($"{controller}{nameof(GetAll)}")]
    Task<IEnumerable<RegStudentModel>> GetAll();

    [Post($"{controller}")]
    Task<ApiResult<bool>> Post([Body] AdmissionModel model);

    //[Get($"{controller}{nameof(GetParentData)}")]
    //Task<ResponsibleModel> GetParentData(decimal parentId);
}
