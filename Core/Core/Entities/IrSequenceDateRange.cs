using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sequence Date Range
/// </summary>
public partial class IrSequenceDateRange
{
    public int Id { get; set; }

    /// <summary>
    /// Main Sequence
    /// </summary>
    public int SequenceId { get; set; }

    /// <summary>
    /// Next Number
    /// </summary>
    public int NumberNext { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// From
    /// </summary>
    public DateOnly DateFrom { get; set; }

    /// <summary>
    /// To
    /// </summary>
    public DateOnly DateTo { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrSequence Sequence { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
