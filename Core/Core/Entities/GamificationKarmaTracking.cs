using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Track Karma Changes
/// </summary>
public partial class GamificationKarmaTracking
{
    public int Id { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Old Karma Value
    /// </summary>
    public int OldValue { get; set; }

    /// <summary>
    /// New Karma Value
    /// </summary>
    public int NewValue { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Tracking Date
    /// </summary>
    public DateOnly? TrackingDate { get; set; }

    /// <summary>
    /// Consolidated
    /// </summary>
    public bool? Consolidated { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
