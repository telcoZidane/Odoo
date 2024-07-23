using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Store link preview data
/// </summary>
public partial class MailLinkPreview
{
    public int Id { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public int MessageId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// URL
    /// </summary>
    public string SourceUrl { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string? OgType { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public string? OgTitle { get; set; }

    /// <summary>
    /// Image
    /// </summary>
    public string? OgImage { get; set; }

    /// <summary>
    /// MIME type
    /// </summary>
    public string? OgMimetype { get; set; }

    /// <summary>
    /// Image MIME type
    /// </summary>
    public string? ImageMimetype { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? OgDescription { get; set; }

    /// <summary>
    /// Create Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage Message { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
