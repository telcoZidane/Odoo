using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Template
/// </summary>
public partial class EventType
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Maximum Registrations
    /// </summary>
    public int? SeatsMax { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Timezone
    /// </summary>
    public string? DefaultTimezone { get; set; }

    /// <summary>
    /// Event Template
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Ticket Instructions
    /// </summary>
    public string? TicketInstructions { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Limited Seats
    /// </summary>
    public bool? HasSeatsLimitation { get; set; }

    /// <summary>
    /// Automatically Confirm Registrations
    /// </summary>
    public bool? AutoConfirm { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Display a dedicated menu on Website
    /// </summary>
    public bool? WebsiteMenu { get; set; }

    /// <summary>
    /// Community Menu
    /// </summary>
    public bool? CommunityMenu { get; set; }

    /// <summary>
    /// Extra Register Button
    /// </summary>
    public bool? MenuRegisterCta { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<EventEventTicket> EventEventTickets { get; set; } = new List<EventEventTicket>();

    public virtual ICollection<EventEvent> EventEvents { get; set; } = new List<EventEvent>();

    public virtual ICollection<EventTypeMail> EventTypeMails { get; set; } = new List<EventTypeMail>();

    public virtual ICollection<EventTypeTicket> EventTypeTickets { get; set; } = new List<EventTypeTicket>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<EventLeadRule> EventLeadRules { get; set; } = new List<EventLeadRule>();

    public virtual ICollection<EventTag> EventTags { get; set; } = new List<EventTag>();
}
