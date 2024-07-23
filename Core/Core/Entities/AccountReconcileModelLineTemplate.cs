using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Reconcile Model Line Template
/// </summary>
public partial class AccountReconcileModelLineTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int? ModelId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Account
    /// </summary>
    public int? AccountId { get; set; }

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
    public string? AmountString { get; set; }

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

    public virtual AccountAccountTemplate? Account { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountReconcileModelTemplate? Model { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; set; } = new List<AccountTaxTemplate>();
}
