using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Stage
/// </summary>
public partial class EventStage
{
    public int Id { get; set; }

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
    /// Stage Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Stage description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Red Kanban Label
    /// </summary>
    public string LegendBlocked { get; set; } = null!;

    /// <summary>
    /// Green Kanban Label
    /// </summary>
    public string LegendDone { get; set; } = null!;

    /// <summary>
    /// Grey Kanban Label
    /// </summary>
    public string LegendNormal { get; set; } = null!;

    /// <summary>
    /// Folded in Kanban
    /// </summary>
    public bool? Fold { get; set; }

    /// <summary>
    /// End Stage
    /// </summary>
    public bool? PipeEnd { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<EventEvent> EventEvents { get; set; } = new List<EventEvent>();

    public virtual ResUser? WriteU { get; set; }
}
