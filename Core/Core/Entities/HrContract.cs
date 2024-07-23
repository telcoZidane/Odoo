using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Contract
/// </summary>
public partial class HrContract
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Salary Structure Type
    /// </summary>
    public int? StructureTypeId { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int? EmployeeId { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Job Position
    /// </summary>
    public int? JobId { get; set; }

    /// <summary>
    /// Working Schedule
    /// </summary>
    public int? ResourceCalendarId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Contract Type
    /// </summary>
    public int? ContractTypeId { get; set; }

    /// <summary>
    /// HR Responsible
    /// </summary>
    public int? HrResponsibleId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Contract Reference
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Kanban State
    /// </summary>
    public string? KanbanState { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateOnly DateStart { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? DateEnd { get; set; }

    /// <summary>
    /// End of Trial Period
    /// </summary>
    public DateOnly? TrialDateEnd { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Wage
    /// </summary>
    public decimal Wage { get; set; }

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

    public virtual ResCompany Company { get; set; } = null!;

    public virtual HrContractType? ContractType { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ResUser? HrResponsible { get; set; }

    public virtual HrJob? Job { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    public virtual HrPayrollStructureType? StructureType { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
