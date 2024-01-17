using System.ComponentModel.DataAnnotations;

namespace FirePortal.App.Models.Forms;

public class NameModel
{
    [Required]
    [MinLength(2, ErrorMessage = "Do you think, that works?")]
    public string FirstName { get; set; }
    
    [Required]
    [MinLength(2, ErrorMessage = "Do you think, that works?")]
    public string LastName { get; set; }
}