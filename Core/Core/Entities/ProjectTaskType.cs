using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Task Stage
/// </summary>
public partial class ProjectTaskType
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Email Template
    /// </summary>
    public int? MailTemplateId { get; set; }

    /// <summary>
    /// Rating Email Template
    /// </summary>
    public int? RatingTemplateId { get; set; }

    /// <summary>
    /// Stage Owner
    /// </summary>
    public int? UserId { get; set; }

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
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Red Kanban Label
    /// </summary>
    public string LegendBlocked { get; set; } = null!;

    /// <summary>
    /// Green Kanban Label
    /// </summary>
    public string LegendDone { get; set; } = null!;

    /// <summary>
    /// Grey Kanban Label
    /// </summary>
    public string LegendNormal { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Folded in Kanban
    /// </summary>
    public bool? Fold { get; set; }

    /// <summary>
    /// Automatic Kanban Status
    /// </summary>
    public bool? AutoValidationKanbanState { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// SMS Template
    /// </summary>
    public int? SmsTemplateId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRels { get; set; } = new List<ProjectTaskUserRel>();

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual MailTemplate? RatingTemplate { get; set; }

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizards { get; set; } = new List<ProjectTaskTypeDeleteWizard>();

    public virtual ICollection<ProjectProject> Projects { get; set; } = new List<ProjectProject>();
}
