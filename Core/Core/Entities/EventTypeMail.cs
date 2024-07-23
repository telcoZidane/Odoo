using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mail Scheduling on Event Category
/// </summary>
public partial class EventTypeMail
{
    public int Id { get; set; }

    /// <summary>
    /// Event Type
    /// </summary>
    public int EventTypeId { get; set; }

    /// <summary>
    /// Interval
    /// </summary>
    public int? IntervalNbr { get; set; }

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
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual EventType EventType { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
