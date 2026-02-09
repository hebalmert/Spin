using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.Domain.Entities;

public class Country
{
    [Key]
    public int CountryId { get; set; }

    [MaxLength(100, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Country), ResourceType = typeof(DisplayNames))]
    public string Name { get; set; } = null!;

    [Display(Name = nameof(DisplayNames.States), ResourceType = typeof(DisplayNames))]
    public int StatesNumber => States == null ? 0 : States.Count;

    //relaciones
    public ICollection<State>? States { get; set; }

    public ICollection<Corporation>? Corporations { get; set; }
}