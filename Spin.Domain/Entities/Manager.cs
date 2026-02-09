using Spin.DomainLogic.EnumTypes;
using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spin.Domain.Entities;

public class Manager
{
    [Key]
    public int ManagerId { get; set; }

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.FirstName), ResourceType = typeof(DisplayNames))]
    public string FirstName { get; set; } = null!;

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.LastName), ResourceType = typeof(DisplayNames))]
    public string LastName { get; set; } = null!;


    [MaxLength(25, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Document), ResourceType = typeof(DisplayNames))]
    public string? NroDocument { get; set; }

    [MaxLength(25, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Phone), ResourceType = typeof(DisplayNames))]
    public string PhoneNumber { get; set; } = null!;

    [MaxLength(25, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Address), ResourceType = typeof(DisplayNames))]
    public string Address { get; set; } = null!;

    [MaxLength(256, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Email), ResourceType = typeof(DisplayNames))]
    public string Email { get; set; } = null!;

    //Usuario para el Logueo
    [StringLength(24, MinimumLength = 6, ErrorMessageResourceName = nameof(ModelValidations.Validation_StringLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [RegularExpression(@"^[a-zA-Z0-9_.-]+$", ErrorMessageResourceName = nameof(ModelValidations.Validation_InvalidFormat), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.UserName), ResourceType = typeof(DisplayNames))]
    public string UserName { get; set; } = null!;

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Corporation), ResourceType = typeof(DisplayNames))]
    public int CorporationId { get; set; }

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.JobPosition), ResourceType = typeof(DisplayNames))]
    public string Job { get; set; } = null!;

    [Display(Name = nameof(DisplayNames.UserType), ResourceType = typeof(DisplayNames))]
    public UserType UserType { get; set; }

    [Display(Name = nameof(DisplayNames.Photo), ResourceType = typeof(DisplayNames))]
    public string? Imagen { get; set; }

    [Display(Name = nameof(DisplayNames.Active), ResourceType = typeof(DisplayNames))]
    public bool Active { get; set; }

    //TODO: Cambio de ruta para Imagenes
    [NotMapped]
    public string? ImageFullPath { get; set; }

    [NotMapped]
    public string? ImgBase64 { get; set; }

    //Relaciones
    public Corporation? Corporation { get; set; }
}