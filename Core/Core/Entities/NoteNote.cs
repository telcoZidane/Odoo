using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Note
/// </summary>
public partial class NoteNote
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Date done
    /// </summary>
    public DateOnly? DateDone { get; set; }

    /// <summary>
    /// Note Summary
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Note Content
    /// </summary>
    public string? Memo { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Open { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailActivity> MailActivities { get; set; } = new List<MailActivity>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<NoteStage> Stages { get; set; } = new List<NoteStage>();

    public virtual ICollection<NoteTag> Tags { get; set; } = new List<NoteTag>();
}
