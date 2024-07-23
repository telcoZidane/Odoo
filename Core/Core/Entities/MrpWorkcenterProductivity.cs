using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Workcenter Productivity Log
/// </summary>
public partial class MrpWorkcenterProductivity
{
    public int Id { get; set; }

    /// <summary>
    /// Work Center
    /// </summary>
    public int WorkcenterId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Work Order
    /// </summary>
    public int? WorkorderId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Loss Reason
    /// </summary>
    public int LossId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Effectiveness
    /// </summary>
    public string? LossType { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime DateStart { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Duration
    /// </summary>
    public double? Duration { get; set; }

    /// <summary>
    /// Cost Recorded
    /// </summary>
    public bool? CostAlreadyRecorded { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpWorkcenterProductivityLoss Loss { get; set; } = null!;

    public virtual ResUser? User { get; set; }

    public virtual MrpWorkcenter Workcenter { get; set; } = null!;

    public virtual MrpWorkorder? Workorder { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
