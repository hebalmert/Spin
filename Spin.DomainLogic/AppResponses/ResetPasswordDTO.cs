using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.DomainLogic.AppResponses;

public class ResetPasswordDTO
{
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [EmailAddress(ErrorMessageResourceName = nameof(ModelValidations.Validation_InvalidEmail), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = "Email")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [EmailAddress(ErrorMessageResourceName = nameof(ModelValidations.Validation_InvalidEmail), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = "User Name")]
    public string UserName { get; set; } = null!;

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [StringLength(20, MinimumLength = 6, ErrorMessageResourceName = nameof(ModelValidations.Validation_StringLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = "New Password")]
    public string NewPassword { get; set; } = null!;

    [Compare("NewPassword", ErrorMessageResourceName = nameof(ModelValidations.Validation_PasswordMismatch), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [StringLength(20, MinimumLength = 6, ErrorMessageResourceName = nameof(ModelValidations.Validation_StringLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; } = null!;

    public string Token { get; set; } = null!;
}