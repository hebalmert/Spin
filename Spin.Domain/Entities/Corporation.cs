using Spin.Domain.EntitesSoftSec;
using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spin.Domain.Entities;
public class Corporation
{
    [Key]
    public int CorporationId { get; set; }

    [MaxLength(100, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Corporation), ResourceType = typeof(DisplayNames))]
    public string? Name { get; set; }

    [MaxLength(15, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Document), ResourceType = typeof(DisplayNames))]
    public string? NroDocument { get; set; }

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Phone), ResourceType = typeof(DisplayNames))]
    public string? Phone { get; set; }

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Phone2), ResourceType = typeof(DisplayNames))]
    public string? Phone2 { get; set; }

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.FaxNumber), ResourceType = typeof(DisplayNames))]
    public string? FaxNumber { get; set; }

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.FaxNumber2), ResourceType = typeof(DisplayNames))]
    public string? FaxNumber2 { get; set; }

    [MaxLength(256, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Address), ResourceType = typeof(DisplayNames))]
    public string? Address { get; set; }

    [Required]
    [Display(Name = nameof(DisplayNames.Country), ResourceType = typeof(DisplayNames))]
    public int CountryId { get; set; }

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.DateStart), ResourceType = typeof(DisplayNames))]
    public DateTime DateStart { get; set; }

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.DateEnd), ResourceType = typeof(DisplayNames))]
    public DateTime DateEnd { get; set; }

    [Display(Name = nameof(DisplayNames.Logo), ResourceType = typeof(DisplayNames))]
    public string? Imagen { get; set; }

    [Display(Name = nameof(DisplayNames.Active), ResourceType = typeof(DisplayNames))]
    public bool Active { get; set; }

    [NotMapped]
    public string? ImageFullPath { get; set; }

    [NotMapped]
    public string? ImgBase64 { get; set; }

    public Country? Country { get; set; }
    public ICollection<Manager>? Managers { get; set; }
    public ICollection<Usuario>? Usuarios { get; set; }
    public ICollection<UsuarioRole>? UsuarioRoles { get; set; }
}