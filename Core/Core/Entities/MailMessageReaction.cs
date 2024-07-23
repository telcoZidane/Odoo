using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Message Reaction
/// </summary>
public partial class MailMessageReaction
{
    public int Id { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public int MessageId { get; set; }

    /// <summary>
    /// Reacting Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Reacting Guest
    /// </summary>
    public int? GuestId { get; set; }

    /// <summary>
    /// Content
    /// </summary>
    public string Content { get; set; } = null!;

    public virtual MailGuest? Guest { get; set; }

    public virtual MailMessage Message { get; set; } = null!;

    public virtual ResPartner? Partner { get; set; }
}
