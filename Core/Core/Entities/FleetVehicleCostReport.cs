using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class FleetVehicleCostReport
{
    public long? Id { get; set; }

    public int? CompanyId { get; set; }

    public int? VehicleId { get; set; }

    public string? Name { get; set; }

    public int? DriverId { get; set; }

    public string? FuelType { get; set; }

    public DateOnly? DateStart { get; set; }

    public string? VehicleType { get; set; }

    public double? Cost { get; set; }

    public string? CostType { get; set; }
}
