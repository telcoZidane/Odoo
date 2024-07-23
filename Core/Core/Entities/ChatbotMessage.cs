using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Chatbot Message
/// </summary>
public partial class ChatbotMessage
{
    public int Id { get; set; }

    /// <summary>
    /// Related Mail Message
    /// </summary>
    public int MailMessageId { get; set; }

    /// <summary>
    /// Discussion Channel
    /// </summary>
    public int MailChannelId { get; set; }

    /// <summary>
    /// Chatbot Step
    /// </summary>
    public int ScriptStepId { get; set; }

    /// <summary>
    /// User&apos;s answer
    /// </summary>
    public int? UserScriptAnswerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// User&apos;s raw answer
    /// </summary>
    public string? UserRawAnswer { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailChannel MailChannel { get; set; } = null!;

    public virtual MailMessage MailMessage { get; set; } = null!;

    public virtual ChatbotScriptStep ScriptStep { get; set; } = null!;

    public virtual ChatbotScriptAnswer? UserScriptAnswer { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
