using System.ComponentModel.DataAnnotations;
using FirePortal.App.Database.Entities;
using FirePortal.App.Models.Misc;

namespace FirePortal.App.Models.Forms;

public class UserEditDataModel
{
    [Required]
    public string FirstName { get; set; } = "";
    
    [Required]
    public string LastName { get; set; } = "";
    
    [Required]
    public string Email { get; set; } = "";
    
    [Required]
    public string Address { get; set; } = "";
    
    [Required]
    public string City { get; set; } = "";
    
    [Required]
    public string State { get; set; } = "";
    
    [Required]
    public string Country { get; set; } = "";

    public bool Admin { get; set; }
    public bool TotpEnabled { get; set; }
    public ulong DiscordId { get; set; }
    public PermissionGroup? PermissionGroup { get; set; }
}