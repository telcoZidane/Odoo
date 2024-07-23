using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Gamification Goal Wizard
/// </summary>
public partial class GamificationGoalWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Goal
    /// </summary>
    public int GoalId { get; set; }

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
    /// Current
    /// </summary>
    public double? Current { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual GamificationGoal Goal { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
