using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Task
/// </summary>
public partial class ProjectTask
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Stage
    /// </summary>
    public int? StageId { get; set; }

    /// <summary>
    /// Project
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// Display Project
    /// </summary>
    public int? DisplayProjectId { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Cover Image
    /// </summary>
    public int? DisplayedImageId { get; set; }

    /// <summary>
    /// Parent Task
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Ancestor Task
    /// </summary>
    public int? AncestorId { get; set; }

    /// <summary>
    /// Milestone
    /// </summary>
    public int? MilestoneId { get; set; }

    /// <summary>
    /// Recurrence
    /// </summary>
    public int? RecurrenceId { get; set; }

    /// <summary>
    /// Analytic Account
    /// </summary>
    public int? AnalyticAccountId { get; set; }

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
    /// Security Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string KanbanState { get; set; } = null!;

    /// <summary>
    /// Email
    /// </summary>
    public string? PartnerEmail { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? PartnerPhone { get; set; }

    /// <summary>
    /// Email From
    /// </summary>
    public string? EmailFrom { get; set; }

    /// <summary>
    /// Deadline
    /// </summary>
    public DateOnly? DateDeadline { get; set; }

    /// <summary>
    /// Properties
    /// </summary>
    public string? TaskProperties { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Working Hours to Assign
    /// </summary>
    public decimal? WorkingHoursOpen { get; set; }

    /// <summary>
    /// Working Hours to Close
    /// </summary>
    public decimal? WorkingHoursClose { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Closing Stage
    /// </summary>
    public bool? IsClosed { get; set; }

    /// <summary>
    /// Is Blocked
    /// </summary>
    public bool? IsBlocked { get; set; }

    /// <summary>
    /// Recurrent
    /// </summary>
    public bool? RecurringTask { get; set; }

    /// <summary>
    /// Is Analytic Account Manually Changed
    /// </summary>
    public bool? IsAnalyticAccountIdChanged { get; set; }

    /// <summary>
    /// Created On
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated On
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Ending Date
    /// </summary>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// Assigning Date
    /// </summary>
    public DateTime? DateAssign { get; set; }

    /// <summary>
    /// Last Stage Update
    /// </summary>
    public DateTime? DateLastStageUpdate { get; set; }

    /// <summary>
    /// Rating Last Value
    /// </summary>
    public double? RatingLastValue { get; set; }

    /// <summary>
    /// Initially Planned Hours
    /// </summary>
    public double? PlannedHours { get; set; }

    /// <summary>
    /// Working Days to Assign
    /// </summary>
    public double? WorkingDaysOpen { get; set; }

    /// <summary>
    /// Working Days to Close
    /// </summary>
    public double? WorkingDaysClose { get; set; }

    /// <summary>
    /// Sales Order
    /// </summary>
    public int? SaleOrderId { get; set; }

    /// <summary>
    /// Sales Order Item
    /// </summary>
    public int? SaleLineId { get; set; }

    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    public virtual ProjectTask? Ancestor { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProjectProject? DisplayProject { get; set; }

    public virtual IrAttachment? DisplayedImage { get; set; }

    public virtual ICollection<ProjectTask> InverseAncestor { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTask> InverseParent { get; set; } = new List<ProjectTask>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ProjectMilestone? Milestone { get; set; }

    public virtual ProjectTask? Parent { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ProjectProject? Project { get; set; }

    public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRels { get; set; } = new List<ProjectTaskUserRel>();

    public virtual ProjectTaskRecurrence? Recurrence { get; set; }

    public virtual SaleOrderLine? SaleLine { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ProjectTaskType? Stage { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProjectTask> DependsOns { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTag> ProjectTags { get; set; } = new List<ProjectTag>();

    public virtual ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
}
