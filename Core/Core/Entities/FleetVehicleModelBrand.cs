using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Brand of the vehicle
/// </summary>
public partial class FleetVehicleModelBrand
{
    public int Id { get; set; }

    /// <summary>
    /// Model Count
    /// </summary>
    public int? ModelCount { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

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

    public virtual ICollection<FleetVehicleModel> FleetVehicleModels { get; set; } = new List<FleetVehicleModel>();

    public virtual ICollection<FleetVehicle> FleetVehicles { get; set; } = new List<FleetVehicle>();

    public virtual ResUser? WriteU { get; set; }
}
