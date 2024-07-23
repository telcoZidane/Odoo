using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Purchase Order Line
/// </summary>
public partial class PurchaseOrderLine
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int? ProductUom { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Order Reference
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Packaging
    /// </summary>
    public int? ProductPackagingId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Received Qty Method
    /// </summary>
    public string? QtyReceivedMethod { get; set; }

    /// <summary>
    /// Display Type
    /// </summary>
    public string? DisplayType { get; set; }

    /// <summary>
    /// Analytic
    /// </summary>
    public string? AnalyticDistribution { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductQty { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public decimal PriceUnit { get; set; }

    /// <summary>
    /// Subtotal
    /// </summary>
    public decimal? PriceSubtotal { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public decimal? PriceTotal { get; set; }

    /// <summary>
    /// Billed Qty
    /// </summary>
    public decimal? QtyInvoiced { get; set; }

    /// <summary>
    /// Received Qty
    /// </summary>
    public decimal? QtyReceived { get; set; }

    /// <summary>
    /// Manual Received Qty
    /// </summary>
    public decimal? QtyReceivedManual { get; set; }

    /// <summary>
    /// To Invoice Quantity
    /// </summary>
    public decimal? QtyToInvoice { get; set; }

    /// <summary>
    /// Expected Arrival
    /// </summary>
    public DateTime? DatePlanned { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Total Quantity
    /// </summary>
    public double? ProductUomQty { get; set; }

    /// <summary>
    /// Tax
    /// </summary>
    public double? PriceTax { get; set; }

    /// <summary>
    /// Packaging Quantity
    /// </summary>
    public double? ProductPackagingQty { get; set; }

    /// <summary>
    /// Orderpoint
    /// </summary>
    public int? OrderpointId { get; set; }

    /// <summary>
    /// Custom Description
    /// </summary>
    public string? ProductDescriptionVariants { get; set; }

    /// <summary>
    /// Propagate cancellation
    /// </summary>
    public bool? PropagateCancel { get; set; }

    /// <summary>
    /// Sale Order
    /// </summary>
    public int? SaleOrderId { get; set; }

    /// <summary>
    /// Origin Sale Item
    /// </summary>
    public int? SaleLineId { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual PurchaseOrder Order { get; set; } = null!;

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductPackaging? ProductPackaging { get; set; }

    public virtual UomUom? ProductUomNavigation { get; set; }

    public virtual SaleOrderLine? SaleLine { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual ICollection<StockMove> StockMoveCreatedPurchaseLines { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMovePurchaseLines { get; set; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();
}
