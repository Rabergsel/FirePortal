using System.ComponentModel.DataAnnotations;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Models.Forms;

public class WebsiteAdminDataModel
{
    [Required(ErrorMessage = "You need a domain")]
    [RegularExpression(@"([a-z0-9|-]+\.)*[a-z0-9|-]+\.[a-z]+", ErrorMessage = "You need to enter a valid domain")]
    public string BaseDomain { get; set; } = "";
    
    [Required(ErrorMessage = "You need to specify a owner")]
    public User User { get; set; }
}