using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Outgoing SMS
/// </summary>
public partial class SmsSm
{
    public int Id { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Mail Message
    /// </summary>
    public int? MailMessageId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Number
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// SMS Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Failure Type
    /// </summary>
    public string? FailureType { get; set; }

    /// <summary>
    /// Body
    /// </summary>
    public string? Body { get; set; }

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

    public virtual MailMessage? MailMessage { get; set; }

    public virtual ICollection<MailNotification> MailNotifications { get; set; } = new List<MailNotification>();

    public virtual MailingMailing? Mailing { get; set; }

    public virtual ICollection<MailingTrace> MailingTraces { get; set; } = new List<MailingTrace>();

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
