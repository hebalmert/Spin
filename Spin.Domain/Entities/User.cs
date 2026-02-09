using Microsoft.AspNetCore.Identity;
using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spin.Domain.Entities;

public class User : IdentityUser
{
    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.FirstName), ResourceType = typeof(DisplayNames))]
    public string FirstName { get; set; } = null!;

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.LastName), ResourceType = typeof(DisplayNames))]
    public string LastName { get; set; } = null!;

    //Identificacion de Origenes y Role del Usuario
    [Display(Name = nameof(DisplayNames.Origin), ResourceType = typeof(DisplayNames))]
    public string? UserFrom { get; set; }

    [Display(Name = nameof(DisplayNames.Photo), ResourceType = typeof(DisplayNames))]
    public string? PhotoUser { get; set; }

    [Display(Name = nameof(DisplayNames.Active), ResourceType = typeof(DisplayNames))]
    public bool Active { get; set; }

    [NotMapped]
    public string? Pass { get; set; }

    public int? CorporationId { get; set; }

    //Relaciones
    public Corporation? Corporation { get; set; }

    public ICollection<UserRoleDetails>? UserRoleDetails { get; set; }
}