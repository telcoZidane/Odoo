using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Gamification Goal Definition
/// </summary>
public partial class GamificationGoalDefinition
{
    public int Id { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int? ModelId { get; set; }

    /// <summary>
    /// Field to Sum
    /// </summary>
    public int? FieldId { get; set; }

    /// <summary>
    /// Date Field
    /// </summary>
    public int? FieldDateId { get; set; }

    /// <summary>
    /// Distinctive field for batch user
    /// </summary>
    public int? BatchDistinctiveField { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public int? ActionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Computation Mode
    /// </summary>
    public string ComputationMode { get; set; } = null!;

    /// <summary>
    /// Displayed as
    /// </summary>
    public string DisplayMode { get; set; } = null!;

    /// <summary>
    /// Filter Domain
    /// </summary>
    public string Domain { get; set; } = null!;

    /// <summary>
    /// Evaluated expression for batch mode
    /// </summary>
    public string? BatchUserExpression { get; set; }

    /// <summary>
    /// Goal Performance
    /// </summary>
    public string Condition { get; set; } = null!;

    /// <summary>
    /// ID Field of user
    /// </summary>
    public string? ResIdField { get; set; }

    /// <summary>
    /// Goal Definition
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Suffix
    /// </summary>
    public string? Suffix { get; set; }

    /// <summary>
    /// Goal Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Python Code
    /// </summary>
    public string? ComputeCode { get; set; }

    /// <summary>
    /// Monetary Value
    /// </summary>
    public bool? Monetary { get; set; }

    /// <summary>
    /// Batch Mode
    /// </summary>
    public bool? BatchMode { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual IrActWindow? Action { get; set; }

    public virtual IrModelField? BatchDistinctiveFieldNavigation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? Field { get; set; }

    public virtual IrModelField? FieldDate { get; set; }

    public virtual ICollection<GamificationChallengeLine> GamificationChallengeLines { get; set; } = new List<GamificationChallengeLine>();

    public virtual ICollection<GamificationGoal> GamificationGoals { get; set; } = new List<GamificationGoal>();

    public virtual IrModel? Model { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<GamificationBadge> GamificationBadges { get; set; } = new List<GamificationBadge>();
}
