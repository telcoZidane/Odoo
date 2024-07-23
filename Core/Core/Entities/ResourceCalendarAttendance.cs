using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Work Detail
/// </summary>
public partial class ResourceCalendarAttendance
{
    public int Id { get; set; }

    /// <summary>
    /// Resource&apos;s Calendar
    /// </summary>
    public int CalendarId { get; set; }

    /// <summary>
    /// Resource
    /// </summary>
    public int? ResourceId { get; set; }

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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Day of Week
    /// </summary>
    public string Dayofweek { get; set; } = null!;

    /// <summary>
    /// Day Period
    /// </summary>
    public string DayPeriod { get; set; } = null!;

    /// <summary>
    /// Week Number
    /// </summary>
    public string? WeekType { get; set; }

    /// <summary>
    /// Display Type
    /// </summary>
    public string? DisplayType { get; set; }

    /// <summary>
    /// Starting Date
    /// </summary>
    public DateOnly? DateFrom { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? DateTo { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Work from
    /// </summary>
    public double HourFrom { get; set; }

    /// <summary>
    /// Work to
    /// </summary>
    public double HourTo { get; set; }

    public virtual ResourceCalendar Calendar { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceResource? Resource { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
