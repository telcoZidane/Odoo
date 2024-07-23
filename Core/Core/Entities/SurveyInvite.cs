using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Survey Invitation Wizard
/// </summary>
public partial class SurveyInvite
{
    public int Id { get; set; }

    /// <summary>
    /// Mail Template
    /// </summary>
    public int? TemplateId { get; set; }

    /// <summary>
    /// Author
    /// </summary>
    public int? AuthorId { get; set; }

    /// <summary>
    /// Outgoing mail server
    /// </summary>
    public int? MailServerId { get; set; }

    /// <summary>
    /// Survey
    /// </summary>
    public int SurveyId { get; set; }

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
    /// From
    /// </summary>
    public string? EmailFrom { get; set; }

    /// <summary>
    /// Handle existing
    /// </summary>
    public string ExistingMode { get; set; } = null!;

    /// <summary>
    /// Contents
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// Additional emails
    /// </summary>
    public string? Emails { get; set; }

    /// <summary>
    /// Answer deadline
    /// </summary>
    public DateTime? Deadline { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrMailServer? MailServer { get; set; }

    public virtual SurveySurvey Survey { get; set; } = null!;

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrAttachment> Attachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<ResPartner> Partners { get; set; } = new List<ResPartner>();
}
