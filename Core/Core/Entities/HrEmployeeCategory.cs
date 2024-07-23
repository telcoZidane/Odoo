using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Employee Category
/// </summary>
public partial class HrEmployeeCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Tag Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrEmployee> Emps { get; set; } = new List<HrEmployee>();
}
