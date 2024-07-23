using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Maintenance Request
/// </summary>
public partial class MaintenanceRequest
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
    /// Created by User
    /// </summary>
    public int? OwnerUserId { get; set; }

    /// <summary>
    /// Category
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Equipment
    /// </summary>
    public int? EquipmentId { get; set; }

    /// <summary>
    /// Technician
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Stage
    /// </summary>
    public int? StageId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Team
    /// </summary>
    public int MaintenanceTeamId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Email cc
    /// </summary>
    public string? EmailCc { get; set; }

    /// <summary>
    /// Subjects
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Kanban State
    /// </summary>
    public string KanbanState { get; set; } = null!;

    /// <summary>
    /// Maintenance Type
    /// </summary>
    public string? MaintenanceType { get; set; }

    /// <summary>
    /// Request Date
    /// </summary>
    public DateOnly? RequestDate { get; set; }

    /// <summary>
    /// Close Date
    /// </summary>
    public DateOnly? CloseDate { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Archive
    /// </summary>
    public bool? Archive { get; set; }

    /// <summary>
    /// Scheduled Date
    /// </summary>
    public DateTime? ScheduleDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Duration
    /// </summary>
    public double? Duration { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int? EmployeeId { get; set; }

    public virtual MaintenanceEquipmentCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual MaintenanceEquipment? Equipment { get; set; }

    public virtual MaintenanceTeam MaintenanceTeam { get; set; } = null!;

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? OwnerUser { get; set; }

    public virtual MaintenanceStage? Stage { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
