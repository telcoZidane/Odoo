using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Vehicle Contract
/// </summary>
public partial class FleetVehicleLogContract
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
    /// Type
    /// </summary>
    public int? CostSubtypeId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Vendor
    /// </summary>
    public int? InsurerId { get; set; }

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
    /// Reference
    /// </summary>
    public string? InsRef { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Recurring Cost Frequency
    /// </summary>
    public string CostFrequency { get; set; } = null!;

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Contract Start Date
    /// </summary>
    public DateOnly? StartDate { get; set; }

    /// <summary>
    /// Contract Expiration Date
    /// </summary>
    public DateOnly? ExpirationDate { get; set; }

    /// <summary>
    /// Terms and Conditions
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Cost
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Recurring Cost
    /// </summary>
    public decimal? CostGenerated { get; set; }

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

    public virtual FleetServiceType? CostSubtype { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Insurer { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual FleetVehicle Vehicle { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<FleetServiceType> FleetServiceTypes { get; set; } = new List<FleetServiceType>();
}
