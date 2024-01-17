using System.ComponentModel.DataAnnotations;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Models.Forms;

public class ServerOverviewDataModel
{
    [Required(ErrorMessage = "You need to enter a name")]
    [MaxLength(32, ErrorMessage = "The name cannot be longer that 32 characters")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "You need to specify a owner")]
    public User Owner { get; set; }
}