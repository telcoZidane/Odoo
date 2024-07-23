using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Personal Task Stage
/// </summary>
public partial class ProjectTaskUserRel
{
    public int Id { get; set; }

    /// <summary>
    /// Task
    /// </summary>
    public int TaskId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Stage
    /// </summary>
    public int? StageId { get; set; }

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

    public virtual ProjectTaskType? Stage { get; set; }

    public virtual ProjectTask Task { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
