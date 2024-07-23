using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mass Mailing
/// </summary>
public partial class MailingMailing
{
    public int Id { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public int SourceId { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// UTM Campaign
    /// </summary>
    public int? CampaignId { get; set; }

    /// <summary>
    /// Medium
    /// </summary>
    public int? MediumId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Recipients Model
    /// </summary>
    public int MailingModelId { get; set; }

    /// <summary>
    /// Mail Server
    /// </summary>
    public int? MailServerId { get; set; }

    /// <summary>
    /// Favorite Filter
    /// </summary>
    public int? MailingFilterId { get; set; }

    /// <summary>
    /// A/B Testing percentage
    /// </summary>
    public int? AbTestingPc { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Subject
    /// </summary>
    public string Subject { get; set; } = null!;

    /// <summary>
    /// Preview
    /// </summary>
    public string? Preview { get; set; }

    /// <summary>
    /// Send From
    /// </summary>
    public string EmailFrom { get; set; } = null!;

    /// <summary>
    /// Schedule
    /// </summary>
    public string ScheduleType { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Mailing Type
    /// </summary>
    public string MailingType { get; set; } = null!;

    /// <summary>
    /// Reply-To Mode
    /// </summary>
    public string? ReplyToMode { get; set; }

    /// <summary>
    /// Reply To
    /// </summary>
    public string? ReplyTo { get; set; }

    /// <summary>
    /// Domain
    /// </summary>
    public string? MailingDomain { get; set; }

    /// <summary>
    /// Body
    /// </summary>
    public string? BodyArch { get; set; }

    /// <summary>
    /// Body converted to be sent by mail
    /// </summary>
    public string? BodyHtml { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Favorite
    /// </summary>
    public bool? Favorite { get; set; }

    /// <summary>
    /// Keep Archives
    /// </summary>
    public bool? KeepArchives { get; set; }

    /// <summary>
    /// A/B Testing Campaign Finished
    /// </summary>
    public bool? AbTestingCompleted { get; set; }

    /// <summary>
    /// Allow A/B Testing
    /// </summary>
    public bool? AbTestingEnabled { get; set; }

    /// <summary>
    /// KPI mail required
    /// </summary>
    public bool? KpiMailRequired { get; set; }

    /// <summary>
    /// Favorite Date
    /// </summary>
    public DateTime? FavoriteDate { get; set; }

    /// <summary>
    /// Sent Date
    /// </summary>
    public DateTime? SentDate { get; set; }

    /// <summary>
    /// Scheduled for
    /// </summary>
    public DateTime? ScheduleDate { get; set; }

    /// <summary>
    /// Calendar Date
    /// </summary>
    public DateTime? CalendarDate { get; set; }

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

    /// <summary>
    /// SMS Body
    /// </summary>
    public string? BodyPlaintext { get; set; }

    /// <summary>
    /// Send Directly
    /// </summary>
    public bool? SmsForceSend { get; set; }

    /// <summary>
    /// Include opt-out link
    /// </summary>
    public bool? SmsAllowUnsubscribe { get; set; }

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<LinkTrackerClick> LinkTrackerClicks { get; set; } = new List<LinkTrackerClick>();

    public virtual ICollection<LinkTracker> LinkTrackers { get; set; } = new List<LinkTracker>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailMail> MailMails { get; set; } = new List<MailMail>();

    public virtual IrMailServer? MailServer { get; set; }

    public virtual MailingFilter? MailingFilter { get; set; }

    public virtual ICollection<MailingMailingScheduleDate> MailingMailingScheduleDates { get; set; } = new List<MailingMailingScheduleDate>();

    public virtual ICollection<MailingMailingTest> MailingMailingTests { get; set; } = new List<MailingMailingTest>();

    public virtual IrModel MailingModel { get; set; } = null!;

    public virtual ICollection<MailingSmsTest> MailingSmsTests { get; set; } = new List<MailingSmsTest>();

    public virtual ICollection<MailingTrace> MailingTraces { get; set; } = new List<MailingTrace>();

    public virtual UtmMedium? Medium { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<SmsComposer> SmsComposers { get; set; } = new List<SmsComposer>();

    public virtual ICollection<SmsSm> SmsSms { get; set; } = new List<SmsSm>();

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual UtmSource Source { get; set; } = null!;

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrAttachment> Attachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<MailingList> MailingLists { get; set; } = new List<MailingList>();
}
