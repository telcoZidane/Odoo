using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Point of Sale Orders
/// </summary>
public partial class PosOrder
{
    public int Id { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Pricelist
    /// </summary>
    public int PricelistId { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Sequence Number
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Session
    /// </summary>
    public int SessionId { get; set; }

    /// <summary>
    /// Invoice
    /// </summary>
    public int? AccountMove { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? ProcurementGroupId { get; set; }

    /// <summary>
    /// Number of Print
    /// </summary>
    public int? NbPrint { get; set; }

    /// <summary>
    /// Sales Journal
    /// </summary>
    public int? SaleJournal { get; set; }

    /// <summary>
    /// Fiscal Position
    /// </summary>
    public int? FiscalPositionId { get; set; }

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
    /// Order Ref
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Receipt Number
    /// </summary>
    public string? PosReference { get; set; }

    /// <summary>
    /// Internal Notes
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Taxes
    /// </summary>
    public decimal AmountTax { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public decimal AmountTotal { get; set; }

    /// <summary>
    /// Paid
    /// </summary>
    public decimal AmountPaid { get; set; }

    /// <summary>
    /// Returned
    /// </summary>
    public decimal AmountReturn { get; set; }

    /// <summary>
    /// Currency Rate
    /// </summary>
    public decimal? CurrencyRate { get; set; }

    /// <summary>
    /// Tip Amount
    /// </summary>
    public decimal? TipAmount { get; set; }

    /// <summary>
    /// To invoice
    /// </summary>
    public bool? ToInvoice { get; set; }

    /// <summary>
    /// To ship
    /// </summary>
    public bool? ToShip { get; set; }

    /// <summary>
    /// Is this already tipped?
    /// </summary>
    public bool? IsTipped { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime? DateOrder { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int? EmployeeId { get; set; }

    /// <summary>
    /// Cashier
    /// </summary>
    public string? Cashier { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? CrmTeamId { get; set; }

    public virtual AccountMove? AccountMoveNavigation { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? CrmTeam { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ICollection<PosOrderLine> PosOrderLines { get; set; } = new List<PosOrderLine>();

    public virtual ICollection<PosPayment> PosPayments { get; set; } = new List<PosPayment>();

    public virtual ProductPricelist Pricelist { get; set; } = null!;

    public virtual ProcurementGroup? ProcurementGroup { get; set; }

    public virtual ICollection<ProcurementGroup> ProcurementGroups { get; set; } = new List<ProcurementGroup>();

    public virtual AccountJournal? SaleJournalNavigation { get; set; }

    public virtual PosSession Session { get; set; } = null!;

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
