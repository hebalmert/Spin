using Spin.Domain.Entities;
using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spin.Domain.EntitesSoftSec;

public class Usuario
{
    [Key]
    public Guid UsuarioId { get; set; }

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.FirstName), ResourceType = typeof(DisplayNames))]
    public string FirstName { get; set; } = null!;

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.LastName), ResourceType = typeof(DisplayNames))]
    public string LastName { get; set; } = null!;

    [MaxLength(15, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Document), ResourceType = typeof(DisplayNames))]
    public string Nro_Document { get; set; } = null!;

    [MaxLength(25, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Phone), ResourceType = typeof(DisplayNames))]
    public string? PhoneNumber { get; set; }

    [MaxLength(256, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [DataType(DataType.MultilineText)]
    [Display(Name = nameof(DisplayNames.Address), ResourceType = typeof(DisplayNames))]
    public string? Address { get; set; }

    [MaxLength(256, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [DataType(DataType.EmailAddress)]
    [Display(Name = nameof(DisplayNames.Email), ResourceType = typeof(DisplayNames))]
    public string Email { get; set; } = null!;

    [MaxLength(24)]
    [StringLength(24, MinimumLength = 6, ErrorMessageResourceName = nameof(ModelValidations.Validation_StringLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [RegularExpression(@"^[a-zA-Z0-9_.-]+$", ErrorMessageResourceName = nameof(ModelValidations.Validation_UserNameFormat), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.UserName), ResourceType = typeof(DisplayNames))]
    public string UserName { get; set; } = null!;

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.JobPosition), ResourceType = typeof(DisplayNames))]
    public string? Job { get; set; }

    [Display(Name = nameof(DisplayNames.Photo), ResourceType = typeof(DisplayNames))]
    public string? Photo { get; set; }

    [Display(Name = nameof(DisplayNames.Active), ResourceType = typeof(DisplayNames))]
    public bool Active { get; set; }

    public int TotalRoles => UsuarioRoles == null ? 0 : UsuarioRoles.Count();

    [NotMapped]
    public string? ImageFullPath { get; set; }

    [NotMapped]
    public string? ImgBase64 { get; set; }

    public int CorporationId { get; set; }
    public Corporation? Corporation { get; set; }
    public ICollection<UsuarioRole>? UsuarioRoles { get; set; }
}