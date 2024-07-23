using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Report Layout
/// </summary>
public partial class ReportLayout
{
    public int Id { get; set; }

    /// <summary>
    /// Document Template
    /// </summary>
    public int ViewId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Preview image src
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Preview pdf src
    /// </summary>
    public string? Pdf { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<BaseDocumentLayout> BaseDocumentLayouts { get; set; } = new List<BaseDocumentLayout>();

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView View { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
