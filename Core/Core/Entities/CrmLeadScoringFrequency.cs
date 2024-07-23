using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Lead Scoring Frequency
/// </summary>
public partial class CrmLeadScoringFrequency
{
    public int Id { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? TeamId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Variable
    /// </summary>
    public string? Variable { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// Won Count
    /// </summary>
    public decimal? WonCount { get; set; }

    /// <summary>
    /// Lost Count
    /// </summary>
    public decimal? LostCount { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
