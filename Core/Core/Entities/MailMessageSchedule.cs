using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Scheduled Messages
/// </summary>
public partial class MailMessageSchedule
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
    /// Notification Parameter
    /// </summary>
    public string? NotificationParameters { get; set; }

    /// <summary>
    /// Scheduled Send Date
    /// </summary>
    public DateTime ScheduledDatetime { get; set; }

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

    public virtual ResUser? WriteU { get; set; }
}
