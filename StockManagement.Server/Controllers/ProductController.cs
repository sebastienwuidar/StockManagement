using Microsoft.AspNetCore.Mvc;
using StockManagement.Server.Infrastructure.DTOs;
using StockManagement.Server.Infrastructure.Repositories;
using StockManagement.Server.Models;
using StockManagement.Server.Models.Requests;

namespace StockManagement.Server.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : Controller
{
    private readonly ProductRepository _productRepository;
    private readonly CompanyRepository _companyRepository;

    public ProductController(ProductRepository productRepository, CompanyRepository companyRepository)
    {
        _productRepository = productRepository;
        _companyRepository = companyRepository;
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

    [HttpPost]
    public IActionResult Create([FromBody] ProductRequest request)
    {
        var company = _companyRepository.GetCompanyById(request.CompanyId);

        if (company == null)
        {
            return NotFound();
        }
        
        return _productRepository.AddProduct(request, company) ? Ok() : BadRequest();
    }

    // public IActionResult Update([FromBody] ProductDto productDto)
    // {
    // }
    //
    // public IActionResult Delete([FromRoute] int id)
    // {
    // }
}