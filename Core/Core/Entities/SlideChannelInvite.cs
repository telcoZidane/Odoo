using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Channel Invitation Wizard
/// </summary>
public partial class SlideChannelInvite
{
    public int Id { get; set; }

    /// <summary>
    /// Mail Template
    /// </summary>
    public int? TemplateId { get; set; }

    /// <summary>
    /// Slide channel
    /// </summary>
    public int ChannelId { get; set; }

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
    /// Contents
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual SlideChannel Channel { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrAttachment> IrAttachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();
}
