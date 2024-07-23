using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// SMS Resend
/// </summary>
public partial class SmsResend
{
    public int Id { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public int MailMessageId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage MailMessage { get; set; } = null!;

    public virtual ICollection<SmsResendRecipient> SmsResendRecipients { get; set; } = new List<SmsResendRecipient>();

    public virtual ResUser? WriteU { get; set; }
}
