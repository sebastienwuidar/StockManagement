using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace StockManagement.Server.Models;

public class User : IdentityUser
{
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string FirstName { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string LastName { get; set; }
    
    public Company Company { get; set; }
}