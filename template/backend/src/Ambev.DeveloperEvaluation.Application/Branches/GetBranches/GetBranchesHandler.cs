using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branches.GetBranches;

public class GetBranchesHandler(IBranchRepository branchRepository, IMapper mapper)
    : IRequestHandler<GetBranchesCommand, List<GetBranchesResult>>
{
    public async Task<List<GetBranchesResult>> Handle(GetBranchesCommand request, CancellationToken cancellationToken)
    {
        var branches = await branchRepository.GetAllAsync();
        return mapper.Map<List<GetBranchesResult>>(branches);
    }
}