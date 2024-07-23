using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Email composition wizard
/// </summary>
public partial class MailComposeMessage
{
    public int Id { get; set; }

    /// <summary>
    /// Use template
    /// </summary>
    public int? TemplateId { get; set; }

    /// <summary>
    /// Parent Message
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Author
    /// </summary>
    public int? AuthorId { get; set; }

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
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Subject
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// Email Notification Layout
    /// </summary>
    public string? EmailLayoutXmlid { get; set; }

    /// <summary>
    /// From
    /// </summary>
    public string? EmailFrom { get; set; }

    /// <summary>
    /// Composition mode
    /// </summary>
    public string? CompositionMode { get; set; }

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
    /// Reply To
    /// </summary>
    public string? ReplyTo { get; set; }

    /// <summary>
    /// Contents
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// Active domain
    /// </summary>
    public string? ActiveDomain { get; set; }

    /// <summary>
    /// Email Add Signature
    /// </summary>
    public bool? EmailAddSignature { get; set; }

    /// <summary>
    /// Use active domain
    /// </summary>
    public bool? UseActiveDomain { get; set; }

    /// <summary>
    /// Log as Internal Note
    /// </summary>
    public bool? IsLog { get; set; }

    /// <summary>
    /// Notify followers
    /// </summary>
    public bool? Notify { get; set; }

    /// <summary>
    /// Considers answers as new thread
    /// </summary>
    public bool? ReplyToForceNew { get; set; }

    /// <summary>
    /// Delete Emails
    /// </summary>
    public bool? AutoDelete { get; set; }

    /// <summary>
    /// Delete Message Copy
    /// </summary>
    public bool? AutoDeleteMessage { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Mass Mailing
    /// </summary>
    public int? MassMailingId { get; set; }

    /// <summary>
    /// Mass Mailing Campaign
    /// </summary>
    public int? CampaignId { get; set; }

    /// <summary>
    /// Mass Mailing Name
    /// </summary>
    public string? MassMailingName { get; set; }

    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSends { get; set; } = new List<AccountInvoiceSend>();

    public virtual ResPartner? Author { get; set; }

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailActivityType? MailActivityType { get; set; }

    public virtual IrMailServer? MailServer { get; set; }

    public virtual MailingMailing? MassMailing { get; set; }

    public virtual MailMessage? Parent { get; set; }

    public virtual MailMessageSubtype? Subtype { get; set; }

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrAttachment> Attachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<MailingList> MailingLists { get; set; } = new List<MailingList>();

    public virtual ICollection<ResPartner> Partners { get; set; } = new List<ResPartner>();
}
