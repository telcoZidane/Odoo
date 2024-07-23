using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Expense Split
/// </summary>
public partial class HrExpenseSplit
{
    public int Id { get; set; }

    /// <summary>
    /// Wizard
    /// </summary>
    public int? WizardId { get; set; }

    /// <summary>
    /// Expense
    /// </summary>
    public int? ExpenseId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

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
    /// Analytic
    /// </summary>
    public string? AnalyticDistribution { get; set; }

    /// <summary>
    /// Total In Currency
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Is product with non zero cost selected
    /// </summary>
    public bool? ProductHasCost { get; set; }

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

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual HrExpense? Expense { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual HrExpenseSplitWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();
}
