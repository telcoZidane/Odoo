using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Registration Mail Scheduler
/// </summary>
public partial class EventMailRegistration
{
    public int Id { get; set; }

    /// <summary>
    /// Mail Scheduler
    /// </summary>
    public int SchedulerId { get; set; }

    /// <summary>
    /// Attendee
    /// </summary>
    public int RegistrationId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Mail Sent
    /// </summary>
    public bool? MailSent { get; set; }

    /// <summary>
    /// Scheduled Time
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

    public virtual EventRegistration Registration { get; set; } = null!;

    public virtual EventMail Scheduler { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
