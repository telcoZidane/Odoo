using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Automated Mailing
/// </summary>
public partial class EventMail
{
    public int Id { get; set; }

    /// <summary>
    /// Event
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// Display order
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Interval
    /// </summary>
    public int? IntervalNbr { get; set; }

    /// <summary>
    /// # Sent
    /// </summary>
    public int? MailCountDone { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Send
    /// </summary>
    public string NotificationType { get; set; } = null!;

    /// <summary>
    /// Unit
    /// </summary>
    public string IntervalUnit { get; set; } = null!;

    /// <summary>
    /// Trigger 
    /// </summary>
    public string IntervalType { get; set; } = null!;

    /// <summary>
    /// Template
    /// </summary>
    public string TemplateRef { get; set; } = null!;

    /// <summary>
    /// Sent
    /// </summary>
    public bool? MailDone { get; set; }

    /// <summary>
    /// Schedule Date
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

    public virtual ResUser? CreateU { get; set; }

    public virtual EventEvent Event { get; set; } = null!;

    public virtual ICollection<EventMailRegistration> EventMailRegistrations { get; set; } = new List<EventMailRegistration>();

    public virtual ResUser? WriteU { get; set; }
}
