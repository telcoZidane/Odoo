using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Expense
/// </summary>
public partial class HrExpense
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Category
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int? ProductUomId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Account
    /// </summary>
    public int? AccountId { get; set; }

    /// <summary>
    /// Expense Report
    /// </summary>
    public int? SheetId { get; set; }

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
    /// Paid By
    /// </summary>
    public string? PaymentMode { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Bill Reference
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// Expense Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Accounting Date
    /// </summary>
    public DateOnly? AccountingDate { get; set; }

    /// <summary>
    /// Analytic
    /// </summary>
    public string? AnalyticDistribution { get; set; }

    /// <summary>
    /// Internal Notes
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public decimal UnitAmount { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Tax amount in Currency
    /// </summary>
    public decimal? AmountTax { get; set; }

    /// <summary>
    /// Tax amount
    /// </summary>
    public decimal? AmountTaxCompany { get; set; }

    /// <summary>
    /// Total In Currency
    /// </summary>
    public decimal? TotalAmount { get; set; }

    /// <summary>
    /// Total Untaxed Amount In Currency
    /// </summary>
    public decimal? UntaxedAmount { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public decimal? TotalAmountCompany { get; set; }

    /// <summary>
    /// Explicitly Refused by manager or accountant
    /// </summary>
    public bool? IsRefused { get; set; }

    /// <summary>
    /// Sample
    /// </summary>
    public bool? Sample { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Customer to Reinvoice
    /// </summary>
    public int? SaleOrderId { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual ICollection<HrExpenseSplitWizard> HrExpenseSplitWizards { get; set; } = new List<HrExpenseSplitWizard>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; set; } = new List<HrExpenseSplit>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual HrExpenseSheet? Sheet { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicates { get; set; } = new List<HrExpenseApproveDuplicate>();

    public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizards { get; set; } = new List<HrExpenseRefuseWizard>();

    public virtual ICollection<AccountTax> Taxes { get; set; } = new List<AccountTax>();
}
