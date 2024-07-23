using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mailing Statistics
/// </summary>
public partial class MailingTrace
{
    public int Id { get; set; }

    /// <summary>
    /// Mail
    /// </summary>
    public int? MailMailId { get; set; }

    /// <summary>
    /// Mail ID (tech)
    /// </summary>
    public int? MailMailIdInt { get; set; }

    /// <summary>
    /// Document ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Mailing
    /// </summary>
    public int? MassMailingId { get; set; }

    /// <summary>
    /// Campaign
    /// </summary>
    public int? CampaignId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string TraceType { get; set; } = null!;

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Message-ID
    /// </summary>
    public string? MessageId { get; set; }

    /// <summary>
    /// Document model
    /// </summary>
    public string Model { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string? TraceStatus { get; set; }

    /// <summary>
    /// Failure type
    /// </summary>
    public string? FailureType { get; set; }

    /// <summary>
    /// Sent On
    /// </summary>
    public DateTime? SentDatetime { get; set; }

    /// <summary>
    /// Opened On
    /// </summary>
    public DateTime? OpenDatetime { get; set; }

    /// <summary>
    /// Replied On
    /// </summary>
    public DateTime? ReplyDatetime { get; set; }

    /// <summary>
    /// Clicked On
    /// </summary>
    public DateTime? LinksClickDatetime { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// SMS
    /// </summary>
    public int? SmsSmsId { get; set; }

    /// <summary>
    /// SMS ID (tech)
    /// </summary>
    public int? SmsSmsIdInt { get; set; }

    /// <summary>
    /// Number
    /// </summary>
    public string? SmsNumber { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string? SmsCode { get; set; }

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<LinkTrackerClick> LinkTrackerClicks { get; set; } = new List<LinkTrackerClick>();

    public virtual MailMail? MailMail { get; set; }

    public virtual MailingMailing? MassMailing { get; set; }

    public virtual SmsSm? SmsSms { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
