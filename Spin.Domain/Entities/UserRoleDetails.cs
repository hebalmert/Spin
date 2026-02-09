using Spin.DomainLogic.EnumTypes;
using Spin.xLenguage.Resources;
using System.ComponentModel.DataAnnotations;

namespace Spin.Domain.Entities;

public class UserRoleDetails
{
    [Key]
    public int UserRoleDetailsId { get; set; }

    [Display(Name = nameof(DisplayNames.RoleUser), ResourceType = typeof(DisplayNames))]
    public UserType? UserType { get; set; }

    [Display(Name = nameof(DisplayNames.User), ResourceType = typeof(DisplayNames))]
    public string? UserId { get; set; }

    //Relacion
    public User? User { get; set; }
}