using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tax Group
/// </summary>
public partial class AccountTaxGroup
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

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
    /// Preceding Subtotal
    /// </summary>
    public string? PrecedingSubtotal { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; set; } = new List<AccountTaxTemplate>();

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
