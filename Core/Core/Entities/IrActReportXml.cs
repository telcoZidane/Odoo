using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class IrActReportXml
{
    public int Id { get; set; }

    public int? BindingModelId { get; set; }

    public int? CreateUid { get; set; }

    public int? WriteUid { get; set; }

    public string Type { get; set; } = null!;

    public string BindingType { get; set; } = null!;

    public string? BindingViewTypes { get; set; }

    public string Name { get; set; } = null!;

    public string? Help { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Paper Format
    /// </summary>
    public int? PaperformatId { get; set; }

    /// <summary>
    /// Model Name
    /// </summary>
    public string Model { get; set; } = null!;

    /// <summary>
    /// Report Type
    /// </summary>
    public string ReportType { get; set; } = null!;

    /// <summary>
    /// Template Name
    /// </summary>
    public string ReportName { get; set; } = null!;

    /// <summary>
    /// Report File
    /// </summary>
    public string? ReportFile { get; set; }

    /// <summary>
    /// Save as Attachment Prefix
    /// </summary>
    public string? Attachment { get; set; }

    /// <summary>
    /// Printed Report Name
    /// </summary>
    public string? PrintReportName { get; set; }

    /// <summary>
    /// On Multiple Doc.
    /// </summary>
    public bool? Multi { get; set; }

    /// <summary>
    /// Reload from Attachment
    /// </summary>
    public bool? AttachmentUse { get; set; }

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailTemplate> MailTemplates { get; set; } = new List<MailTemplate>();

    public virtual ReportPaperformat? Paperformat { get; set; }

    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; set; } = new List<SnailmailLetter>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResGroup> Gids { get; set; } = new List<ResGroup>();
}
