using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Recycling Model
/// </summary>
public partial class DataRecycleModel
{
    public int Id { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int ResModelId { get; set; }

    /// <summary>
    /// Time Field
    /// </summary>
    public int? TimeFieldId { get; set; }

    /// <summary>
    /// Delta
    /// </summary>
    public int? TimeFieldDelta { get; set; }

    /// <summary>
    /// Notify
    /// </summary>
    public int? NotifyFrequency { get; set; }

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
    public string Name { get; set; } = null!;

    /// <summary>
    /// Model Name
    /// </summary>
    public string? ResModelName { get; set; }

    /// <summary>
    /// Recycle Mode
    /// </summary>
    public string RecycleMode { get; set; } = null!;

    /// <summary>
    /// Recycle Action
    /// </summary>
    public string RecycleAction { get; set; } = null!;

    /// <summary>
    /// Filter
    /// </summary>
    public string? Domain { get; set; }

    /// <summary>
    /// Delta Unit
    /// </summary>
    public string? TimeFieldDeltaUnit { get; set; }

    /// <summary>
    /// Notify Frequency Period
    /// </summary>
    public string? NotifyFrequencyPeriod { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Include Archived
    /// </summary>
    public bool? IncludeArchived { get; set; }

    /// <summary>
    /// Last Notification
    /// </summary>
    public DateTime? LastNotification { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<DataRecycleRecord> DataRecycleRecords { get; set; } = new List<DataRecycleRecord>();

    public virtual IrModel ResModel { get; set; } = null!;

    public virtual IrModelField? TimeField { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();
}
