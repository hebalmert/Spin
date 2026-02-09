using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.DomainLogic.AppResponses;

public class RecoveryPassDTO
{
    [EmailAddress(ErrorMessageResourceName = nameof(ModelValidations.Validation_InvalidEmail), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = "Email")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = "User Name")]
    public string UserName { get; set; } = null!;
}