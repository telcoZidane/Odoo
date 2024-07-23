using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Time Off Allocation
/// </summary>
public partial class HrLeaveAllocation
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Time Off Type
    /// </summary>
    public int HolidayStatusId { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int? EmployeeId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? EmployeeCompanyId { get; set; }

    /// <summary>
    /// Manager
    /// </summary>
    public int? ManagerId { get; set; }

    /// <summary>
    /// Parent
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// First Approval
    /// </summary>
    public int? ApproverId { get; set; }

    /// <summary>
    /// Company Mode
    /// </summary>
    public int? ModeCompanyId { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Employee Tag
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Accrual Plan
    /// </summary>
    public int? AccrualPlanId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Allocation Description
    /// </summary>
    public string? PrivateName { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Allocation Mode
    /// </summary>
    public string HolidayType { get; set; } = null!;

    /// <summary>
    /// Allocation Type
    /// </summary>
    public string AllocationType { get; set; } = null!;

    /// <summary>
    /// Start Date
    /// </summary>
    public DateOnly DateFrom { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? DateTo { get; set; }

    /// <summary>
    /// Date of the last accrual allocation
    /// </summary>
    public DateOnly? Lastcall { get; set; }

    /// <summary>
    /// Date of the next accrual allocation
    /// </summary>
    public DateOnly? Nextcall { get; set; }

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
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Number of Days
    /// </summary>
    public double? NumberOfDays { get; set; }

    /// <summary>
    /// Extra Hours
    /// </summary>
    public int? OvertimeId { get; set; }

    public virtual HrLeaveAccrualPlan? AccrualPlan { get; set; }

    public virtual HrEmployee? Approver { get; set; }

    public virtual HrEmployeeCategory? Category { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ResCompany? EmployeeCompany { get; set; }

    public virtual HrLeaveType HolidayStatus { get; set; } = null!;

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrLeaveAllocation> InverseParent { get; set; } = new List<HrLeaveAllocation>();

    public virtual HrEmployee? Manager { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResCompany? ModeCompany { get; set; }

    public virtual HrAttendanceOvertime? Overtime { get; set; }

    public virtual HrLeaveAllocation? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();
}
