using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Email Template Preview
/// </summary>
public partial class MailTemplatePreview
{
    public int Id { get; set; }

    /// <summary>
    /// Related Mail Template
    /// </summary>
    public int MailTemplateId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Record
    /// </summary>
    public string? ResourceRef { get; set; }

    /// <summary>
    /// Template Preview Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Error Message
    /// </summary>
    public string? ErrorMsg { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate MailTemplate { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
