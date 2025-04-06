using StockManagement.Server.Data;
using StockManagement.Server.Infrastructure.DTOs;
using StockManagement.Server.Models;
using StockManagement.Server.Models.Requests;

namespace StockManagement.Server.Infrastructure.Repositories;

public class ProductRepository
{
    private readonly ILogger<ProductRepository> _logger;
    private readonly ApplicationDbContext _context;

    public ProductRepository(ILogger<ProductRepository> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public ProductDto? GetProductById(int productId)
    {
        var product = _context.Products.Find(productId);

        return product == null ? null : Mapper.ConvertProduct(product);
    }

    public IList<ProductDto> GetProducts()
    {
        var products = _context.Products.ToList();
        
        return products.Select(Mapper.ConvertProduct).ToList();
    }

    public bool AddProduct(ProductRequest request, Company company)
    {
        var product = new Product(request.Name, request.Quantity, request.Price, company);
        _context.Products.Add(product);
        _context.SaveChanges();
        return true;
    }
}