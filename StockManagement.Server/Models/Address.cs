using System.ComponentModel.DataAnnotations;

namespace StockManagement.Server.Models;

public class Address
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Street { get; set; }
    
    [Required]
    public int Number { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string City { get; set; }
    
    [Required]
    [DataType(DataType.PostalCode)]
    public int PostalCode { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Country { get; set; }

    public Address()
    {
    }

    public Address(string street, int number, string city, int postalCode, string country)
    {
        Street = street;
        Number = number;
        City = city;
        PostalCode = postalCode;
        Country = country;
    }
}