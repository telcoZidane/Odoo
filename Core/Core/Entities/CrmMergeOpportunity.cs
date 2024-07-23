using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Merge Opportunities
/// </summary>
public partial class CrmMergeOpportunity
{
    public int Id { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? UserId { get; set; }

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
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmLead> Opportunities { get; set; } = new List<CrmLead>();
}
