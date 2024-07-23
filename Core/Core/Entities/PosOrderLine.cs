using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Point of Sale Order Lines
/// </summary>
public partial class PosOrderLine
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Order Ref
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// Refunded Order Line
    /// </summary>
    public int? RefundedOrderlineId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Line No
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Discount Notice
    /// </summary>
    public string? Notice { get; set; }

    /// <summary>
    /// Full Product Name
    /// </summary>
    public string? FullProductName { get; set; }

    /// <summary>
    /// Customer Note
    /// </summary>
    public string? CustomerNote { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public decimal? PriceUnit { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// Subtotal w/o Tax
    /// </summary>
    public decimal PriceSubtotal { get; set; }

    /// <summary>
    /// Subtotal
    /// </summary>
    public decimal PriceSubtotalIncl { get; set; }

    /// <summary>
    /// Total cost
    /// </summary>
    public decimal? TotalCost { get; set; }

    /// <summary>
    /// Discount (%)
    /// </summary>
    public decimal? Discount { get; set; }

    /// <summary>
    /// Is Total Cost Computed
    /// </summary>
    public bool? IsTotalCostComputed { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Price extra
    /// </summary>
    public double? PriceExtra { get; set; }

    /// <summary>
    /// Linked Sale Order
    /// </summary>
    public int? SaleOrderOriginId { get; set; }

    /// <summary>
    /// Source Sale Order Line
    /// </summary>
    public int? SaleOrderLineId { get; set; }

    /// <summary>
    /// Down Payment Details
    /// </summary>
    public string? DownPaymentDetails { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PosOrderLine> InverseRefundedOrderline { get; set; } = new List<PosOrderLine>();

    public virtual PosOrder Order { get; set; } = null!;

    public virtual ICollection<PosPackOperationLot> PosPackOperationLots { get; set; } = new List<PosPackOperationLot>();

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual PosOrderLine? RefundedOrderline { get; set; }

    public virtual SaleOrderLine? SaleOrderLine { get; set; }

    public virtual SaleOrder? SaleOrderOrigin { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();
}
