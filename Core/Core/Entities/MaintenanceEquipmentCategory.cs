using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Maintenance Equipment Category
/// </summary>
public partial class MaintenanceEquipmentCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Alias
    /// </summary>
    public int AliasId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? TechnicianUserId { get; set; }

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
    /// Category Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Comments
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Folded in Maintenance Pipe
    /// </summary>
    public bool? Fold { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual MailAlias Alias { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; set; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? TechnicianUser { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
