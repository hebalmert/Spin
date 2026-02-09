using Spin.DomainLogic.ModelUtility;

namespace Spin.AppBack.LoadCountries;

public interface IApiService
{
    Task<Response> GetListAsync<T>(string servicePrefix, string controller);
}