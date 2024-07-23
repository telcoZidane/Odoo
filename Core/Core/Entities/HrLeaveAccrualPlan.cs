using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accrual Plan
/// </summary>
public partial class HrLeaveAccrualPlan
{
    public int Id { get; set; }

    /// <summary>
    /// Time Off Type
    /// </summary>
    public int? TimeOffTypeId { get; set; }

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
    /// Level Transition
    /// </summary>
    public string TransitionMode { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevels { get; set; } = new List<HrLeaveAccrualLevel>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; set; } = new List<HrLeaveAllocation>();

    public virtual HrLeaveType? TimeOffType { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
