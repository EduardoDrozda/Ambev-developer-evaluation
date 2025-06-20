using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProducts;

public class GetProductsHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<GetProductsCommand, List<GetProductsResult>>
{
    public async Task<List<GetProductsResult>> Handle(GetProductsCommand request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetAllAsync();
        return mapper.Map<List<GetProductsResult>>(products);
    }
}