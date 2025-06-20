using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products;

public class GetProductsHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<GetProductsCommand, List<GetProductsResult>>
{
    public async Task<List<GetProductsResult>> Handle(GetProductsCommand request, CancellationToken cancellationToken)
    {
        var result = new List<GetProductsResult>();
        
        var products = await productRepository.GetAllAsync();
        
        foreach (var product in products)
        {
            var productResult = mapper.Map<GetProductsResult>(product);
            result.Add(productResult);
        }
        
        return result;
    }
}