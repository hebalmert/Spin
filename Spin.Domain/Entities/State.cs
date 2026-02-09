using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.Domain.Entities;

public class State
{
    [Key]
    public int StateId { get; set; }

    public int CountryId { get; set; }

    [MaxLength(100, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.State), ResourceType = typeof(DisplayNames))]
    public string Name { get; set; } = null!;

    [Display(Name = nameof(DisplayNames.Cities), ResourceType = typeof(DisplayNames))]
    public int CitiesNumber => Cities == null ? 0 : Cities.Count;

    //Relaciones
    public Country? Country { get; set; }

    public ICollection<City>? Cities { get; set; }
}