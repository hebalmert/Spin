using Spin.Domain.Entities;
using Spin.DomainLogic.AppResponses;
using Spin.DomainLogic.ModelUtility;
using Spin.DomainLogic.Pagination;

namespace Spin.AppService.InterfaceEntities;

public interface IStateService
{
    Task<ActionResponse<IEnumerable<State>>> ComboAsync(ClaimsDTOs claimsDTO);

    Task<ActionResponse<IEnumerable<State>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<State>> GetAsync(int id);

    Task<ActionResponse<State>> UpdateAsync(State modelo);

    Task<ActionResponse<State>> AddAsync(State modelo);

    Task<ActionResponse<bool>> DeleteAsync(int id);
}