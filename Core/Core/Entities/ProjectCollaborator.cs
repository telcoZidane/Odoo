using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Collaborators in project shared
/// </summary>
public partial class ProjectCollaborator
{
    public int Id { get; set; }

    /// <summary>
    /// Project Shared
    /// </summary>
    public int ProjectId { get; set; }

    /// <summary>
    /// Collaborator
    /// </summary>
    public int PartnerId { get; set; }

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

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ProjectProject Project { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
