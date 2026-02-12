using Spin.AppService.InterfaceEntities;
using Spin.AppServiceX.InterfaceEntities;
using Spin.Domain.Entities;
using Spin.DomainLogic.ModelUtility;
using Spin.DomainLogic.Pagination;

namespace Spin.UnitOfWork.ImplementEntities;

public class CorporationServiceX : ICorporationServiceX
{
    private readonly ICorporationService _corporationService;

    public CorporationServiceX(ICorporationService corporationService)
    {
        _corporationService = corporationService;
    }

    public async Task<ActionResponse<IEnumerable<Corporation>>> ComboAsync() => await _corporationService.ComboAsync();

    public async Task<ActionResponse<IEnumerable<Corporation>>> GetAsync(PaginationDTO pagination) => await _corporationService.GetAsync(pagination);

    public async Task<ActionResponse<Corporation>> GetAsync(int id) => await _corporationService.GetAsync(id);

    public async Task<ActionResponse<Corporation>> UpdateAsync(Corporation modelo) => await _corporationService.UpdateAsync(modelo);

    public async Task<ActionResponse<Corporation>> AddAsync(Corporation modelo) => await _corporationService.AddAsync(modelo);

    public async Task<ActionResponse<bool>> DeleteAsync(int id) => await _corporationService.DeleteAsync(id);
}