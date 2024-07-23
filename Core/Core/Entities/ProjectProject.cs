using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Project
/// </summary>
public partial class ProjectProject
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Alias
    /// </summary>
    public int AliasId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Analytic Account
    /// </summary>
    public int? AnalyticAccountId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Project Manager
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Stage
    /// </summary>
    public int? StageId { get; set; }

    /// <summary>
    /// Last Update
    /// </summary>
    public int? LastUpdateId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Security Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? PartnerEmail { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? PartnerPhone { get; set; }

    /// <summary>
    /// Visibility
    /// </summary>
    public string PrivacyVisibility { get; set; } = null!;

    /// <summary>
    /// Customer Ratings Status
    /// </summary>
    public string RatingStatus { get; set; } = null!;

    /// <summary>
    /// Rating Frequency
    /// </summary>
    public string RatingStatusPeriod { get; set; } = null!;

    /// <summary>
    /// Last Update Status
    /// </summary>
    public string LastUpdateStatus { get; set; } = null!;

    /// <summary>
    /// Start Date
    /// </summary>
    public DateOnly? DateStart { get; set; }

    /// <summary>
    /// Expiration Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Use Tasks as
    /// </summary>
    public string? LabelTasks { get; set; }

    /// <summary>
    /// Task Properties
    /// </summary>
    public string? TaskPropertiesDefinition { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Sub-tasks
    /// </summary>
    public bool? AllowSubtasks { get; set; }

    /// <summary>
    /// Recurring Tasks
    /// </summary>
    public bool? AllowRecurringTasks { get; set; }

    /// <summary>
    /// Task Dependencies
    /// </summary>
    public bool? AllowTaskDependencies { get; set; }

    /// <summary>
    /// Milestones
    /// </summary>
    public bool? AllowMilestones { get; set; }

    /// <summary>
    /// Customer Ratings
    /// </summary>
    public bool? RatingActive { get; set; }

    /// <summary>
    /// Rating Request Deadline
    /// </summary>
    public DateTime? RatingRequestDeadline { get; set; }

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
    /// Billable
    /// </summary>
    public bool? AllowBillable { get; set; }

    public virtual MailAlias Alias { get; set; } = null!;

    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProjectUpdate? LastUpdate { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ICollection<ProjectCollaborator> ProjectCollaborators { get; set; } = new List<ProjectCollaborator>();

    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; set; } = new List<ProjectMilestone>();

    public virtual ICollection<ProjectTask> ProjectTaskDisplayProjects { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTask> ProjectTaskProjects { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectUpdate> ProjectUpdates { get; set; } = new List<ProjectUpdate>();

    public virtual SaleOrderLine? SaleLine { get; set; }

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ProjectProjectStage? Stage { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProjectTag> ProjectTags { get; set; } = new List<ProjectTag>();

    public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizards { get; set; } = new List<ProjectTaskTypeDeleteWizard>();

    public virtual ICollection<ProjectTaskType> Types { get; set; } = new List<ProjectTaskType>();

    public virtual ICollection<ResUser> Users { get; set; } = new List<ResUser>();
}
