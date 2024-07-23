using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Account Tag
/// </summary>
public partial class AccountAccountTag
{
    public int Id { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Tag Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Applicability
    /// </summary>
    public string Applicability { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Negate Tax Balance
    /// </summary>
    public bool? TaxNegate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; set; } = new List<AccountAccountTemplate>();

    public virtual ICollection<AccountAccount> AccountAccounts { get; set; } = new List<AccountAccount>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplates { get; set; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLines { get; set; } = new List<AccountTaxRepartitionLine>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();
}
