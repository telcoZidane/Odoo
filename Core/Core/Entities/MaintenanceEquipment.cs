using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Maintenance Equipment
/// </summary>
public partial class MaintenanceEquipment
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
    /// Technician
    /// </summary>
    public int? TechnicianUserId { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? OwnerUserId { get; set; }

    /// <summary>
    /// Equipment Category
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Vendor
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Maintenance Count
    /// </summary>
    public int? MaintenanceCount { get; set; }

    /// <summary>
    /// Current Maintenance
    /// </summary>
    public int? MaintenanceOpenCount { get; set; }

    /// <summary>
    /// Days between each preventive maintenance
    /// </summary>
    public int? Period { get; set; }

    /// <summary>
    /// Maintenance Team
    /// </summary>
    public int? MaintenanceTeamId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Vendor Reference
    /// </summary>
    public string? PartnerRef { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public string? Location { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Serial Number
    /// </summary>
    public string? SerialNo { get; set; }

    /// <summary>
    /// Assigned Date
    /// </summary>
    public DateOnly? AssignDate { get; set; }

    /// <summary>
    /// Effective Date
    /// </summary>
    public DateOnly EffectiveDate { get; set; }

    /// <summary>
    /// Warranty Expiration Date
    /// </summary>
    public DateOnly? WarrantyDate { get; set; }

    /// <summary>
    /// Scrap Date
    /// </summary>
    public DateOnly? ScrapDate { get; set; }

    /// <summary>
    /// Date of the next preventive maintenance
    /// </summary>
    public DateOnly? NextActionDate { get; set; }

    /// <summary>
    /// Equipment Name
    /// </summary>
    public string Name { get; set; } = null!;

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

    /// <summary>
    /// Cost
    /// </summary>
    public double? Cost { get; set; }

    /// <summary>
    /// Maintenance Duration
    /// </summary>
    public double? MaintenanceDuration { get; set; }

    /// <summary>
    /// Assigned Employee
    /// </summary>
    public int? EmployeeId { get; set; }

    /// <summary>
    /// Assigned Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Used By
    /// </summary>
    public string EquipmentAssignTo { get; set; } = null!;

    public virtual MaintenanceEquipmentCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();

    public virtual MaintenanceTeam? MaintenanceTeam { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? OwnerUser { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? TechnicianUser { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
