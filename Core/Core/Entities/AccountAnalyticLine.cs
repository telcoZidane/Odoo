using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Analytic Line
/// </summary>
public partial class AccountAnalyticLine
{
    public int Id { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int? ProductUomId { get; set; }

    /// <summary>
    /// Analytic Account
    /// </summary>
    public int AccountId { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Plan
    /// </summary>
    public int? PlanId { get; set; }

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
    public string Name { get; set; } = null!;

    /// <summary>
    /// Category
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public double? UnitAmount { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Financial Account
    /// </summary>
    public int? GeneralAccountId { get; set; }

    /// <summary>
    /// Financial Journal
    /// </summary>
    public int? JournalId { get; set; }

    /// <summary>
    /// Journal Item
    /// </summary>
    public int? MoveLineId { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Ref.
    /// </summary>
    public string? Ref { get; set; }

    /// <summary>
    /// Sales Order Item
    /// </summary>
    public int? SoLine { get; set; }

    public virtual AccountAnalyticAccount Account { get; set; } = null!;

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountAccount? GeneralAccount { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountMoveLine? MoveLine { get; set; }

    public virtual ICollection<MrpWorkorder> MrpWorkorderMoAnalyticAccountLines { get; set; } = new List<MrpWorkorder>();

    public virtual ICollection<MrpWorkorder> MrpWorkorderWcAnalyticAccountLines { get; set; } = new List<MrpWorkorder>();

    public virtual ResPartner? Partner { get; set; }

    public virtual AccountAnalyticPlan? Plan { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual SaleOrderLine? SoLineNavigation { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
