using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Model of a vehicle
/// </summary>
public partial class FleetVehicleModel
{
    public int Id { get; set; }

    /// <summary>
    /// Manufacturer
    /// </summary>
    public int BrandId { get; set; }

    /// <summary>
    /// Category
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Model Year
    /// </summary>
    public int? ModelYear { get; set; }

    /// <summary>
    /// Seats Number
    /// </summary>
    public int? Seats { get; set; }

    /// <summary>
    /// Doors Number
    /// </summary>
    public int? Doors { get; set; }

    /// <summary>
    /// Power
    /// </summary>
    public int? Power { get; set; }

    /// <summary>
    /// Horsepower
    /// </summary>
    public int? Horsepower { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Model name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Vehicle Type
    /// </summary>
    public string VehicleType { get; set; } = null!;

    /// <summary>
    /// Transmission
    /// </summary>
    public string? Transmission { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// Co2 Standard
    /// </summary>
    public string? Co2Standard { get; set; }

    /// <summary>
    /// Fuel Type
    /// </summary>
    public string? DefaultFuelType { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Trailer Hitch
    /// </summary>
    public bool? TrailerHook { get; set; }

    /// <summary>
    /// Electric Assistance
    /// </summary>
    public bool? ElectricAssistance { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// CO2 Emissions
    /// </summary>
    public double? DefaultCo2 { get; set; }

    /// <summary>
    /// Horsepower Taxation
    /// </summary>
    public double? HorsepowerTax { get; set; }

    public virtual FleetVehicleModelBrand Brand { get; set; } = null!;

    public virtual FleetVehicleModelCategory? Category { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<FleetVehicle> FleetVehicles { get; set; } = new List<FleetVehicle>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> Partners { get; set; } = new List<ResPartner>();
}
