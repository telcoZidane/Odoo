using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Time Off
/// </summary>
public partial class HrLeave
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Manager
    /// </summary>
    public int? ManagerId { get; set; }

    /// <summary>
    /// Time Off Type
    /// </summary>
    public int HolidayStatusId { get; set; }

    /// <summary>
    /// Allocation
    /// </summary>
    public int? HolidayAllocationId { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int? EmployeeId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? EmployeeCompanyId { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Meeting
    /// </summary>
    public int? MeetingId { get; set; }

    /// <summary>
    /// Parent
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Employee Tag
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Company Mode
    /// </summary>
    public int? ModeCompanyId { get; set; }

    /// <summary>
    /// First Approval
    /// </summary>
    public int? FirstApproverId { get; set; }

    /// <summary>
    /// Second Approval
    /// </summary>
    public int? SecondApproverId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Time Off Description
    /// </summary>
    public string? PrivateName { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Requested (Days/Hours)
    /// </summary>
    public string? DurationDisplay { get; set; }

    /// <summary>
    /// Allocation Mode
    /// </summary>
    public string HolidayType { get; set; } = null!;

    /// <summary>
    /// Hour from
    /// </summary>
    public string? RequestHourFrom { get; set; }

    /// <summary>
    /// Hour to
    /// </summary>
    public string? RequestHourTo { get; set; }

    /// <summary>
    /// Date Period Start
    /// </summary>
    public string? RequestDateFromPeriod { get; set; }

    /// <summary>
    /// Request Start Date
    /// </summary>
    public DateOnly? RequestDateFrom { get; set; }

    /// <summary>
    /// Request End Date
    /// </summary>
    public DateOnly? RequestDateTo { get; set; }

    /// <summary>
    /// HR Comments
    /// </summary>
    public string? ReportNote { get; set; }

    /// <summary>
    /// Reasons
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Multi Employee
    /// </summary>
    public bool? MultiEmployee { get; set; }

    /// <summary>
    /// Half Day
    /// </summary>
    public bool? RequestUnitHalf { get; set; }

    /// <summary>
    /// Custom Hours
    /// </summary>
    public bool? RequestUnitHours { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime DateFrom { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateTime DateTo { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Duration (Days)
    /// </summary>
    public double? NumberOfDays { get; set; }

    /// <summary>
    /// Extra Hours
    /// </summary>
    public int? OvertimeId { get; set; }

    public virtual HrEmployeeCategory? Category { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ResCompany? EmployeeCompany { get; set; }

    public virtual HrEmployee? FirstApprover { get; set; }

    public virtual HrLeaveAllocation? HolidayAllocation { get; set; }

    public virtual HrLeaveType HolidayStatus { get; set; } = null!;

    public virtual ICollection<HrHolidaysCancelLeave> HrHolidaysCancelLeaves { get; set; } = new List<HrHolidaysCancelLeave>();

    public virtual ICollection<HrLeave> InverseParent { get; set; } = new List<HrLeave>();

    public virtual HrEmployee? Manager { get; set; }

    public virtual CalendarEvent? Meeting { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResCompany? ModeCompany { get; set; }

    public virtual HrAttendanceOvertime? Overtime { get; set; }

    public virtual HrLeave? Parent { get; set; }

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual HrEmployee? SecondApprover { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();
}
