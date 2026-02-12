using Spin.Domain.Entities;
using Spin.DomainLogic.EnumTypes;
using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.Domain.EntitesSoftSec;

public class UsuarioRole
{
    [Key]
    public Guid UsuarioRoleId { get; set; }
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.User), ResourceType = typeof(DisplayNames))]
    public int UsuarioId { get; set; }

    [Display(Name = nameof(DisplayNames.RoleUser), ResourceType = typeof(DisplayNames))]
    public UserType UserType { get; set; }

    //Relaciones
    public int CorporationId { get; set; }

    public Corporation? Corporation { get; set; }

    public Usuario? Usuario { get; set; }
}