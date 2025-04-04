namespace StockManagement.Server.Infrastructure.DTOs;

public record ProductDto(int Id, string Name, int Quantity, double Price, CompanyDto Company);