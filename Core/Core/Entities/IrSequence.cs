using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sequence
/// </summary>
public partial class IrSequence
{
    public int Id { get; set; }

    /// <summary>
    /// Next Number
    /// </summary>
    public int NumberNext { get; set; }

    /// <summary>
    /// Step
    /// </summary>
    public int NumberIncrement { get; set; }

    /// <summary>
    /// Sequence Size
    /// </summary>
    public int Padding { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

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
    /// Sequence Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Implementation
    /// </summary>
    public string Implementation { get; set; } = null!;

    /// <summary>
    /// Prefix
    /// </summary>
    public string? Prefix { get; set; }

    /// <summary>
    /// Suffix
    /// </summary>
    public string? Suffix { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Use subsequences per date_range
    /// </summary>
    public bool? UseDateRange { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrSequenceDateRange> IrSequenceDateRanges { get; set; } = new List<IrSequenceDateRange>();

    public virtual ICollection<PosConfig> PosConfigSequenceLines { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosConfig> PosConfigSequences { get; set; } = new List<PosConfig>();

    public virtual ICollection<StockPickingType> StockPickingTypes { get; set; } = new List<StockPickingType>();

    public virtual ResUser? WriteU { get; set; }
}
