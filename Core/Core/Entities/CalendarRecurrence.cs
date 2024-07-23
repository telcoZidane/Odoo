using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Recurrence Rule
/// </summary>
public partial class CalendarRecurrence
{
    public int Id { get; set; }

    /// <summary>
    /// Base Event
    /// </summary>
    public int? BaseEventId { get; set; }

    /// <summary>
    /// Interval
    /// </summary>
    public int? Interval { get; set; }

    /// <summary>
    /// Count
    /// </summary>
    public int? Count { get; set; }

    /// <summary>
    /// Day
    /// </summary>
    public int? Day { get; set; }

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
    public string? Name { get; set; }

    /// <summary>
    /// Timezone
    /// </summary>
    public string? EventTz { get; set; }

    /// <summary>
    /// Rrule
    /// </summary>
    public string? Rrule { get; set; }

    /// <summary>
    /// Rrule Type
    /// </summary>
    public string? RruleType { get; set; }

    /// <summary>
    /// End Type
    /// </summary>
    public string? EndType { get; set; }

    /// <summary>
    /// Month By
    /// </summary>
    public string? MonthBy { get; set; }

    /// <summary>
    /// Weekday
    /// </summary>
    public string? Weekday { get; set; }

    /// <summary>
    /// By day
    /// </summary>
    public string? Byday { get; set; }

    /// <summary>
    /// Repeat Until
    /// </summary>
    public DateOnly? Until { get; set; }

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
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual CalendarEvent? BaseEvent { get; set; }

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
