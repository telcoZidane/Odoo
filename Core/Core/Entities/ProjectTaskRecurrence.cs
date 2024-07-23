using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Task Recurrence
/// </summary>
public partial class ProjectTaskRecurrence
{
    public int Id { get; set; }

    /// <summary>
    /// Number of Tasks Left to Create
    /// </summary>
    public int? RecurrenceLeft { get; set; }

    /// <summary>
    /// Repeat Every
    /// </summary>
    public int? RepeatInterval { get; set; }

    /// <summary>
    /// Repetitions
    /// </summary>
    public int? RepeatNumber { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Repeat Unit
    /// </summary>
    public string? RepeatUnit { get; set; }

    /// <summary>
    /// Until
    /// </summary>
    public string? RepeatType { get; set; }

    /// <summary>
    /// Repeat On Month
    /// </summary>
    public string? RepeatOnMonth { get; set; }

    /// <summary>
    /// Repeat On Year
    /// </summary>
    public string? RepeatOnYear { get; set; }

    /// <summary>
    /// Repeat Day
    /// </summary>
    public string? RepeatDay { get; set; }

    /// <summary>
    /// Repeat Week
    /// </summary>
    public string? RepeatWeek { get; set; }

    /// <summary>
    /// Day Of The Week
    /// </summary>
    public string? RepeatWeekday { get; set; }

    /// <summary>
    /// Repeat Month
    /// </summary>
    public string? RepeatMonth { get; set; }

    /// <summary>
    /// Next Recurrence Date
    /// </summary>
    public DateOnly? NextRecurrenceDate { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? RepeatUntil { get; set; }

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

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual ResUser? WriteU { get; set; }
}
