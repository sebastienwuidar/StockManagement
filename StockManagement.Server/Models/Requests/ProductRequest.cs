namespace StockManagement.Server.Models.Requests;

public record ProductRequest(
    string Name, 
    int Quantity,
    double Price,
    int CompanyId
);