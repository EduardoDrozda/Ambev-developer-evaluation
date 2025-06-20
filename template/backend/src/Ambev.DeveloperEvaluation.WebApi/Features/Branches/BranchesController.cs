using Ambev.DeveloperEvaluation.Application.Branches.GetBranches;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Branches.GetBranches;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches;

/// <summary>
/// Controller for managing branch operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class BranchesController(IMediator mediator, IMapper mapper) : BaseController
{
    [HttpGet()]
    [ProducesResponseType(typeof(ApiResponseWithData<List<GetBranchesResponse>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProducts(CancellationToken cancellationToken)
    {
        var result = await mediator.Send(new GetBranchesCommand(), cancellationToken);
        var response = mapper.Map<List<GetBranchesResponse>>(result);
        return Ok(response);
    }
}