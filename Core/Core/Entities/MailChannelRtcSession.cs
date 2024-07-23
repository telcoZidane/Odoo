using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mail RTC session
/// </summary>
public partial class MailChannelRtcSession
{
    public int Id { get; set; }

    /// <summary>
    /// Channel Member
    /// </summary>
    public int ChannelMemberId { get; set; }

    /// <summary>
    /// Channel
    /// </summary>
    public int? ChannelId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Is sharing the screen
    /// </summary>
    public bool? IsScreenSharingOn { get; set; }

    /// <summary>
    /// Is sending user video
    /// </summary>
    public bool? IsCameraOn { get; set; }

    /// <summary>
    /// Is microphone muted
    /// </summary>
    public bool? IsMuted { get; set; }

    /// <summary>
    /// Has disabled incoming sound
    /// </summary>
    public bool? IsDeaf { get; set; }

    /// <summary>
    /// Last Updated On
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    public virtual MailChannel? Channel { get; set; }

    public virtual MailChannelMember ChannelMember { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailChannelMember> MailChannelMembers { get; set; } = new List<MailChannelMember>();

    public virtual ResUser? WriteU { get; set; }
}
