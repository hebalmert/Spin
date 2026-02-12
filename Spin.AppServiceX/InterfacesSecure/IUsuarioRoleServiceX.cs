using Spin.Domain.EntitesSoftSec;
using Spin.DomainLogic.ModelUtility;
using Spin.DomainLogic.Pagination;

namespace Spin.AppServiceX.InterfacesSecure;

public interface IUsuarioRoleServiceX
{
    Task<ActionResponse<IEnumerable<IntNameModel>>> ComboAsync();

    Task<ActionResponse<IEnumerable<UsuarioRole>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<UsuarioRole>> GetAsync(Guid id);

    Task<ActionResponse<UsuarioRole>> AddAsync(UsuarioRole modelo, string Email);

    Task<ActionResponse<bool>> DeleteAsync(Guid id);
}