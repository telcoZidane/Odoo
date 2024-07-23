using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Gamification Goal
/// </summary>
public partial class GamificationGoal
{
    public int Id { get; set; }

    /// <summary>
    /// Goal Definition
    /// </summary>
    public int DefinitionId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Challenge Line
    /// </summary>
    public int? LineId { get; set; }

    /// <summary>
    /// Challenge
    /// </summary>
    public int? ChallengeId { get; set; }

    /// <summary>
    /// Remind delay
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
    /// Start Date
    /// </summary>
    public DateOnly? StartDate { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? EndDate { get; set; }

    /// <summary>
    /// Last Update
    /// </summary>
    public DateOnly? LastUpdate { get; set; }

    /// <summary>
    /// To update
    /// </summary>
    public bool? ToUpdate { get; set; }

    /// <summary>
    /// Closed goal
    /// </summary>
    public bool? Closed { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// To Reach
    /// </summary>
    public double TargetGoal { get; set; }

    /// <summary>
    /// Current Value
    /// </summary>
    public double Current { get; set; }

    public virtual GamificationChallenge? Challenge { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual GamificationGoalDefinition Definition { get; set; } = null!;

    public virtual ICollection<GamificationGoalWizard> GamificationGoalWizards { get; set; } = new List<GamificationGoalWizard>();

    public virtual GamificationChallengeLine? Line { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
