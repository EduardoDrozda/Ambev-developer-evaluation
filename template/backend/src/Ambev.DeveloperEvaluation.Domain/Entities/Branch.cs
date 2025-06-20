using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a sales branch or store location.
/// </summary>
public class Branch: BaseEntity
{
    /// <summary>
    /// The branch name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The full address of the branch.
    /// </summary>
    public string Address { get; set; } = string.Empty;
}