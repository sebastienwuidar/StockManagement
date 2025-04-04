namespace StockManagement.Server.Infrastructure.DTOs;

public record OrderDto(int Id, string Status, string Name, DateTime CreatedAt, DateTime UpdatedAt, CustomerDto Customer, IList<ProductDto> Products);