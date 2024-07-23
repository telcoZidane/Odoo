using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Workcenter Productivity Losses
/// </summary>
public partial class MrpWorkcenterProductivityLoss
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Category
    /// </summary>
    public int? LossId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Blocking Reason
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Effectiveness Category
    /// </summary>
    public string? LossType { get; set; }

    /// <summary>
    /// Is a Blocking Reason
    /// </summary>
    public bool? Manual { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpWorkcenterProductivityLossType? Loss { get; set; }

    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; set; } = new List<MrpWorkcenterProductivity>();

    public virtual ResUser? WriteU { get; set; }
}
