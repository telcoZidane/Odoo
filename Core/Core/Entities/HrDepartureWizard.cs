using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Departure Wizard
/// </summary>
public partial class HrDepartureWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Departure Reason
    /// </summary>
    public int DepartureReasonId { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Departure Date
    /// </summary>
    public DateOnly DepartureDate { get; set; }

    /// <summary>
    /// Additional Information
    /// </summary>
    public string? DepartureDescription { get; set; }

    /// <summary>
    /// Archive Private Address
    /// </summary>
    public bool? ArchivePrivateAddress { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Set Contract End Date
    /// </summary>
    public bool? SetDateEnd { get; set; }

    /// <summary>
    /// Cancel Future Leaves
    /// </summary>
    public bool? CancelLeaves { get; set; }

    /// <summary>
    /// Archive Employee Allocations
    /// </summary>
    public bool? ArchiveAllocation { get; set; }

    /// <summary>
    /// Release Company Car
    /// </summary>
    public bool? ReleaseCampanyCar { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartureReason DepartureReason { get; set; } = null!;

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
