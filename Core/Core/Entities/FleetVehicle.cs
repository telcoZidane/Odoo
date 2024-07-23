using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Vehicle
/// </summary>
public partial class FleetVehicle
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Fleet Manager
    /// </summary>
    public int? ManagerId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Driver
    /// </summary>
    public int? DriverId { get; set; }

    /// <summary>
    /// Future Driver
    /// </summary>
    public int? FutureDriverId { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int ModelId { get; set; }

    /// <summary>
    /// Brand
    /// </summary>
    public int? BrandId { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public int? StateId { get; set; }

    /// <summary>
    /// Seats Number
    /// </summary>
    public int? Seats { get; set; }

    /// <summary>
    /// Doors Number
    /// </summary>
    public int? Doors { get; set; }

    /// <summary>
    /// Horsepower
    /// </summary>
    public int? Horsepower { get; set; }

    /// <summary>
    /// Power
    /// </summary>
    public int? Power { get; set; }

    /// <summary>
    /// Category
    /// </summary>
    public int? CategoryId { get; set; }

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
    /// License Plate
    /// </summary>
    public string? LicensePlate { get; set; }

    /// <summary>
    /// Chassis Number
    /// </summary>
    public string? VinSn { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public string? Location { get; set; }

    /// <summary>
    /// Model Year
    /// </summary>
    public string? ModelYear { get; set; }

    /// <summary>
    /// Odometer Unit
    /// </summary>
    public string OdometerUnit { get; set; } = null!;

    /// <summary>
    /// Transmission
    /// </summary>
    public string? Transmission { get; set; }

    /// <summary>
    /// Fuel Type
    /// </summary>
    public string? FuelType { get; set; }

    /// <summary>
    /// CO2 Standard
    /// </summary>
    public string? Co2Standard { get; set; }

    /// <summary>
    /// Bike Frame Type
    /// </summary>
    public string? FrameType { get; set; }

    /// <summary>
    /// Assignment Date
    /// </summary>
    public DateOnly? NextAssignationDate { get; set; }

    /// <summary>
    /// Registration Date
    /// </summary>
    public DateOnly? AcquisitionDate { get; set; }

    /// <summary>
    /// Cancellation Date
    /// </summary>
    public DateOnly? WriteOffDate { get; set; }

    /// <summary>
    /// First Contract Date
    /// </summary>
    public DateOnly? FirstContractDate { get; set; }

    /// <summary>
    /// Vehicle Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Trailer Hitch
    /// </summary>
    public bool? TrailerHook { get; set; }

    /// <summary>
    /// Plan To Change Car
    /// </summary>
    public bool? PlanToChangeCar { get; set; }

    /// <summary>
    /// Plan To Change Bike
    /// </summary>
    public bool? PlanToChangeBike { get; set; }

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
    /// Horsepower Taxation
    /// </summary>
    public double? HorsepowerTax { get; set; }

    /// <summary>
    /// CO2 Emissions
    /// </summary>
    public double? Co2 { get; set; }

    /// <summary>
    /// Catalog Value (VAT Incl.)
    /// </summary>
    public double? CarValue { get; set; }

    /// <summary>
    /// Purchase Value
    /// </summary>
    public double? NetCarValue { get; set; }

    /// <summary>
    /// Residual Value
    /// </summary>
    public double? ResidualValue { get; set; }

    /// <summary>
    /// Frame Size
    /// </summary>
    public double? FrameSize { get; set; }

    /// <summary>
    /// Driver (Employee)
    /// </summary>
    public int? DriverEmployeeId { get; set; }

    /// <summary>
    /// Future Driver (Employee)
    /// </summary>
    public int? FutureDriverEmployeeId { get; set; }

    /// <summary>
    /// Mobility Card
    /// </summary>
    public string? MobilityCard { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual FleetVehicleModelBrand? Brand { get; set; }

    public virtual FleetVehicleModelCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Driver { get; set; }

    public virtual HrEmployee? DriverEmployee { get; set; }

    public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogs { get; set; } = new List<FleetVehicleAssignationLog>();

    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; set; } = new List<FleetVehicleLogContract>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; set; } = new List<FleetVehicleLogService>();

    public virtual ICollection<FleetVehicleOdometer> FleetVehicleOdometers { get; set; } = new List<FleetVehicleOdometer>();

    public virtual ResPartner? FutureDriver { get; set; }

    public virtual HrEmployee? FutureDriverEmployee { get; set; }

    public virtual ResUser? Manager { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual FleetVehicleModel Model { get; set; } = null!;

    public virtual FleetVehicleState? State { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<FleetVehicleTag> Tags { get; set; } = new List<FleetVehicleTag>();
}
