using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a customer sale.
/// </summary>
public class Sale: BaseEntity
{
    /// <summary>
    /// Unique number identifying the sale.
    /// </summary>
    public int SaleNumber { get; set; }

    /// <summary>
    /// The date when the sale was made.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// The customer associated with the sale.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The ID of the branch where the sale occurred.
    /// </summary>
    public Guid BranchId { get; set; }

    /// <summary>
    /// The total monetary amount of the sale.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Indicates if the sale has been canceled.
    /// </summary>
    public bool IsCanceled { get; set; }

    /// <summary>
    /// Timestamp for concurrency control.
    /// </summary>
    public byte[]? RowVersion { get; set; }

    /// <summary>
    /// The items included in the sale.
    /// </summary>
    public ICollection<SaleItem> Items { get; set; } = new List<SaleItem>();
}