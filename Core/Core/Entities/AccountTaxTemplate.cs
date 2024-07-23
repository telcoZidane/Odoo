using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Templates for Taxes
/// </summary>
public partial class AccountTaxTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Chart Template
    /// </summary>
    public int ChartTemplateId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Tax Group
    /// </summary>
    public int? TaxGroupId { get; set; }

    /// <summary>
    /// Cash Basis Transition Account
    /// </summary>
    public int? CashBasisTransitionAccountId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Tax Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Tax Type
    /// </summary>
    public string TypeTaxUse { get; set; } = null!;

    /// <summary>
    /// Tax Scope
    /// </summary>
    public string? TaxScope { get; set; }

    /// <summary>
    /// Tax Computation
    /// </summary>
    public string AmountType { get; set; } = null!;

    /// <summary>
    /// Display on Invoices
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Tax Due
    /// </summary>
    public string? TaxExigibility { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Included in Price
    /// </summary>
    public bool? PriceInclude { get; set; }

    /// <summary>
    /// Affect Subsequent Taxes
    /// </summary>
    public bool? IncludeBaseAmount { get; set; }

    /// <summary>
    /// Base Affected by Previous Taxes
    /// </summary>
    public bool? IsBaseAffected { get; set; }

    /// <summary>
    /// Analytic Cost
    /// </summary>
    public bool? Analytic { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateTaxDests { get; set; } = new List<AccountFiscalPositionTaxTemplate>();

    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateTaxSrcs { get; set; } = new List<AccountFiscalPositionTaxTemplate>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateInvoiceTaxes { get; set; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateRefundTaxes { get; set; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual AccountAccountTemplate? CashBasisTransitionAccount { get; set; }

    public virtual AccountChartTemplate ChartTemplate { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountTaxGroup? TaxGroup { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplates { get; set; } = new List<AccountReconcileModelLineTemplate>();

    public virtual ICollection<AccountAccountTemplate> Accounts { get; set; } = new List<AccountAccountTemplate>();

    public virtual ICollection<AccountTaxTemplate> ChildTaxes { get; set; } = new List<AccountTaxTemplate>();

    public virtual ICollection<AccountTaxTemplate> ParentTaxes { get; set; } = new List<AccountTaxTemplate>();
}
