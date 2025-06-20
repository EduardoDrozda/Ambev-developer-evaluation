using Ambev.DeveloperEvaluation.Application.Products;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products;

public class GetProductsProfile: Profile
{
    public GetProductsProfile()
    {
        CreateMap<GetProductsResult, GetProductsResponse>().ReverseMap();
    }
}