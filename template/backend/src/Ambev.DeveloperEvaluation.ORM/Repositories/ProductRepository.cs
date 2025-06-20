using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class ProductRepository(DefaultContext context) : IProductRepository
{
    private readonly DefaultContext _context = context;


    public Task<List<Product>> GetAllAsync()
    {
        return _context
            .Products
            .AsQueryable()
            .ToListAsync();
    }
}