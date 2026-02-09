using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.DomainLogic.AppResponses;

public class ChangePasswordDTO
{
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [StringLength(20, MinimumLength = 6, ErrorMessageResourceName = nameof(ModelValidations.Validation_StringLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Currtent_Password), ResourceType = typeof(DisplayNames))]
    public string CurrentPassword { get; set; } = null!;

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [StringLength(20, MinimumLength = 6, ErrorMessageResourceName = nameof(ModelValidations.Validation_StringLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = "New Password")]
    public string NewPassword { get; set; } = null!;

    [Compare("NewPassword", ErrorMessageResourceName = nameof(ModelValidations.Validation_PasswordMismatch), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [StringLength(20, MinimumLength = 6, ErrorMessageResourceName = nameof(ModelValidations.Validation_StringLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Confirm_Pasword), ResourceType = typeof(DisplayNames))]
    public string Confirm { get; set; } = null!;
}