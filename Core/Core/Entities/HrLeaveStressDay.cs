using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stress Day
/// </summary>
public partial class HrLeaveStressDay
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Working Hours
    /// </summary>
    public int? ResourceCalendarId { get; set; }

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
    /// Start Date
    /// </summary>
    public DateOnly StartDate { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly EndDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();
}
