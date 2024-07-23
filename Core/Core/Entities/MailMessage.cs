using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Message
/// </summary>
public partial class MailMessage
{
    public int Id { get; set; }

    /// <summary>
    /// Parent Message
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Related Document ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Subtype
    /// </summary>
    public int? SubtypeId { get; set; }

    /// <summary>
    /// Mail Activity Type
    /// </summary>
    public int? MailActivityTypeId { get; set; }

    /// <summary>
    /// Author
    /// </summary>
    public int? AuthorId { get; set; }

    /// <summary>
    /// Guest
    /// </summary>
    public int? AuthorGuestId { get; set; }

    /// <summary>
    /// Outgoing mail server
    /// </summary>
    public int? MailServerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Subject
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Message Record Name
    /// </summary>
    public string? RecordName { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string MessageType { get; set; } = null!;

    /// <summary>
    /// From
    /// </summary>
    public string? EmailFrom { get; set; }

    /// <summary>
    /// Message-Id
    /// </summary>
    public string? MessageId { get; set; }

    /// <summary>
    /// Reply-To
    /// </summary>
    public string? ReplyTo { get; set; }

    /// <summary>
    /// Layout
    /// </summary>
    public string? EmailLayoutXmlid { get; set; }

    /// <summary>
    /// Contents
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// Employee Only
    /// </summary>
    public bool? IsInternal { get; set; }

    /// <summary>
    /// No threading for answers
    /// </summary>
    public bool? ReplyToForceNew { get; set; }

    /// <summary>
    /// Email Add Signature
    /// </summary>
    public bool? EmailAddSignature { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual MailGuest? AuthorGuest { get; set; }

    public virtual ChatbotMessage? ChatbotMessage { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailMessage> InverseParent { get; set; } = new List<MailMessage>();

    public virtual MailActivityType? MailActivityType { get; set; }

    public virtual ICollection<MailChannelMember> MailChannelMemberFetchedMessages { get; set; } = new List<MailChannelMember>();

    public virtual ICollection<MailChannelMember> MailChannelMemberSeenMessages { get; set; } = new List<MailChannelMember>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailLinkPreview> MailLinkPreviews { get; set; } = new List<MailLinkPreview>();

    public virtual ICollection<MailMail> MailMails { get; set; } = new List<MailMail>();

    public virtual ICollection<MailMessageReaction> MailMessageReactions { get; set; } = new List<MailMessageReaction>();

    public virtual ICollection<MailMessageSchedule> MailMessageSchedules { get; set; } = new List<MailMessageSchedule>();

    public virtual ICollection<MailNotification> MailNotifications { get; set; } = new List<MailNotification>();

    public virtual ICollection<MailResendMessage> MailResendMessages { get; set; } = new List<MailResendMessage>();

    public virtual IrMailServer? MailServer { get; set; }

    public virtual ICollection<MailTrackingValue> MailTrackingValues { get; set; } = new List<MailTrackingValue>();

    public virtual MailMessage? Parent { get; set; }

    public virtual ICollection<RatingRating> RatingRatings { get; set; } = new List<RatingRating>();

    public virtual ICollection<SmsResend> SmsResends { get; set; } = new List<SmsResend>();

    public virtual ICollection<SmsSm> SmsSms { get; set; } = new List<SmsSm>();

    public virtual ICollection<SnailmailLetterFormatError> SnailmailLetterFormatErrors { get; set; } = new List<SnailmailLetterFormatError>();

    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; set; } = new List<SnailmailLetter>();

    public virtual MailMessageSubtype? Subtype { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrAttachment> Attachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResPartner> ResPartnersNavigation { get; set; } = new List<ResPartner>();
}
