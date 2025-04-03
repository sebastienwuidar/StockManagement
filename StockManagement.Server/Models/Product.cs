using System.ComponentModel.DataAnnotations;

namespace StockManagement.Server.Models;

public class Product
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Name { get; set; }
    
    [Required]
    public int Quantity { get; set; }
    
    [Required]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
    
    public IList<Order> Orders { get; set; }
    public Company Company { get; set; }

    public Product(string name, int quantity, double price, Company company)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        Company = company;
        Orders = new List<Order>();
    }
}