using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Odometer log for a vehicle
/// </summary>
public partial class FleetVehicleOdometer
{
    public int Id { get; set; }

    /// <summary>
    /// Vehicle
    /// </summary>
    public int VehicleId { get; set; }

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
    public string? Name { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Odometer Value
    /// </summary>
    public double? Value { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; set; } = new List<FleetVehicleLogService>();

    public virtual FleetVehicle Vehicle { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
