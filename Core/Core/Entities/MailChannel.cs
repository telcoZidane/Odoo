using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Discussion Channel
/// </summary>
public partial class MailChannel
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Authorized Group
    /// </summary>
    public int? GroupPublicId { get; set; }

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
    /// Channel Type
    /// </summary>
    public string ChannelType { get; set; } = null!;

    /// <summary>
    /// Default Display Mode
    /// </summary>
    public string? DefaultDisplayMode { get; set; }

    /// <summary>
    /// UUID
    /// </summary>
    public string? Uuid { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

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

    /// <summary>
    /// Channel
    /// </summary>
    public int? LivechatChannelId { get; set; }

    /// <summary>
    /// Operator
    /// </summary>
    public int? LivechatOperatorId { get; set; }

    /// <summary>
    /// Chatbot Current Step
    /// </summary>
    public int? ChatbotCurrentStepId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Anonymous Name
    /// </summary>
    public string? AnonymousName { get; set; }

    /// <summary>
    /// Is livechat ongoing?
    /// </summary>
    public bool? LivechatActive { get; set; }

    /// <summary>
    /// Rating Last Value
    /// </summary>
    public double? RatingLastValue { get; set; }

    /// <summary>
    /// Visitor
    /// </summary>
    public int? LivechatVisitorId { get; set; }

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();

    public virtual ChatbotScriptStep? ChatbotCurrentStep { get; set; }

    public virtual ICollection<ChatbotMessage> ChatbotMessages { get; set; } = new List<ChatbotMessage>();

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<GamificationChallenge> GamificationChallenges { get; set; } = new List<GamificationChallenge>();

    public virtual ResGroup? GroupPublic { get; set; }

    public virtual ImLivechatChannel? LivechatChannel { get; set; }

    public virtual ResPartner? LivechatOperator { get; set; }

    public virtual WebsiteVisitor? LivechatVisitor { get; set; }

    public virtual ICollection<MailChannelMember> MailChannelMembers { get; set; } = new List<MailChannelMember>();

    public virtual ICollection<MailChannelRtcSession> MailChannelRtcSessions { get; set; } = new List<MailChannelRtcSession>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();

    public virtual ICollection<ResGroup> ResGroups { get; set; } = new List<ResGroup>();
}
