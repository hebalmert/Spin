using Spin.Domain.Entities;
using Spin.DomainLogic.ModelUtility;
using Spin.DomainLogic.Pagination;

namespace Spin.AppService.InterfaceEntities;

public interface ICountryService
{
    Task<ActionResponse<IEnumerable<Country>>> ComboAsync();

    Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<Country>> GetAsync(int id);

    Task<ActionResponse<Country>> UpdateAsync(Country modelo);

    Task<ActionResponse<Country>> AddAsync(Country modelo);

    Task<ActionResponse<bool>> DeleteAsync(int id);
}