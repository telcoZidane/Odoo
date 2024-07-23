using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tax Repartition Line Template
/// </summary>
public partial class AccountTaxRepartitionLineTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Account
    /// </summary>
    public int? AccountId { get; set; }

    /// <summary>
    /// Invoice Tax
    /// </summary>
    public int? InvoiceTaxId { get; set; }

    /// <summary>
    /// Refund Tax
    /// </summary>
    public int? RefundTaxId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Based On
    /// </summary>
    public string RepartitionType { get; set; } = null!;

    /// <summary>
    /// Tax Closing Entry
    /// </summary>
    public bool? UseInTaxClosing { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// %
    /// </summary>
    public double FactorPercent { get; set; }

    public virtual AccountAccountTemplate? Account { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountTaxTemplate? InvoiceTax { get; set; }

    public virtual AccountTaxTemplate? RefundTax { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccountTag> AccountAccountTags { get; set; } = new List<AccountAccountTag>();

    public virtual ICollection<AccountReportExpression> AccountReportExpressions { get; set; } = new List<AccountReportExpression>();

    public virtual ICollection<AccountReportExpression> AccountReportExpressionsNavigation { get; set; } = new List<AccountReportExpression>();
}
