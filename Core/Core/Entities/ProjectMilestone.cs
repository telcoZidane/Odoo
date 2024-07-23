using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Project Milestone
/// </summary>
public partial class ProjectMilestone
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Deadline
    /// </summary>
    public DateOnly? Deadline { get; set; }

    /// <summary>
    /// Reached Date
    /// </summary>
    public DateOnly? ReachedDate { get; set; }

    /// <summary>
    /// Reached
    /// </summary>
    public bool? IsReached { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Sales Order Item
    /// </summary>
    public int? SaleLineId { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public double? QuantityPercentage { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ProjectProject Project { get; set; } = null!;

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual SaleOrderLine? SaleLine { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
