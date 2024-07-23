using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Chatbot Script
/// </summary>
public partial class ChatbotScript
{
    public int Id { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public int SourceId { get; set; }

    /// <summary>
    /// Bot Operator
    /// </summary>
    public int OperatorPartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<ChatbotScriptStep> ChatbotScriptSteps { get; set; } = new List<ChatbotScriptStep>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ImLivechatChannelRule> ImLivechatChannelRules { get; set; } = new List<ImLivechatChannelRule>();

    public virtual ResPartner OperatorPartner { get; set; } = null!;

    public virtual UtmSource Source { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
