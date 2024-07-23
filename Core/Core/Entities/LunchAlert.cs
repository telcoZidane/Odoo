using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Lunch Alert
/// </summary>
public partial class LunchAlert
{
    public int Id { get; set; }

    /// <summary>
    /// Cron
    /// </summary>
    public int CronId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Display
    /// </summary>
    public string? Mode { get; set; }

    /// <summary>
    /// Recipients
    /// </summary>
    public string? Recipients { get; set; }

    /// <summary>
    /// Notification Moment
    /// </summary>
    public string NotificationMoment { get; set; } = null!;

    /// <summary>
    /// Timezone
    /// </summary>
    public string Tz { get; set; } = null!;

    /// <summary>
    /// Show Until
    /// </summary>
    public DateOnly? Until { get; set; }

    /// <summary>
    /// Alert Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Message
    /// </summary>
    public string Message { get; set; } = null!;

    /// <summary>
    /// Mon
    /// </summary>
    public bool? Mon { get; set; }

    /// <summary>
    /// Tue
    /// </summary>
    public bool? Tue { get; set; }

    /// <summary>
    /// Wed
    /// </summary>
    public bool? Wed { get; set; }

    /// <summary>
    /// Thu
    /// </summary>
    public bool? Thu { get; set; }

    /// <summary>
    /// Fri
    /// </summary>
    public bool? Fri { get; set; }

    /// <summary>
    /// Sat
    /// </summary>
    public bool? Sat { get; set; }

    /// <summary>
    /// Sun
    /// </summary>
    public bool? Sun { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Notification Time
    /// </summary>
    public double? NotificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrCron Cron { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<LunchLocation> LunchLocations { get; set; } = new List<LunchLocation>();
}
