using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// HR Time Off Summary Report By Employee
/// </summary>
public partial class HrHolidaysSummaryEmployee
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Select Time Off Type
    /// </summary>
    public string HolidayType { get; set; } = null!;

    /// <summary>
    /// From
    /// </summary>
    public DateOnly DateFrom { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrEmployee> Emps { get; set; } = new List<HrEmployee>();
}
