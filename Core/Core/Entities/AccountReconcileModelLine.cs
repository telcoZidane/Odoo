using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Rules for the reconciliation model
/// </summary>
public partial class AccountReconcileModelLine
{
    public int Id { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int? ModelId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Account
    /// </summary>
    public int AccountId { get; set; }

    /// <summary>
    /// Journal
    /// </summary>
    public int? JournalId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Journal Item Label
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// Amount Type
    /// </summary>
    public string AmountType { get; set; } = null!;

    /// <summary>
    /// Amount
    /// </summary>
    public string AmountString { get; set; } = null!;

    /// <summary>
    /// Analytic
    /// </summary>
    public string? AnalyticDistribution { get; set; }

    /// <summary>
    /// Tax Included in Price
    /// </summary>
    public bool? ForceTaxIncluded { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Float Amount
    /// </summary>
    public double? Amount { get; set; }

    public virtual AccountAccount Account { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountReconcileModel? Model { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();
}
