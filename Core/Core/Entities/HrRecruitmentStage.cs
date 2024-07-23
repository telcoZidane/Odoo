using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Recruitment Stages
/// </summary>
public partial class HrRecruitmentStage
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Email Template
    /// </summary>
    public int? TemplateId { get; set; }

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
    /// Requirements
    /// </summary>
    public string? Requirements { get; set; }

    /// <summary>
    /// Folded in Kanban
    /// </summary>
    public bool? Fold { get; set; }

    /// <summary>
    /// Hired Stage
    /// </summary>
    public bool? HiredStage { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrApplicant> HrApplicantLastStages { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrApplicant> HrApplicantStages { get; set; } = new List<HrApplicant>();

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();
}
