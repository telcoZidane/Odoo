using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Gamification User Badge
/// </summary>
public partial class GamificationBadgeUser
{
    public int Id { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Sender
    /// </summary>
    public int? SenderId { get; set; }

    /// <summary>
    /// Badge
    /// </summary>
    public int BadgeId { get; set; }

    /// <summary>
    /// Challenge
    /// </summary>
    public int? ChallengeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Badge Level
    /// </summary>
    public string? Level { get; set; }

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
    public int? EmployeeId { get; set; }

    public virtual GamificationBadge Badge { get; set; } = null!;

    public virtual GamificationChallenge? Challenge { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ResUser? Sender { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
