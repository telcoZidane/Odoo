using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Repair Order
/// </summary>
public partial class RepairOrder
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Product to Repair
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Product Unit of Measure
    /// </summary>
    public int ProductUom { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Delivery Address
    /// </summary>
    public int? AddressId { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Lot/Serial
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Pricelist
    /// </summary>
    public int? PricelistId { get; set; }

    /// <summary>
    /// Invoicing Address
    /// </summary>
    public int? PartnerInvoiceId { get; set; }

    /// <summary>
    /// Invoice
    /// </summary>
    public int? InvoiceId { get; set; }

    /// <summary>
    /// Inventory Move
    /// </summary>
    public int? MoveId { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Sale Order
    /// </summary>
    public int? SaleOrderId { get; set; }

    /// <summary>
    /// Return
    /// </summary>
    public int? PickingId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Repair Reference
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Repair Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Invoice Method
    /// </summary>
    public string InvoiceMethod { get; set; } = null!;

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Scheduled Date
    /// </summary>
    public DateOnly? ScheduleDate { get; set; }

    /// <summary>
    /// Warranty Expiration
    /// </summary>
    public DateOnly? GuaranteeLimit { get; set; }

    /// <summary>
    /// Internal Notes
    /// </summary>
    public string? InternalNotes { get; set; }

    /// <summary>
    /// Quotation Notes
    /// </summary>
    public string? QuotationNotes { get; set; }

    /// <summary>
    /// Product Quantity
    /// </summary>
    public decimal ProductQty { get; set; }

    /// <summary>
    /// Invoiced
    /// </summary>
    public bool? Invoiced { get; set; }

    /// <summary>
    /// Repaired
    /// </summary>
    public bool? Repaired { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Untaxed Amount
    /// </summary>
    public double? AmountUntaxed { get; set; }

    /// <summary>
    /// Taxes
    /// </summary>
    public double? AmountTax { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public double? AmountTotal { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMove? Invoice { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockLot? Lot { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartner? PartnerInvoice { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ProductPricelist? Pricelist { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual UomUom ProductUomNavigation { get; set; } = null!;

    public virtual ICollection<RepairFee> RepairFees { get; set; } = new List<RepairFee>();

    public virtual ICollection<RepairLine> RepairLines { get; set; } = new List<RepairLine>();

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairs { get; set; } = new List<StockWarnInsufficientQtyRepair>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<RepairTag> RepairTags { get; set; } = new List<RepairTag>();
}
