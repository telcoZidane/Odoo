using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Gamification User Badge Wizard
/// </summary>
public partial class GamificationBadgeUserWizard
{
    public int Id { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Badge
    /// </summary>
    public int BadgeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Comment
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int EmployeeId { get; set; }

    public virtual GamificationBadge Badge { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
