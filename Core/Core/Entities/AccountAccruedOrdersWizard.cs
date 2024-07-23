using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accrued Orders Wizard
/// </summary>
public partial class AccountAccruedOrdersWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Company Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Accrual Account
    /// </summary>
    public int AccountId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Reversal Date
    /// </summary>
    public DateOnly ReversalDate { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual AccountAccount Account { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
