using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tax Repartition Line
/// </summary>
public partial class AccountTaxRepartitionLine
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
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

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

    public virtual AccountAccount? Account { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountTax? InvoiceTax { get; set; }

    public virtual AccountTax? RefundTax { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccountTag> AccountAccountTags { get; set; } = new List<AccountAccountTag>();
}
