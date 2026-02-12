using Spin.Domain.Entities;
using Spin.DomainLogic.ModelUtility;
using Spin.DomainLogic.Pagination;

namespace Spin.AppServiceX.InterfaceEntities;

public interface IManagerServiceX
{
    Task<ActionResponse<IEnumerable<Manager>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<Manager>> GetAsync(int id);

    Task<ActionResponse<Manager>> UpdateAsync(Manager modelo, string frontUrl);

    Task<ActionResponse<Manager>> AddAsync(Manager modelo, string frontUrl);

    Task<ActionResponse<bool>> DeleteAsync(int id);
}