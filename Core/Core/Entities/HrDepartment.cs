using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Department
/// </summary>
public partial class HrDepartment
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Parent Department
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Manager
    /// </summary>
    public int? ManagerId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Master Department
    /// </summary>
    public int? MasterDepartmentId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Department Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Complete Name
    /// </summary>
    public string? CompleteName { get; set; }

    /// <summary>
    /// Parent Path
    /// </summary>
    public string? ParentPath { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrContract> HrContracts { get; set; } = new List<HrContract>();

    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogs { get; set; } = new List<HrEmployeeSkillLog>();

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrPlan> HrPlans { get; set; } = new List<HrPlan>();

    public virtual ICollection<HrDepartment> InverseMasterDepartment { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrDepartment> InverseParent { get; set; } = new List<HrDepartment>();

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; set; } = new List<MaintenanceEquipment>();

    public virtual HrEmployee? Manager { get; set; }

    public virtual HrDepartment? MasterDepartment { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual HrDepartment? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDays { get; set; } = new List<HrLeaveStressDay>();

    public virtual ICollection<MailChannel> MailChannels { get; set; } = new List<MailChannel>();
}
