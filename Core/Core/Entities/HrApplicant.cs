using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Applicant
/// </summary>
public partial class HrApplicant
{
    public int Id { get; set; }

    /// <summary>
    /// Campaign
    /// </summary>
    public int? CampaignId { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public int? SourceId { get; set; }

    /// <summary>
    /// Medium
    /// </summary>
    public int? MediumId { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Contact
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Stage
    /// </summary>
    public int? StageId { get; set; }

    /// <summary>
    /// Last Stage
    /// </summary>
    public int? LastStageId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Recruiter
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Applied Job
    /// </summary>
    public int? JobId { get; set; }

    /// <summary>
    /// Degree
    /// </summary>
    public int? TypeId { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int? EmpId { get; set; }

    /// <summary>
    /// Refuse Reason
    /// </summary>
    public int? RefuseReasonId { get; set; }

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
    /// Subject / Application
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Email
    /// </summary>
    public string? EmailFrom { get; set; }

    /// <summary>
    /// Evaluation
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Proposed Salary Extra
    /// </summary>
    public string? SalaryProposedExtra { get; set; }

    /// <summary>
    /// Expected Salary Extra
    /// </summary>
    public string? SalaryExpectedExtra { get; set; }

    /// <summary>
    /// Applicant&apos;s Name
    /// </summary>
    public string? PartnerName { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? PartnerPhone { get; set; }

    /// <summary>
    /// Mobile
    /// </summary>
    public string? PartnerMobile { get; set; }

    /// <summary>
    /// Kanban State
    /// </summary>
    public string KanbanState { get; set; } = null!;

    /// <summary>
    /// LinkedIn Profile
    /// </summary>
    public string? LinkedinProfile { get; set; }

    /// <summary>
    /// Availability
    /// </summary>
    public DateOnly? Availability { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Creation Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Hire Date
    /// </summary>
    public DateTime? DateClosed { get; set; }

    /// <summary>
    /// Assigned
    /// </summary>
    public DateTime? DateOpen { get; set; }

    /// <summary>
    /// Last Stage Update
    /// </summary>
    public DateTime? DateLastStageUpdate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Probability
    /// </summary>
    public double? Probability { get; set; }

    /// <summary>
    /// Proposed Salary
    /// </summary>
    public double? SalaryProposed { get; set; }

    /// <summary>
    /// Expected Salary
    /// </summary>
    public double? SalaryExpected { get; set; }

    /// <summary>
    /// Delay to Close
    /// </summary>
    public double? DelayClose { get; set; }

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Emp { get; set; }

    public virtual ICollection<HrApplicantSkill> HrApplicantSkills { get; set; } = new List<HrApplicantSkill>();

    public virtual HrJob? Job { get; set; }

    public virtual HrRecruitmentStage? LastStage { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual HrApplicantRefuseReason? RefuseReason { get; set; }

    public virtual UtmSource? Source { get; set; }

    public virtual HrRecruitmentStage? Stage { get; set; }

    public virtual HrRecruitmentDegree? Type { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; set; } = new List<ApplicantGetRefuseReason>();

    public virtual ICollection<ApplicantSendMail> ApplicantSendMails { get; set; } = new List<ApplicantSendMail>();

    public virtual ICollection<HrApplicantCategory> HrApplicantCategories { get; set; } = new List<HrApplicantCategory>();

    public virtual ICollection<HrSkill> HrSkills { get; set; } = new List<HrSkill>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();
}
