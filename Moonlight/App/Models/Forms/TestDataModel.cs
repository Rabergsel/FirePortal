using System.ComponentModel.DataAnnotations;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Models.Forms;

public class TestDataModel
{
    [Required]
    public User User { get; set; }
}