using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Time Off Type
/// </summary>
public partial class HrLeaveType
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Cover Image
    /// </summary>
    public int? IconId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Responsible Time Off Officer
    /// </summary>
    public int? ResponsibleId { get; set; }

    /// <summary>
    /// Time Off Notification Subtype
    /// </summary>
    public int? LeaveNotifSubtypeId { get; set; }

    /// <summary>
    /// Allocation Notification Subtype
    /// </summary>
    public int? AllocationNotifSubtypeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Color in Report
    /// </summary>
    public string ColorName { get; set; } = null!;

    /// <summary>
    /// Leave Validation
    /// </summary>
    public string? LeaveValidationType { get; set; }

    /// <summary>
    /// Requires allocation
    /// </summary>
    public string RequiresAllocation { get; set; } = null!;

    /// <summary>
    /// Employee Requests
    /// </summary>
    public string EmployeeRequests { get; set; } = null!;

    /// <summary>
    /// Approval
    /// </summary>
    public string? AllocationValidationType { get; set; }

    /// <summary>
    /// Kind of Time Off
    /// </summary>
    public string? TimeType { get; set; }

    /// <summary>
    /// Take Time Off in
    /// </summary>
    public string RequestUnit { get; set; } = null!;

    /// <summary>
    /// Time Off Type
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Display Time Off in Calendar
    /// </summary>
    public bool? CreateCalendarMeeting { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Is Unpaid
    /// </summary>
    public bool? Unpaid { get; set; }

    /// <summary>
    /// Supporting Document
    /// </summary>
    public bool? SupportDocument { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Deduct Extra Hours
    /// </summary>
    public bool? OvertimeDeductible { get; set; }

    public virtual MailMessageSubtype? AllocationNotifSubtype { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrLeaveAccrualPlan> HrLeaveAccrualPlans { get; set; } = new List<HrLeaveAccrualPlan>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();

    public virtual IrAttachment? Icon { get; set; }

    public virtual MailMessageSubtype? LeaveNotifSubtype { get; set; }

    public virtual ResUser? Responsible { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
