using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Attendance Overtime
/// </summary>
public partial class HrAttendanceOvertime
{
    public int Id { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Day
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Adjustment
    /// </summary>
    public bool? Adjustment { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Extra Hours
    /// </summary>
    public double Duration { get; set; }

    /// <summary>
    /// Extra Hours (Real)
    /// </summary>
    public double? DurationReal { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();

    public virtual ResUser? WriteU { get; set; }
}
