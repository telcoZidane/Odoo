using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Calendar Attendee Information
/// </summary>
public partial class CalendarAttendee
{
    public int Id { get; set; }

    /// <summary>
    /// Meeting linked
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// Attendee
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Common name
    /// </summary>
    public string? CommonName { get; set; }

    /// <summary>
    /// Invitation Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Available/Busy
    /// </summary>
    public string? Availability { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CalendarEvent Event { get; set; } = null!;

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
