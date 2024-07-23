using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Email Templates
/// </summary>
public partial class MailTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Applies to
    /// </summary>
    public int? ModelId { get; set; }

    /// <summary>
    /// Optional report to print and attach
    /// </summary>
    public int? ReportTemplate { get; set; }

    /// <summary>
    /// Outgoing Mail Server
    /// </summary>
    public int? MailServerId { get; set; }

    /// <summary>
    /// Sidebar action
    /// </summary>
    public int? RefIrActWindow { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Template Filename
    /// </summary>
    public string? TemplateFs { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// From
    /// </summary>
    public string? EmailFrom { get; set; }

    /// <summary>
    /// To (Emails)
    /// </summary>
    public string? EmailTo { get; set; }

    /// <summary>
    /// To (Partners)
    /// </summary>
    public string? PartnerTo { get; set; }

    /// <summary>
    /// Cc
    /// </summary>
    public string? EmailCc { get; set; }

    /// <summary>
    /// Reply To
    /// </summary>
    public string? ReplyTo { get; set; }

    /// <summary>
    /// Scheduled Date
    /// </summary>
    public string? ScheduledDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Template description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Subject
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// Body
    /// </summary>
    public string? BodyHtml { get; set; }

    /// <summary>
    /// Report Filename
    /// </summary>
    public string? ReportName { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Default recipients
    /// </summary>
    public bool? UseDefaultTo { get; set; }

    /// <summary>
    /// Auto Delete
    /// </summary>
    public bool? AutoDelete { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSends { get; set; } = new List<AccountInvoiceSend>();

    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; set; } = new List<ApplicantGetRefuseReason>();

    public virtual ICollection<ApplicantSendMail> ApplicantSendMails { get; set; } = new List<ApplicantSendMail>();

    public virtual ICollection<CalendarAlarm> CalendarAlarms { get; set; } = new List<CalendarAlarm>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<GamificationChallenge> GamificationChallenges { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<HrApplicantRefuseReason> HrApplicantRefuseReasons { get; set; } = new List<HrApplicantRefuseReason>();

    public virtual ICollection<HrRecruitmentStage> HrRecruitmentStages { get; set; } = new List<HrRecruitmentStage>();

    public virtual ICollection<IrActServer> IrActServers { get; set; } = new List<IrActServer>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual IrMailServer? MailServer { get; set; }

    public virtual ICollection<MailTemplatePreview> MailTemplatePreviews { get; set; } = new List<MailTemplatePreview>();

    public virtual IrModel? ModelNavigation { get; set; }

    public virtual ICollection<ProjectProjectStage> ProjectProjectStages { get; set; } = new List<ProjectProjectStage>();

    public virtual ICollection<ProjectTaskType> ProjectTaskTypeMailTemplates { get; set; } = new List<ProjectTaskType>();

    public virtual ICollection<ProjectTaskType> ProjectTaskTypeRatingTemplates { get; set; } = new List<ProjectTaskType>();

    public virtual IrActWindow? RefIrActWindowNavigation { get; set; }

    public virtual IrActReportXml? ReportTemplateNavigation { get; set; }

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<SaleOrderCancel> SaleOrderCancels { get; set; } = new List<SaleOrderCancel>();

    public virtual ICollection<SaleOrderTemplate> SaleOrderTemplates { get; set; } = new List<SaleOrderTemplate>();

    public virtual ICollection<SlideChannel> SlideChannelCompletedTemplates { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SlideChannelInvite> SlideChannelInvites { get; set; } = new List<SlideChannelInvite>();

    public virtual ICollection<SlideChannel> SlideChannelPublishTemplates { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SlideChannel> SlideChannelShareChannelTemplates { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SlideChannel> SlideChannelShareSlideTemplates { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SurveyInvite> SurveyInvites { get; set; } = new List<SurveyInvite>();

    public virtual ICollection<SurveySurvey> SurveySurveys { get; set; } = new List<SurveySurvey>();

    public virtual ICollection<Website> Websites { get; set; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrAttachment> Attachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<MailActivityType> MailActivityTypes { get; set; } = new List<MailActivityType>();

    public virtual ICollection<MailTemplateReset> MailTemplateResets { get; set; } = new List<MailTemplateReset>();
}
