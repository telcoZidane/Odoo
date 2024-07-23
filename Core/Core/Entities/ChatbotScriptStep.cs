using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Chatbot Script Step
/// </summary>
public partial class ChatbotScriptStep
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Chatbot
    /// </summary>
    public int ChatbotScriptId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Step Type
    /// </summary>
    public string StepType { get; set; } = null!;

    /// <summary>
    /// Message
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? CrmTeamId { get; set; }

    public virtual ICollection<ChatbotMessage> ChatbotMessages { get; set; } = new List<ChatbotMessage>();

    public virtual ChatbotScript ChatbotScript { get; set; } = null!;

    public virtual ICollection<ChatbotScriptAnswer> ChatbotScriptAnswers { get; set; } = new List<ChatbotScriptAnswer>();

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? CrmTeam { get; set; }

    public virtual ICollection<MailChannel> MailChannels { get; set; } = new List<MailChannel>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ChatbotScriptAnswer> ChatbotScriptAnswersNavigation { get; set; } = new List<ChatbotScriptAnswer>();
}
