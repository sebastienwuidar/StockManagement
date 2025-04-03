using System.ComponentModel.DataAnnotations;

namespace StockManagement.Server.Models;

public class Company
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Name { get; set; }

    public Company(string name)
    {
        Name = name;
    }
}