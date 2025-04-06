using StockManagement.Server.Data;
using StockManagement.Server.Infrastructure.DTOs;
using StockManagement.Server.Models;
using StockManagement.Server.Models.Requests;

namespace StockManagement.Server.Infrastructure.Repositories;

public class CompanyRepository
{
    private readonly ILogger<CompanyRepository> _logger;
    private readonly ApplicationDbContext _context;

    public CompanyRepository(ILogger<CompanyRepository> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public CompanyDto? GetCompanyDtoById(int companyId)
    {
        var company = _context.Companies.Find(companyId);

        return company == null ? null : Mapper.ConvertCompany(company);
    }
    
    public Company? GetCompanyById(int companyId)
    {
        return _context.Companies.Find(companyId);
    }
}