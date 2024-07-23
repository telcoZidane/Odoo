using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Gamification generic goal for challenge
/// </summary>
public partial class GamificationChallengeLine
{
    public int Id { get; set; }

    /// <summary>
    /// Challenge
    /// </summary>
    public int ChallengeId { get; set; }

    /// <summary>
    /// Goal Definition
    /// </summary>
    public int DefinitionId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Target Value to Reach
    /// </summary>
    public double TargetGoal { get; set; }

    public virtual GamificationChallenge Challenge { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual GamificationGoalDefinition Definition { get; set; } = null!;

    public virtual ICollection<GamificationGoal> GamificationGoals { get; set; } = new List<GamificationGoal>();

    public virtual ResUser? WriteU { get; set; }
}
