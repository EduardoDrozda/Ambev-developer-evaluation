﻿using Ambev.DeveloperEvaluation.Application.Products;
using Ambev.DeveloperEvaluation.Application.Products.GetProducts;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts;

public class GetProductsProfile: Profile
{
    public GetProductsProfile()
    {
        CreateMap<GetProductsResult, GetProductsResponse>().ReverseMap();
    }
}