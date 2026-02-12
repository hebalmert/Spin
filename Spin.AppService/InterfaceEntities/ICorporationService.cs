using Spin.Domain.Entities;
using Spin.DomainLogic.ModelUtility;
using Spin.DomainLogic.Pagination;

namespace Spin.AppService.InterfaceEntities;

public interface ICorporationService
{
    Task<ActionResponse<IEnumerable<Corporation>>> ComboAsync();

    Task<ActionResponse<IEnumerable<Corporation>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<Corporation>> GetAsync(int id);

    Task<ActionResponse<Corporation>> UpdateAsync(Corporation modelo);

    Task<ActionResponse<Corporation>> AddAsync(Corporation modelo);

    Task<ActionResponse<bool>> DeleteAsync(int id);
}