using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Gamification Challenge
/// </summary>
public partial class GamificationChallenge
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? ManagerId { get; set; }

    /// <summary>
    /// For Every Succeeding User
    /// </summary>
    public int? RewardId { get; set; }

    /// <summary>
    /// For 1st user
    /// </summary>
    public int? RewardFirstId { get; set; }

    /// <summary>
    /// For 2nd user
    /// </summary>
    public int? RewardSecondId { get; set; }

    /// <summary>
    /// For 3rd user
    /// </summary>
    public int? RewardThirdId { get; set; }

    /// <summary>
    /// Send a copy to
    /// </summary>
    public int? ReportMessageGroupId { get; set; }

    /// <summary>
    /// Report Template
    /// </summary>
    public int ReportTemplateId { get; set; }

    /// <summary>
    /// Non-updated manual goals will be reminded after
    /// </summary>
    public int? RemindUpdateDelay { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// User domain
    /// </summary>
    public string? UserDomain { get; set; }

    /// <summary>
    /// Periodicity
    /// </summary>
    public string Period { get; set; } = null!;

    /// <summary>
    /// Display Mode
    /// </summary>
    public string VisibilityMode { get; set; } = null!;

    /// <summary>
    /// Report Frequency
    /// </summary>
    public string ReportMessageFrequency { get; set; } = null!;

    /// <summary>
    /// Appears in
    /// </summary>
    public string ChallengeCategory { get; set; } = null!;

    /// <summary>
    /// Start Date
    /// </summary>
    public DateOnly? StartDate { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? EndDate { get; set; }

    /// <summary>
    /// Last Report Date
    /// </summary>
    public DateOnly? LastReportDate { get; set; }

    /// <summary>
    /// Next Report Date
    /// </summary>
    public DateOnly? NextReportDate { get; set; }

    /// <summary>
    /// Challenge Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Reward Bests if not Succeeded?
    /// </summary>
    public bool? RewardFailure { get; set; }

    /// <summary>
    /// Reward as soon as every goal is reached
    /// </summary>
    public bool? RewardRealtime { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<GamificationBadgeUser> GamificationBadgeUsers { get; set; } = new List<GamificationBadgeUser>();

    public virtual ICollection<GamificationChallengeLine> GamificationChallengeLines { get; set; } = new List<GamificationChallengeLine>();

    public virtual ICollection<GamificationGoal> GamificationGoals { get; set; } = new List<GamificationGoal>();

    public virtual ResUser? Manager { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual MailChannel? ReportMessageGroup { get; set; }

    public virtual MailTemplate ReportTemplate { get; set; } = null!;

    public virtual GamificationBadge? Reward { get; set; }

    public virtual GamificationBadge? RewardFirst { get; set; }

    public virtual GamificationBadge? RewardSecond { get; set; }

    public virtual GamificationBadge? RewardThird { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ICollection<ResUser> ResUsersNavigation { get; set; } = new List<ResUser>();
}
