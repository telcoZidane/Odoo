using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Fleet Service Type
/// </summary>
public partial class FleetServiceType
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Category
    /// </summary>
    public string Category { get; set; } = null!;

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractsNavigation { get; set; } = new List<FleetVehicleLogContract>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; set; } = new List<FleetVehicleLogService>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; set; } = new List<FleetVehicleLogContract>();
}
