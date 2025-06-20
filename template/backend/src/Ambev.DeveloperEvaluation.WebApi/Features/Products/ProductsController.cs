using Ambev.DeveloperEvaluation.Application.Products;
using Ambev.DeveloperEvaluation.WebApi.Common;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products;

/// <summary>
/// Controller for managing product operations
[ApiController]
[Route("api/[controller]")]
public class ProductsController(IMediator mediator, IMapper mapper) : BaseController
{
    [HttpGet()]
    [ProducesResponseType(typeof(ApiResponseWithData<List<GetProductsResponse>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProducts(CancellationToken cancellationToken)
    {
        var result = await mediator.Send(new GetProductsCommand(), cancellationToken);
        var response = mapper.Map<List<GetProductsResponse>>(result);
        
        return Ok(response);
    }
}