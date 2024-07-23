using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Journal Item
/// </summary>
public partial class AccountMoveLine
{
    public int Id { get; set; }

    /// <summary>
    /// Journal Entry
    /// </summary>
    public int MoveId { get; set; }

    /// <summary>
    /// Journal
    /// </summary>
    public int? JournalId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Company Currency
    /// </summary>
    public int? CompanyCurrencyId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Account
    /// </summary>
    public int? AccountId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Reconciliation Model
    /// </summary>
    public int? ReconcileModelId { get; set; }

    /// <summary>
    /// Originator Payment
    /// </summary>
    public int? PaymentId { get; set; }

    /// <summary>
    /// Originator Statement Line
    /// </summary>
    public int? StatementLineId { get; set; }

    /// <summary>
    /// Statement
    /// </summary>
    public int? StatementId { get; set; }

    /// <summary>
    /// Originator Group of Taxes
    /// </summary>
    public int? GroupTaxId { get; set; }

    /// <summary>
    /// Originator Tax
    /// </summary>
    public int? TaxLineId { get; set; }

    /// <summary>
    /// Originator tax group
    /// </summary>
    public int? TaxGroupId { get; set; }

    /// <summary>
    /// Originator Tax Distribution Line
    /// </summary>
    public int? TaxRepartitionLineId { get; set; }

    /// <summary>
    /// Matching
    /// </summary>
    public int? FullReconcileId { get; set; }

    /// <summary>
    /// Account Root
    /// </summary>
    public int? AccountRootId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int? ProductUomId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Number
    /// </summary>
    public string? MoveName { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? ParentState { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public string? Ref { get; set; }

    /// <summary>
    /// Label
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Tax Audit String
    /// </summary>
    public string? TaxAudit { get; set; }

    /// <summary>
    /// Matching #
    /// </summary>
    public string? MatchingNumber { get; set; }

    /// <summary>
    /// Display Type
    /// </summary>
    public string DisplayType { get; set; } = null!;

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Due Date
    /// </summary>
    public DateOnly? DateMaturity { get; set; }

    /// <summary>
    /// Discount Date
    /// </summary>
    public DateOnly? DiscountDate { get; set; }

    /// <summary>
    /// Analytic
    /// </summary>
    public string? AnalyticDistribution { get; set; }

    /// <summary>
    /// Debit
    /// </summary>
    public decimal? Debit { get; set; }

    /// <summary>
    /// Credit
    /// </summary>
    public decimal? Credit { get; set; }

    /// <summary>
    /// Balance
    /// </summary>
    public decimal? Balance { get; set; }

    /// <summary>
    /// Amount in Currency
    /// </summary>
    public decimal? AmountCurrency { get; set; }

    /// <summary>
    /// Base Amount
    /// </summary>
    public decimal? TaxBaseAmount { get; set; }

    /// <summary>
    /// Residual Amount
    /// </summary>
    public decimal? AmountResidual { get; set; }

    /// <summary>
    /// Residual Amount in Currency
    /// </summary>
    public decimal? AmountResidualCurrency { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public decimal? PriceUnit { get; set; }

    /// <summary>
    /// Subtotal
    /// </summary>
    public decimal? PriceSubtotal { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public decimal? PriceTotal { get; set; }

    /// <summary>
    /// Discount (%)
    /// </summary>
    public decimal? Discount { get; set; }

    /// <summary>
    /// Discount amount in Currency
    /// </summary>
    public decimal? DiscountAmountCurrency { get; set; }

    /// <summary>
    /// Discount Balance
    /// </summary>
    public decimal? DiscountBalance { get; set; }

    /// <summary>
    /// Invert Tags
    /// </summary>
    public bool? TaxTagInvert { get; set; }

    /// <summary>
    /// Reconciled
    /// </summary>
    public bool? Reconciled { get; set; }

    /// <summary>
    /// No Follow-up
    /// </summary>
    public bool? Blocked { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Discount Percentage
    /// </summary>
    public double? DiscountPercentage { get; set; }

    /// <summary>
    /// Is Downpayment
    /// </summary>
    public bool? IsDownpayment { get; set; }

    /// <summary>
    /// Purchase Order Line
    /// </summary>
    public int? PurchaseLineId { get; set; }

    /// <summary>
    /// Expense
    /// </summary>
    public int? ExpenseId { get; set; }

    /// <summary>
    /// Vehicle
    /// </summary>
    public int? VehicleId { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileCreditMoves { get; set; } = new List<AccountPartialReconcile>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileDebitMoves { get; set; } = new List<AccountPartialReconcile>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResCurrency? CompanyCurrency { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual HrExpense? Expense { get; set; }

    public virtual AccountFullReconcile? FullReconcile { get; set; }

    public virtual AccountTax? GroupTax { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountMove Move { get; set; } = null!;

    public virtual ResPartner? Partner { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual PurchaseOrderLine? PurchaseLine { get; set; }

    public virtual AccountReconcileModel? ReconcileModel { get; set; }

    public virtual ICollection<RepairFee> RepairFees { get; set; } = new List<RepairFee>();

    public virtual ICollection<RepairLine> RepairLines { get; set; } = new List<RepairLine>();

    public virtual AccountBankStatement? Statement { get; set; }

    public virtual AccountBankStatementLine? StatementLine { get; set; }

    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; set; } = new List<StockValuationLayer>();

    public virtual AccountTaxGroup? TaxGroup { get; set; }

    public virtual AccountTax? TaxLine { get; set; }

    public virtual AccountTaxRepartitionLine? TaxRepartitionLine { get; set; }

    public virtual FleetVehicle? Vehicle { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccountTag> AccountAccountTags { get; set; } = new List<AccountAccountTag>();

    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizards { get; set; } = new List<AccountAutomaticEntryWizard>();

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();

    public virtual ICollection<SaleOrderLine> OrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<AccountPaymentRegister> Wizards { get; set; } = new List<AccountPaymentRegister>();
}
