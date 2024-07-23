using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Gamification Badge
/// </summary>
public partial class GamificationBadge
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Limitation Number
    /// </summary>
    public int? RuleMaxNumber { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Forum Badge Level
    /// </summary>
    public string? Level { get; set; }

    /// <summary>
    /// Allowance to Grant
    /// </summary>
    public string RuleAuth { get; set; } = null!;

    /// <summary>
    /// Badge
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Monthly Limited Sending
    /// </summary>
    public bool? RuleMax { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Survey
    /// </summary>
    public int? SurveyId { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<GamificationBadgeUserWizard> GamificationBadgeUserWizards { get; set; } = new List<GamificationBadgeUserWizard>();

    public virtual ICollection<GamificationBadgeUser> GamificationBadgeUsers { get; set; } = new List<GamificationBadgeUser>();

    public virtual ICollection<GamificationChallenge> GamificationChallengeRewardFirsts { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<GamificationChallenge> GamificationChallengeRewardSeconds { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<GamificationChallenge> GamificationChallengeRewardThirds { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<GamificationChallenge> GamificationChallengeRewards { get; set; } = new List<GamificationChallenge>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual SurveySurvey? Survey { get; set; }

    public virtual SurveySurvey? SurveySurvey { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<GamificationBadge> Badge1s { get; set; } = new List<GamificationBadge>();

    public virtual ICollection<GamificationBadge> Badge2s { get; set; } = new List<GamificationBadge>();

    public virtual ICollection<GamificationGoalDefinition> GamificationGoalDefinitions { get; set; } = new List<GamificationGoalDefinition>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();
}
