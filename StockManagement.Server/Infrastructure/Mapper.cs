using StockManagement.Server.Infrastructure.DTOs;
using StockManagement.Server.Models;

namespace StockManagement.Server.Infrastructure;

public static class Mapper
{
    public static ProductDto ConvertProduct(Product product)
    {
        return new ProductDto(product.Id, product.Name, product.Quantity, product.Price, ConvertCompany(product.Company));
    }

    public static CompanyDto ConvertCompany(Company company)
    {
        return new CompanyDto(company.Id, company.Name);
    }
}