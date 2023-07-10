using Creative.Shared;
using Creative.Shared.Models;
using Refit;

namespace Creative.Client.Services;

public interface ILookupService
{
    const string controller = "/api/Lookup/";

    [Get($"{controller}")]
    Task<ApiResult<AcademicLookups>> Get(Lookup lookup, string? searchTerm = "", int page = 1, int pageSize = 5);

    [Get($"{controller}{nameof(Many)}")]
    Task<ApiResult<AcademicLookups>> Many(Lookup[] lookups, string? searchTerm = "", int page = 1, int pageSize = 5);

    [Get($"{controller}{nameof(GetClass)}")]
    Task<ApiResult<IEnumerable<Item>>> GetClass(decimal gradeId, decimal branchId, string gender);

    [Get($"{controller}{nameof(GetSchedules)}")]
    Task<ApiResult<IEnumerable<ScheduleItem>>> GetSchedules();


    [Get($"{controller}{nameof(Search)}")]
    Task<ApiResult<IEnumerable<Item>>> Search(decimal branchId, string searchTerm, bool noStudent = false, int page = 1, int pageSize = 5);

    [Get($"{controller}{nameof(GetEligibleData)}")]
    Task<ApiResult<EligibleData>> GetEligibleData(DateTime dateOfBith, decimal branchId);
}
