using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Guest
/// </summary>
public partial class MailGuest
{
    public int Id { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Access Token
    /// </summary>
    public string AccessToken { get; set; } = null!;

    /// <summary>
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Timezone
    /// </summary>
    public string? Timezone { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual BusPresence? BusPresence { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailChannelMember> MailChannelMembers { get; set; } = new List<MailChannelMember>();

    public virtual ICollection<MailMessageReaction> MailMessageReactions { get; set; } = new List<MailMessageReaction>();

    public virtual ICollection<MailMessage> MailMessages { get; set; } = new List<MailMessage>();

    public virtual ResUser? WriteU { get; set; }
}
