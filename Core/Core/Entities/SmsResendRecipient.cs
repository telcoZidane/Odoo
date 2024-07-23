using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Resend Notification
/// </summary>
public partial class SmsResendRecipient
{
    public int Id { get; set; }

    /// <summary>
    /// Sms Resend
    /// </summary>
    public int SmsResendId { get; set; }

    /// <summary>
    /// Notification
    /// </summary>
    public int NotificationId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Recipient Name
    /// </summary>
    public string? PartnerName { get; set; }

    /// <summary>
    /// Phone Number
    /// </summary>
    public string? SmsNumber { get; set; }

    /// <summary>
    /// Try Again
    /// </summary>
    public bool? Resend { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailNotification Notification { get; set; } = null!;

    public virtual SmsResend SmsResend { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
