using System;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a single item within a sale.
/// </summary>
public class SaleItem: BaseEntity
{
    /// <summary>
    /// Reference to the parent sale.
    /// </summary>
    public Guid SaleId { get; set; }

    /// <summary>
    /// Reference to the product being sold.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Quantity of the product sold.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Unit price at the time of sale.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Discount applied to the item.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Total price for this item (after discount).
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Indicates if the item was canceled.
    /// </summary>
    public bool IsCanceled { get; set; }
    
    /// <summary>
    /// Timestamp for concurrency control.
    /// </summary>
    public byte[]? RowVersion { get; set; }
    
    public Sale? Sale { get; set; }
    public Product? Product { get; set; }
}