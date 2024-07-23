using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Livechat Channel Rules
/// </summary>
public partial class ImLivechatChannelRule
{
    public int Id { get; set; }

    /// <summary>
    /// Open automatically timer
    /// </summary>
    public int? AutoPopupTimer { get; set; }

    /// <summary>
    /// Chatbot
    /// </summary>
    public int? ChatbotScriptId { get; set; }

    /// <summary>
    /// Channel
    /// </summary>
    public int? ChannelId { get; set; }

    /// <summary>
    /// Matching order
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// URL Regex
    /// </summary>
    public string? RegexUrl { get; set; }

    /// <summary>
    /// Live Chat Button
    /// </summary>
    public string Action { get; set; } = null!;

    /// <summary>
    /// Enabled only if no operator
    /// </summary>
    public bool? ChatbotOnlyIfNoOperator { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ImLivechatChannel? Channel { get; set; }

    public virtual ChatbotScript? ChatbotScript { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResCountry> Countries { get; set; } = new List<ResCountry>();
}
