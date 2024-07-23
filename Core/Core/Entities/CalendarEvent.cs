using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Calendar Event
/// </summary>
public partial class CalendarEvent
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Organizer
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Discuss Channel
    /// </summary>
    public int? VideocallChannelId { get; set; }

    /// <summary>
    /// Document ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Document Model
    /// </summary>
    public int? ResModelId { get; set; }

    /// <summary>
    /// Recurrence Rule
    /// </summary>
    public int? RecurrenceId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Meeting Subject
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Location
    /// </summary>
    public string? Location { get; set; }

    /// <summary>
    /// Meeting URL
    /// </summary>
    public string? VideocallLocation { get; set; }

    /// <summary>
    /// Invitation Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Privacy
    /// </summary>
    public string Privacy { get; set; } = null!;

    /// <summary>
    /// Show as
    /// </summary>
    public string ShowAs { get; set; } = null!;

    /// <summary>
    /// Document Model Name
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateOnly? StartDate { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? StopDate { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// All Day
    /// </summary>
    public bool? Allday { get; set; }

    /// <summary>
    /// Recurrent
    /// </summary>
    public bool? Recurrency { get; set; }

    /// <summary>
    /// Follow Recurrence
    /// </summary>
    public bool? FollowRecurrence { get; set; }

    /// <summary>
    /// Start
    /// </summary>
    public DateTime Start { get; set; }

    /// <summary>
    /// Stop
    /// </summary>
    public DateTime Stop { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Duration
    /// </summary>
    public double? Duration { get; set; }

    /// <summary>
    /// Opportunity
    /// </summary>
    public int? OpportunityId { get; set; }

    /// <summary>
    /// Applicant
    /// </summary>
    public int? ApplicantId { get; set; }

    public virtual HrApplicant? Applicant { get; set; }

    public virtual ICollection<CalendarAttendee> CalendarAttendees { get; set; } = new List<CalendarAttendee>();

    public virtual ICollection<CalendarRecurrence> CalendarRecurrences { get; set; } = new List<CalendarRecurrence>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();

    public virtual ICollection<MailActivity> MailActivities { get; set; } = new List<MailActivity>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual CrmLead? Opportunity { get; set; }

    public virtual CalendarRecurrence? Recurrence { get; set; }

    public virtual IrModel? ResModelNavigation { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual MailChannel? VideocallChannel { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CalendarAlarm> CalendarAlarms { get; set; } = new List<CalendarAlarm>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<CalendarEventType> Types { get; set; } = new List<CalendarEventType>();
}
