using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class BranchRepository(DefaultContext context): IBranchRepository
{
    public async Task<List<Branch>> GetAllAsync()
    {
        return await context
            .Branches
            .AsQueryable()
            .ToListAsync();
    }
}