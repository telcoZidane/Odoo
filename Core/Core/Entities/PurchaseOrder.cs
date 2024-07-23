using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Purchase Order
/// </summary>
public partial class PurchaseOrder
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Vendor
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Dropship Address
    /// </summary>
    public int? DestAddressId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Bill Count
    /// </summary>
    public int? InvoiceCount { get; set; }

    /// <summary>
    /// Fiscal Position
    /// </summary>
    public int? FiscalPositionId { get; set; }

    /// <summary>
    /// Payment Terms
    /// </summary>
    public int? PaymentTermId { get; set; }

    /// <summary>
    /// Incoterm
    /// </summary>
    public int? IncotermId { get; set; }

    /// <summary>
    /// Buyer
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Security Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Order Reference
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Source Document
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// Vendor Reference
    /// </summary>
    public string? PartnerRef { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Billing Status
    /// </summary>
    public string? InvoiceStatus { get; set; }

    /// <summary>
    /// Terms and Conditions
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Untaxed Amount
    /// </summary>
    public decimal? AmountUntaxed { get; set; }

    /// <summary>
    /// Taxes
    /// </summary>
    public decimal? AmountTax { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public decimal? AmountTotal { get; set; }

    /// <summary>
    /// Reminder Confirmed
    /// </summary>
    public bool? MailReminderConfirmed { get; set; }

    /// <summary>
    /// Reception Confirmed
    /// </summary>
    public bool? MailReceptionConfirmed { get; set; }

    /// <summary>
    /// Order Deadline
    /// </summary>
    public DateTime DateOrder { get; set; }

    /// <summary>
    /// Confirmation Date
    /// </summary>
    public DateTime? DateApprove { get; set; }

    /// <summary>
    /// Expected Arrival
    /// </summary>
    public DateTime? DatePlanned { get; set; }

    /// <summary>
    /// Date Calendar Start
    /// </summary>
    public DateTime? DateCalendarStart { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Currency Rate
    /// </summary>
    public double? CurrencyRate { get; set; }

    /// <summary>
    /// Deliver To
    /// </summary>
    public int PickingTypeId { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Incoterm Location
    /// </summary>
    public string? IncotermLocation { get; set; }

    /// <summary>
    /// Receipt Status
    /// </summary>
    public string? ReceiptStatus { get; set; }

    /// <summary>
    /// Arrival
    /// </summary>
    public DateTime? EffectiveDate { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual ResPartner? DestAddress { get; set; }

    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual AccountIncoterm? Incoterm { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual AccountPaymentTerm? PaymentTerm { get; set; }

    public virtual StockPickingType PickingType { get; set; } = null!;

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();
}
