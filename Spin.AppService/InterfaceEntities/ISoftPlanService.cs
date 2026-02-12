using Spin.Domain.Entities;
using Spin.DomainLogic.ModelUtility;
using Spin.DomainLogic.Pagination;

namespace Spin.AppService.InterfaceEntities;

public interface ISoftPlanService
{
    Task<ActionResponse<IEnumerable<SoftPlan>>> ComboAsync();

    Task<ActionResponse<IEnumerable<SoftPlan>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<SoftPlan>> GetAsync(int id);

    Task<ActionResponse<SoftPlan>> UpdateAsync(SoftPlan modelo);

    Task<ActionResponse<SoftPlan>> AddAsync(SoftPlan modelo);

    Task<ActionResponse<bool>> DeleteAsync(int id);
}