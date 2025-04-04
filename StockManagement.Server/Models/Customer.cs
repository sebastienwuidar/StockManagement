using System.ComponentModel.DataAnnotations;

namespace StockManagement.Server.Models;

public class Customer
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Name { get; set; }
    
    public Address Address { get; set; }

    public Customer()
    {
    }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }
}