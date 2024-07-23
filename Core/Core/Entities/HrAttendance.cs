using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Attendance
/// </summary>
public partial class HrAttendance
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
    /// Check In
    /// </summary>
    public DateTime CheckIn { get; set; }

    /// <summary>
    /// Check Out
    /// </summary>
    public DateTime? CheckOut { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Worked Hours
    /// </summary>
    public double? WorkedHours { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ResUser? WriteU { get; set; }
}
