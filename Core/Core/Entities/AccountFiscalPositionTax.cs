using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tax Mapping of Fiscal Position
/// </summary>
public partial class AccountFiscalPositionTax
{
    public int Id { get; set; }

    /// <summary>
    /// Fiscal Position
    /// </summary>
    public int PositionId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Tax on Product
    /// </summary>
    public int TaxSrcId { get; set; }

    /// <summary>
    /// Tax to Apply
    /// </summary>
    public int? TaxDestId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition Position { get; set; } = null!;

    public virtual AccountTax? TaxDest { get; set; }

    public virtual AccountTax TaxSrc { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
