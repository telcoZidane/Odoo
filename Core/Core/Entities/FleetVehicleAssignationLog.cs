using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Drivers history on a vehicle
/// </summary>
public partial class FleetVehicleAssignationLog
{
    public int Id { get; set; }

    /// <summary>
    /// Vehicle
    /// </summary>
    public int VehicleId { get; set; }

    /// <summary>
    /// Driver
    /// </summary>
    public int DriverId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateOnly? DateStart { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? DateEnd { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Driver (Employee)
    /// </summary>
    public int? DriverEmployeeId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner Driver { get; set; } = null!;

    public virtual HrEmployee? DriverEmployee { get; set; }

    public virtual FleetVehicle Vehicle { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
