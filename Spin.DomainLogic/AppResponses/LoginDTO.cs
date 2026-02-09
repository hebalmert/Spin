using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.DomainLogic.AppResponses;

public class LoginDTO
{
    [StringLength(20, MinimumLength = 6, ErrorMessageResourceName = nameof(ModelValidations.Validation_StringLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [RegularExpression(@"^(?!.*\.\.)(?!\.)[a-zA-Z0-9.]+(?<!\.)$", ErrorMessageResourceName = nameof(ModelValidations.Validation_UserNameFormat), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.UserName), ResourceType = typeof(DisplayNames))]
    public string UserName { get; set; } = null!;

    [StringLength(20, MinimumLength = 6, ErrorMessageResourceName = nameof(ModelValidations.Validation_StringLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Password), ResourceType = typeof(DisplayNames))]
    public string Password { get; set; } = null!;
}