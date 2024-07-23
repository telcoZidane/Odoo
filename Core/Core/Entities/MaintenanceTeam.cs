using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Maintenance Teams
/// </summary>
public partial class MaintenanceTeam
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

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
    /// Team Name
    /// </summary>
    public string Name { get; set; } = null!;

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

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; set; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();
}
