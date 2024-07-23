using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Livechat Channel
/// </summary>
public partial class ImLivechatChannel
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Channel Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Text of the Button
    /// </summary>
    public string? ButtonText { get; set; }

    /// <summary>
    /// Welcome Message
    /// </summary>
    public string? DefaultMessage { get; set; }

    /// <summary>
    /// Chat Input Placeholder
    /// </summary>
    public string? InputPlaceholder { get; set; }

    /// <summary>
    /// Header Background Color
    /// </summary>
    public string? HeaderBackgroundColor { get; set; }

    /// <summary>
    /// Title Color
    /// </summary>
    public string? TitleColor { get; set; }

    /// <summary>
    /// Button Background Color
    /// </summary>
    public string? ButtonBackgroundColor { get; set; }

    /// <summary>
    /// Button Text Color
    /// </summary>
    public string? ButtonTextColor { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Website description
    /// </summary>
    public string? WebsiteDescription { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ImLivechatChannelRule> ImLivechatChannelRules { get; set; } = new List<ImLivechatChannelRule>();

    public virtual ICollection<MailChannel> MailChannels { get; set; } = new List<MailChannel>();

    public virtual ICollection<Website> Websites { get; set; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> Users { get; set; } = new List<ResUser>();
}
