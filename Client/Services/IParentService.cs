using Creative.Shared;
using Creative.Shared.Models;
using Refit;

namespace Creative.Client.Services
{

    public interface IParentService
    {
        const string controller = "/api/Parents/";


        [Get($"{controller}{nameof(GetNewCode)}")]
        Task<ApiResult<decimal>> GetNewCode();

        [Post($"{controller}{nameof(NewEditParent)}")]
        Task<ApiResult<decimal>> NewEditParent([Body] ParentModel model);

        [Get($"{controller}")]
        Task<ApiResult<IEnumerable<ParentModel>>> GetAllParents(string? searchTerm = "", string? sortColumn = "", string? sortOrder = "", int page = 1, int pageSize = 5);

        [Get(controller + "{parentId}")]
        Task<ApiResult<ParentModel>> GetParent(decimal parentId);
    }
}
