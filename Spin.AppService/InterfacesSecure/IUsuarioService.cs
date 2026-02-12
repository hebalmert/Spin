using Spin.Domain.EntitesSoftSec;
using Spin.DomainLogic.ModelUtility;
using Spin.DomainLogic.Pagination;

namespace Spin.AppService.InterfacesSecure;

public interface IUsuarioService
{

    Task<ActionResponse<IEnumerable<Usuario>>> GetAsync(PaginationDTO pagination, string username);

    Task<ActionResponse<Usuario>> GetAsync(Guid id);

    Task<ActionResponse<Usuario>> UpdateAsync(Usuario modelo, string UrlFront);

    Task<ActionResponse<Usuario>> AddAsync(Usuario modelo, string urlFront, string username);

    Task<ActionResponse<bool>> DeleteAsync(Guid id);
}