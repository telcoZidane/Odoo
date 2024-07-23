using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Chatbot Script Answer
/// </summary>
public partial class ChatbotScriptAnswer
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Script Step
    /// </summary>
    public int ScriptStepId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Redirect Link
    /// </summary>
    public string? RedirectLink { get; set; }

    /// <summary>
    /// Answer
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<ChatbotMessage> ChatbotMessages { get; set; } = new List<ChatbotMessage>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ChatbotScriptStep ScriptStep { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ChatbotScriptStep> ChatbotScriptSteps { get; set; } = new List<ChatbotScriptStep>();
}
