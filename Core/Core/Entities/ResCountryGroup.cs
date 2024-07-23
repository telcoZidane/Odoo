using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Country Group
/// </summary>
public partial class ResCountryGroup
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

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

    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; set; } = new List<AccountFiscalPositionTemplate>();

    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; set; } = new List<AccountFiscalPosition>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductPricelist> Pricelists { get; set; } = new List<ProductPricelist>();

    public virtual ICollection<ResCountry> ResCountries { get; set; } = new List<ResCountry>();
}
