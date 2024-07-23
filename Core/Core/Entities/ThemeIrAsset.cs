using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Theme Asset
/// </summary>
public partial class ThemeIrAsset
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
    /// Key
    /// </summary>
    public string? Key { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Bundle
    /// </summary>
    public string Bundle { get; set; } = null!;

    /// <summary>
    /// Directive
    /// </summary>
    public string? Directive { get; set; }

    /// <summary>
    /// Path
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// Target
    /// </summary>
    public string? Target { get; set; }

    /// <summary>
    /// Active
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

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrAsset> IrAssets { get; set; } = new List<IrAsset>();

    public virtual ResUser? WriteU { get; set; }
}
