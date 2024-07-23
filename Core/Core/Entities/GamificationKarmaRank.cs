using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Rank based on karma
/// </summary>
public partial class GamificationKarmaRank
{
    public int Id { get; set; }

    /// <summary>
    /// Required Karma
    /// </summary>
    public int KarmaMin { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Rank Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Motivational
    /// </summary>
    public string? DescriptionMotivational { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResUser> ResUserNextRanks { get; set; } = new List<ResUser>();

    public virtual ICollection<ResUser> ResUserRanks { get; set; } = new List<ResUser>();

    public virtual ResUser? WriteU { get; set; }
}
