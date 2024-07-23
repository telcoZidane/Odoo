using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock Valuation Layer
/// </summary>
public partial class StockValuationLayer
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Linked To
    /// </summary>
    public int? StockValuationLayerId { get; set; }

    /// <summary>
    /// Stock Move
    /// </summary>
    public int? StockMoveId { get; set; }

    /// <summary>
    /// Journal Entry
    /// </summary>
    public int? AccountMoveId { get; set; }

    /// <summary>
    /// Invoice Line
    /// </summary>
    public int? AccountMoveLineId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Unit Value
    /// </summary>
    public decimal? UnitCost { get; set; }

    /// <summary>
    /// Total Value
    /// </summary>
    public decimal? Value { get; set; }

    /// <summary>
    /// Remaining Qty
    /// </summary>
    public decimal? RemainingQty { get; set; }

    /// <summary>
    /// Remaining Value
    /// </summary>
    public decimal? RemainingValue { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Invoice value correction with invoice currency
    /// </summary>
    public double? PriceDiffValue { get; set; }

    public virtual AccountMove? AccountMove { get; set; }

    public virtual AccountMoveLine? AccountMoveLine { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockValuationLayer> InverseStockValuationLayerNavigation { get; set; } = new List<StockValuationLayer>();

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual StockMove? StockMove { get; set; }

    public virtual StockValuationLayer? StockValuationLayerNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
