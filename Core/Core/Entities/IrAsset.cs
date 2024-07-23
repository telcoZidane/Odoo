using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Asset
/// </summary>
public partial class IrAsset
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Bundle name
    /// </summary>
    public string Bundle { get; set; } = null!;

    /// <summary>
    /// Directive
    /// </summary>
    public string? Directive { get; set; }

    /// <summary>
    /// Path (or glob pattern)
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// Target
    /// </summary>
    public string? Target { get; set; }

    /// <summary>
    /// active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Theme Template
    /// </summary>
    public int? ThemeTemplateId { get; set; }

    /// <summary>
    /// Key
    /// </summary>
    public string? Key { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ThemeIrAsset? ThemeTemplate { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
