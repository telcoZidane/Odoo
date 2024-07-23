using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Listeners of a Channel
/// </summary>
public partial class MailChannelMember
{
    public int Id { get; set; }

    /// <summary>
    /// Recipient
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Guest
    /// </summary>
    public int? GuestId { get; set; }

    /// <summary>
    /// Channel
    /// </summary>
    public int ChannelId { get; set; }

    /// <summary>
    /// Last Fetched
    /// </summary>
    public int? FetchedMessageId { get; set; }

    /// <summary>
    /// Last Seen
    /// </summary>
    public int? SeenMessageId { get; set; }

    /// <summary>
    /// Ringing session
    /// </summary>
    public int? RtcInvitingSessionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Custom channel name
    /// </summary>
    public string? CustomChannelName { get; set; }

    /// <summary>
    /// Conversation Fold State
    /// </summary>
    public string? FoldState { get; set; }

    /// <summary>
    /// Conversation is minimized
    /// </summary>
    public bool? IsMinimized { get; set; }

    /// <summary>
    /// Is pinned on the interface
    /// </summary>
    public bool? IsPinned { get; set; }

    /// <summary>
    /// Last Interest
    /// </summary>
    public DateTime? LastInterestDt { get; set; }

    /// <summary>
    /// Last seen date
    /// </summary>
    public DateTime? LastSeenDt { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual MailChannel Channel { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? FetchedMessage { get; set; }

    public virtual MailGuest? Guest { get; set; }

    public virtual MailChannelRtcSession? MailChannelRtcSession { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual MailChannelRtcSession? RtcInvitingSession { get; set; }

    public virtual MailMessage? SeenMessage { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
