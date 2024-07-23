using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Activity
/// </summary>
public partial class MailActivity
{
    public int Id { get; set; }

    /// <summary>
    /// Document Model
    /// </summary>
    public int ResModelId { get; set; }

    /// <summary>
    /// Related Document ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Activity Type
    /// </summary>
    public int? ActivityTypeId { get; set; }

    /// <summary>
    /// Assigned to
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Requesting Partner
    /// </summary>
    public int? RequestPartnerId { get; set; }

    /// <summary>
    /// Recommended Activity Type
    /// </summary>
    public int? RecommendedActivityTypeId { get; set; }

    /// <summary>
    /// Previous Activity Type
    /// </summary>
    public int? PreviousActivityTypeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Document Name
    /// </summary>
    public string? ResName { get; set; }

    /// <summary>
    /// Summary
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// Due Date
    /// </summary>
    public DateOnly DateDeadline { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Automated activity
    /// </summary>
    public bool? Automated { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Calendar Meeting
    /// </summary>
    public int? CalendarEventId { get; set; }

    /// <summary>
    /// Related Note
    /// </summary>
    public int? NoteId { get; set; }

    public virtual MailActivityType? ActivityType { get; set; }

    public virtual CalendarEvent? CalendarEvent { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual NoteNote? NoteNavigation { get; set; }

    public virtual MailActivityType? PreviousActivityType { get; set; }

    public virtual MailActivityType? RecommendedActivityType { get; set; }

    public virtual ResPartner? RequestPartner { get; set; }

    public virtual IrModel ResModelNavigation { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
