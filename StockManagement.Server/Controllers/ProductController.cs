using Microsoft.AspNetCore.Mvc;
using StockManagement.Server.Infrastructure.DTOs;
using StockManagement.Server.Infrastructure.Repositories;

namespace StockManagement.Server.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : Controller
{
    private readonly ProductRepository _productRepository;

    public ProductController(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    /// <summary>
    /// Get products
    /// </summary>
    /// <returns>A list of product</returns>
    [HttpGet]
    [Produces("application/json")]
    public IList<ProductDto> Index()
    {
        return _productRepository.GetProducts();
    }

    /// <summary>
    /// Get a product
    /// </summary>
    /// <param name="id">id of the product to find</param>
    /// <returns>the product</returns>
    [HttpGet]
    [Produces("application/json")]
    [Route("/{id}")]
    public IActionResult Show([FromRoute] int id)
    {
        var product = _productRepository.GetProductById(id);

        if (product == null)
        {
            return NotFound();
        }
        
        return Ok(product);
    }
}