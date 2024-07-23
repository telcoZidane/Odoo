using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Outgoing Mails
/// </summary>
public partial class MailMail
{
    public int Id { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public int MailMessageId { get; set; }

    /// <summary>
    /// Inbound Mail Server
    /// </summary>
    public int? FetchmailServerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Cc
    /// </summary>
    public string? EmailCc { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Failure type
    /// </summary>
    public string? FailureType { get; set; }

    /// <summary>
    /// Text Contents
    /// </summary>
    public string? BodyHtml { get; set; }

    /// <summary>
    /// References
    /// </summary>
    public string? References { get; set; }

    /// <summary>
    /// Headers
    /// </summary>
    public string? Headers { get; set; }

    /// <summary>
    /// To
    /// </summary>
    public string? EmailTo { get; set; }

    /// <summary>
    /// Failure Reason
    /// </summary>
    public string? FailureReason { get; set; }

    /// <summary>
    /// Notification Email
    /// </summary>
    public bool? IsNotification { get; set; }

    /// <summary>
    /// Auto Delete
    /// </summary>
    public bool? AutoDelete { get; set; }

    /// <summary>
    /// To Delete
    /// </summary>
    public bool? ToDelete { get; set; }

    /// <summary>
    /// Scheduled Send Date
    /// </summary>
    public DateTime? ScheduledDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Mass Mailing
    /// </summary>
    public int? MailingId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual FetchmailServer? FetchmailServer { get; set; }

    public virtual MailMessage MailMessage { get; set; } = null!;

    public virtual ICollection<MailNotification> MailNotifications { get; set; } = new List<MailNotification>();

    public virtual MailingMailing? Mailing { get; set; }

    public virtual ICollection<MailingTrace> MailingTraces { get; set; } = new List<MailingTrace>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();
}
