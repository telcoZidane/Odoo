using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Project Update
/// </summary>
public partial class ProjectUpdate
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Progress
    /// </summary>
    public int? Progress { get; set; }

    /// <summary>
    /// Author
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Project
    /// </summary>
    public int ProjectId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Email cc
    /// </summary>
    public string? EmailCc { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ProjectProject Project { get; set; } = null!;

    public virtual ICollection<ProjectProject> ProjectProjects { get; set; } = new List<ProjectProject>();

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
