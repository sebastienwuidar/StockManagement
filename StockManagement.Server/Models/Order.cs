using System.ComponentModel.DataAnnotations;

namespace StockManagement.Server.Models;

public class Order
{
    public int Id { get; set; }
    
    [Required]
    public Enum Status { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Name { get; set; }
    
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
    
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }

    public IList<Product> Products { get; set; }
    public Customer Customer { get; set; }
    
    public Order(string name, Customer customer)
    {
        Name = name;
        Customer = customer;
        Status = StatusEnum.Pending;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
        Products = new List<Product>();
    }
}