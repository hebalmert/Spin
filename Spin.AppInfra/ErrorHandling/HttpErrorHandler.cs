using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Spin.DomainLogic.ModelUtility;
using Spin.xLenguage.Resources;

namespace Spin.AppInfra.ErrorHandling;

public class HttpErrorHandler
{
    private readonly IStringLocalizer<Errors> _localizer;
    private readonly ILogger<HttpErrorHandler> _logger;

    public HttpErrorHandler(IStringLocalizer<Errors> localizer, ILogger<HttpErrorHandler> logger)
    {
        _localizer = localizer;
        _logger = logger;
    }

    public Task<ActionResponse<T>> HandleErrorAsync<T>(Exception exception)
    {
        string errorMessage = _localizer[nameof(Errors.Generic_UnexpectedError)];

        if (exception is null)
        {
            errorMessage = _localizer[nameof(Errors.Generic_NullException)];

            _logger.LogError("Null exception received in HttpErrorHandler");

            return Task.FromResult(new ActionResponse<T>
            {
                WasSuccess = false,
                Message = errorMessage,
                Result = default
            });
        }

        _logger.LogError(
            exception,
            "Error capturado en HttpErrorHandler. Tipo: {ExceptionType}, Mensaje: {ExceptionMessage}",
            exception.GetType().Name,
            exception.Message
        );

        if (exception is HttpRequestException httpEx)
        {
            errorMessage = $"{_localizer[nameof(Errors.Generic_Http_BadRequest)]}: {httpEx.Message}";
        }
        else if (exception is DbUpdateException dbEx)
        {
            var innerMsg = dbEx.InnerException?.Message?.ToLower() ?? "";

            if (innerMsg.Contains("duplicate key") || innerMsg.Contains("unique constraint"))
            {
                errorMessage = _localizer[nameof(Errors.Db_Duplicate)];
            }
            else if (innerMsg.Contains("foreign key") || innerMsg.Contains("reference"))
            {
                errorMessage = _localizer[nameof(Errors.Db_Reference)];
            }
            else if (innerMsg.Contains("concurrency"))
            {
                errorMessage = _localizer[nameof(Errors.Db_Concurrency)];
            }
            else
            {
                errorMessage = $"{_localizer[nameof(Errors.Db_Error)]}: {dbEx.Message}";
            }
        }
        else
        {
            errorMessage = $"{_localizer[nameof(Errors.Generic_Exception)]}: {exception.Message}";
        }

        _logger.LogError(
            exception,
            "Mensaje final enviado al cliente: {ErrorMessage}",
            errorMessage
        );

        return Task.FromResult(new ActionResponse<T>
        {
            WasSuccess = false,
            Message = errorMessage,
            Result = default
        });
    }
}
