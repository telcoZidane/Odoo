using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Alarm
/// </summary>
public partial class CalendarAlarm
{
    public int Id { get; set; }

    /// <summary>
    /// Remind Before
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// Duration in minutes
    /// </summary>
    public int? DurationMinutes { get; set; }

    /// <summary>
    /// Email Template
    /// </summary>
    public int? MailTemplateId { get; set; }

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
    public string AlarmType { get; set; } = null!;

    /// <summary>
    /// Unit
    /// </summary>
    public string Interval { get; set; } = null!;

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Additional Message
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
    /// SMS Template
    /// </summary>
    public int? SmsTemplateId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();
}
