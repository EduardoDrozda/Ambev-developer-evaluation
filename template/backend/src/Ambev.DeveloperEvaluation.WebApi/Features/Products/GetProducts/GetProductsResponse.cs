﻿namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts;

public class GetProductsResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}