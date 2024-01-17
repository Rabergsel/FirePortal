using System.ComponentModel.DataAnnotations;

namespace FirePortal.App.Models.Forms;

public class ServerRenameDataModel
{
    [Required(ErrorMessage = "You need to enter a name")]
    [MaxLength(32, ErrorMessage = "The name cannot be longer that 32 characters")]
    public string Name { get; set; }
}