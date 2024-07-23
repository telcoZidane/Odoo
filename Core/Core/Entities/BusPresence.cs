using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// User Presence
/// </summary>
public partial class BusPresence
{
    public int Id { get; set; }

    /// <summary>
    /// Users
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// IM Status
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Last Poll
    /// </summary>
    public DateTime? LastPoll { get; set; }

    /// <summary>
    /// Last Presence
    /// </summary>
    public DateTime? LastPresence { get; set; }

    /// <summary>
    /// Guest
    /// </summary>
    public int? GuestId { get; set; }

    public virtual MailGuest? Guest { get; set; }

    public virtual ResUser? User { get; set; }
}
