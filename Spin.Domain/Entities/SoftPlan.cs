using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.Domain.Entities;

public class SoftPlan
{
    [Key]
    public int SoftPlanId { get; set; }

    [MaxLength(50, ErrorMessageResourceName = nameof(ModelValidations.Validation_MaxLength), ErrorMessageResourceType = typeof(ModelValidations))]
    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Plan), ResourceType = typeof(DisplayNames))]
    public string? Name { get; set; }

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Price), ResourceType = typeof(DisplayNames))]
    public decimal Price { get; set; }

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Months), ResourceType = typeof(DisplayNames))]
    public int Meses { get; set; }

    [Required(ErrorMessageResourceName = nameof(ModelValidations.Validation_Required), ErrorMessageResourceType = typeof(ModelValidations))]
    [Display(Name = nameof(DisplayNames.Max_Clients), ResourceType = typeof(DisplayNames))]
    public int ClientsCount { get; set; }

    [Display(Name = nameof(DisplayNames.Active), ResourceType = typeof(DisplayNames))]
    public bool Active { get; set; }

    //Releaciones
    public ICollection<Corporation>? Corporations { get; set; }
}