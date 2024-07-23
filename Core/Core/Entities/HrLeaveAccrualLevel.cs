using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accrual Plan Level
/// </summary>
public partial class HrLeaveAccrualLevel
{
    public int Id { get; set; }

    /// <summary>
    /// sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Accrual Plan
    /// </summary>
    public int AccrualPlanId { get; set; }

    /// <summary>
    /// Start after
    /// </summary>
    public int? StartCount { get; set; }

    /// <summary>
    /// First Day
    /// </summary>
    public int? FirstDay { get; set; }

    /// <summary>
    /// Second Day
    /// </summary>
    public int? SecondDay { get; set; }

    /// <summary>
    /// First Month Day
    /// </summary>
    public int? FirstMonthDay { get; set; }

    /// <summary>
    /// Second Month Day
    /// </summary>
    public int? SecondMonthDay { get; set; }

    /// <summary>
    /// Yearly Day
    /// </summary>
    public int? YearlyDay { get; set; }

    /// <summary>
    /// Previous Level
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Maximum amount of accruals to transfer
    /// </summary>
    public int? PostponeMaxDays { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    ///  
    /// </summary>
    public string StartType { get; set; } = null!;

    /// <summary>
    /// Added Value Type
    /// </summary>
    public string AddedValueType { get; set; } = null!;

    /// <summary>
    /// Frequency
    /// </summary>
    public string Frequency { get; set; } = null!;

    /// <summary>
    /// Allocation on
    /// </summary>
    public string WeekDay { get; set; } = null!;

    /// <summary>
    /// First Month
    /// </summary>
    public string? FirstMonth { get; set; }

    /// <summary>
    /// Second Month
    /// </summary>
    public string? SecondMonth { get; set; }

    /// <summary>
    /// Yearly Month
    /// </summary>
    public string? YearlyMonth { get; set; }

    /// <summary>
    /// At the end of the calendar year, unused accruals will be
    /// </summary>
    public string ActionWithUnusedAccruals { get; set; } = null!;

    /// <summary>
    /// Rate
    /// </summary>
    public decimal AddedValue { get; set; }

    /// <summary>
    /// Based on worked time
    /// </summary>
    public bool? IsBasedOnWorkedTime { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Limit to
    /// </summary>
    public double? MaximumLeave { get; set; }

    public virtual HrLeaveAccrualPlan AccrualPlan { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrLeaveAccrualLevel> InverseParent { get; set; } = new List<HrLeaveAccrualLevel>();

    public virtual HrLeaveAccrualLevel? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
