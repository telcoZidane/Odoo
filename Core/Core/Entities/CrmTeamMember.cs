using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sales Team Member
/// </summary>
public partial class CrmTeamMember
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int CrmTeamId { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Average Leads Capacity (on 30 days)
    /// </summary>
    public int? AssignmentMax { get; set; }

    /// <summary>
    /// Assignment Domain
    /// </summary>
    public string? AssignmentDomain { get; set; }

    /// <summary>
    /// Skip auto assignment
    /// </summary>
    public bool? AssignmentOptout { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam CrmTeam { get; set; } = null!;

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
