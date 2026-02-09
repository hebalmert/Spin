using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.Domain.Entities;

public class City
{
    [Key]
    public int CityId { get; set; }

    [Display(Name = nameof(DisplayNames.State), ResourceType = typeof(DisplayNames))]
    public int StateId { get; set; }

    [MaxLength(100, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.City), ResourceType = typeof(DisplayNames))]
    public string Name { get; set; } = null!;

    //Relaciones
    public State? State { get; set; }
}