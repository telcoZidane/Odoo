using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Electronic Document for an account.move
/// </summary>
public partial class AccountEdiDocument
{
    public int Id { get; set; }

    /// <summary>
    /// Move
    /// </summary>
    public int MoveId { get; set; }

    /// <summary>
    /// Edi Format
    /// </summary>
    public int EdiFormatId { get; set; }

    /// <summary>
    /// Attachment
    /// </summary>
    public int? AttachmentId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Blocking Level
    /// </summary>
    public string? BlockingLevel { get; set; }

    /// <summary>
    /// Error
    /// </summary>
    public string? Error { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual IrAttachment? Attachment { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountEdiFormat EdiFormat { get; set; } = null!;

    public virtual AccountMove Move { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
