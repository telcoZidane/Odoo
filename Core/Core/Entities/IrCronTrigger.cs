using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Triggered actions
/// </summary>
public partial class IrCronTrigger
{
    public int Id { get; set; }

    /// <summary>
    /// Cron
    /// </summary>
    public int? CronId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Call At
    /// </summary>
    public DateTime? CallAt { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrCron? Cron { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
