using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Message Notifications
/// </summary>
public partial class MailNotification
{
    public int Id { get; set; }

    /// <summary>
    /// Author
    /// </summary>
    public int? AuthorId { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public int MailMessageId { get; set; }

    /// <summary>
    /// Mail
    /// </summary>
    public int? MailMailId { get; set; }

    /// <summary>
    /// Recipient
    /// </summary>
    public int? ResPartnerId { get; set; }

    /// <summary>
    /// Notification Type
    /// </summary>
    public string NotificationType { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string? NotificationStatus { get; set; }

    /// <summary>
    /// Failure type
    /// </summary>
    public string? FailureType { get; set; }

    /// <summary>
    /// Failure reason
    /// </summary>
    public string? FailureReason { get; set; }

    /// <summary>
    /// Is Read
    /// </summary>
    public bool? IsRead { get; set; }

    /// <summary>
    /// Read Date
    /// </summary>
    public DateTime? ReadDate { get; set; }

    /// <summary>
    /// SMS
    /// </summary>
    public int? SmsId { get; set; }

    /// <summary>
    /// SMS Number
    /// </summary>
    public string? SmsNumber { get; set; }

    /// <summary>
    /// Snailmail Letter
    /// </summary>
    public int? LetterId { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual SnailmailLetter? Letter { get; set; }

    public virtual MailMail? MailMail { get; set; }

    public virtual MailMessage MailMessage { get; set; } = null!;

    public virtual ResPartner? ResPartner { get; set; }

    public virtual SmsSm? Sms { get; set; }

    public virtual ICollection<SmsResendRecipient> SmsResendRecipients { get; set; } = new List<SmsResendRecipient>();

    public virtual ICollection<MailResendMessage> MailResendMessages { get; set; } = new List<MailResendMessage>();
}
