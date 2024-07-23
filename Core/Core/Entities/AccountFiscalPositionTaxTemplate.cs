using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tax Mapping Template of Fiscal Position
/// </summary>
public partial class AccountFiscalPositionTaxTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Fiscal Position
    /// </summary>
    public int PositionId { get; set; }

    /// <summary>
    /// Tax Source
    /// </summary>
    public int TaxSrcId { get; set; }

    /// <summary>
    /// Replacement Tax
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

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPositionTemplate Position { get; set; } = null!;

    public virtual AccountTaxTemplate? TaxDest { get; set; }

    public virtual AccountTaxTemplate TaxSrc { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
