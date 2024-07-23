using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// CRM Stages
/// </summary>
public partial class CrmStage
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

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
    /// Stage Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Requirements
    /// </summary>
    public string? Requirements { get; set; }

    /// <summary>
    /// Is Won Stage?
    /// </summary>
    public bool? IsWon { get; set; }

    /// <summary>
    /// Folded in Pipeline
    /// </summary>
    public bool? Fold { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
