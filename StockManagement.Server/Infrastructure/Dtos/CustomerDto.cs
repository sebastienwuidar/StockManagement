namespace StockManagement.Server.Infrastructure.DTOs;

public record CustomerDto(int Id, string Name, AddressDto Address);