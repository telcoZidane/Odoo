using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Services for vehicles
/// </summary>
public partial class FleetVehicleLogService
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Vehicle
    /// </summary>
    public int VehicleId { get; set; }

    /// <summary>
    /// Fleet Manager
    /// </summary>
    public int? ManagerId { get; set; }

    /// <summary>
    /// Odometer
    /// </summary>
    public int? OdometerId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Driver
    /// </summary>
    public int? PurchaserId { get; set; }

    /// <summary>
    /// Vendor
    /// </summary>
    public int? VendorId { get; set; }

    /// <summary>
    /// Service Type
    /// </summary>
    public int ServiceTypeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Vendor Reference
    /// </summary>
    public string? InvRef { get; set; }

    /// <summary>
    /// Stage
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Cost
    /// </summary>
    public decimal? Amount { get; set; }

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
    /// Driver (Employee)
    /// </summary>
    public int? PurchaserEmployeeId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? Manager { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual FleetVehicleOdometer? Odometer { get; set; }

    public virtual ResPartner? Purchaser { get; set; }

    public virtual HrEmployee? PurchaserEmployee { get; set; }

    public virtual FleetServiceType ServiceType { get; set; } = null!;

    public virtual FleetVehicle Vehicle { get; set; } = null!;

    public virtual ResPartner? Vendor { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
