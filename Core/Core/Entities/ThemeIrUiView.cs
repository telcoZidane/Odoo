using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Theme UI View
/// </summary>
public partial class ThemeIrUiView
{
    public int Id { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public int Priority { get; set; }

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
    /// Key
    /// </summary>
    public string? Key { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Mode
    /// </summary>
    public string? Mode { get; set; }

    /// <summary>
    /// Arch Fs
    /// </summary>
    public string? ArchFs { get; set; }

    /// <summary>
    /// Inherit
    /// </summary>
    public string? InheritId { get; set; }

    /// <summary>
    /// Arch
    /// </summary>
    public string? Arch { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Customize Show
    /// </summary>
    public bool? CustomizeShow { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrUiView> IrUiViews { get; set; } = new List<IrUiView>();

    public virtual ICollection<ThemeWebsitePage> ThemeWebsitePages { get; set; } = new List<ThemeWebsitePage>();

    public virtual ResUser? WriteU { get; set; }
}
