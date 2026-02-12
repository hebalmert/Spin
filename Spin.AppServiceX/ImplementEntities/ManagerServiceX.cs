using Spin.AppService.InterfaceEntities;
using Spin.AppServiceX.InterfaceEntities;
using Spin.Domain.Entities;
using Spin.DomainLogic.ModelUtility;
using Spin.DomainLogic.Pagination;

namespace Spin.UnitOfWork.ImplementEntities;

public class ManagerServiceX : IManagerServiceX
{
    private readonly IManagerService _managerService;

    public ManagerServiceX(IManagerService managerService)
    {
        _managerService = managerService;
    }

    public async Task<ActionResponse<IEnumerable<Manager>>> GetAsync(PaginationDTO pagination) => await _managerService.GetAsync(pagination);

    public async Task<ActionResponse<Manager>> GetAsync(int id) => await _managerService.GetAsync(id);

    public async Task<ActionResponse<Manager>> UpdateAsync(Manager modelo, string frontUrl) => await _managerService.UpdateAsync(modelo, frontUrl);

    public async Task<ActionResponse<Manager>> AddAsync(Manager modelo, string frontUrl) => await _managerService.AddAsync(modelo, frontUrl);

    public async Task<ActionResponse<bool>> DeleteAsync(int id) => await _managerService.DeleteAsync(id);
}