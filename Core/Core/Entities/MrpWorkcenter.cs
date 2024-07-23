using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Work Center
/// </summary>
public partial class MrpWorkcenter
{
    public int Id { get; set; }

    /// <summary>
    /// Resource
    /// </summary>
    public int ResourceId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Working Hours
    /// </summary>
    public int? ResourceCalendarId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Work Center
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Workcenter Status
    /// </summary>
    public string? WorkingState { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Note { get; set; }

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
    /// Time Efficiency
    /// </summary>
    public double? TimeEfficiency { get; set; }

    /// <summary>
    /// Capacity
    /// </summary>
    public double? DefaultCapacity { get; set; }

    /// <summary>
    /// Cost per hour
    /// </summary>
    public double? CostsHour { get; set; }

    /// <summary>
    /// Setup Time
    /// </summary>
    public double? TimeStart { get; set; }

    /// <summary>
    /// Cleanup Time
    /// </summary>
    public double? TimeStop { get; set; }

    /// <summary>
    /// OEE Target
    /// </summary>
    public double? OeeTarget { get; set; }

    /// <summary>
    /// Analytic Account
    /// </summary>
    public int? CostsHourAccountId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual AccountAnalyticAccount? CostsHourAccount { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenters { get; set; } = new List<MrpRoutingWorkcenter>();

    public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacities { get; set; } = new List<MrpWorkcenterCapacity>();

    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; set; } = new List<MrpWorkcenterProductivity>();

    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; set; } = new List<MrpWorkorder>();

    public virtual ResourceResource Resource { get; set; } = null!;

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpWorkcenter> AlternativeWorkcenters { get; set; } = new List<MrpWorkcenter>();

    public virtual ICollection<MrpWorkcenterTag> MrpWorkcenterTags { get; set; } = new List<MrpWorkcenterTag>();

    public virtual ICollection<MrpWorkcenter> Workcenters { get; set; } = new List<MrpWorkcenter>();
}
