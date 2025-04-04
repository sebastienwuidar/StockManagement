namespace StockManagement.Server.Infrastructure.DTOs;

public record AddressDto(int Id, string Street, int Number, string City, int PostalCode, string Country);