using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Scheduled Actions
/// </summary>
public partial class IrCron
{
    public int Id { get; set; }

    /// <summary>
    /// Server action
    /// </summary>
    public int IrActionsServerId { get; set; }

    /// <summary>
    /// Scheduler User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Interval Number
    /// </summary>
    public int? IntervalNumber { get; set; }

    /// <summary>
    /// Number of Calls
    /// </summary>
    public int? Numbercall { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Interval Unit
    /// </summary>
    public string? IntervalType { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? CronName { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Repeat Missed
    /// </summary>
    public bool? Doall { get; set; }

    /// <summary>
    /// Next Execution Date
    /// </summary>
    public DateTime Nextcall { get; set; }

    /// <summary>
    /// Last Execution Date
    /// </summary>
    public DateTime? Lastcall { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrActServer IrActionsServer { get; set; } = null!;

    public virtual ICollection<IrCronTrigger> IrCronTriggers { get; set; } = new List<IrCronTrigger>();

    public virtual ICollection<LunchAlert> LunchAlerts { get; set; } = new List<LunchAlert>();

    public virtual ICollection<LunchSupplier> LunchSuppliers { get; set; } = new List<LunchSupplier>();

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
