using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Menu
/// </summary>
public partial class IrUiMenu
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Parent Menu
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Parent Path
    /// </summary>
    public string? ParentPath { get; set; }

    /// <summary>
    /// Web Icon File
    /// </summary>
    public string? WebIcon { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// Menu
    /// </summary>
    public string Name { get; set; } = null!;

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

    public virtual ICollection<IrUiMenu> InverseParent { get; set; } = new List<IrUiMenu>();

    public virtual IrUiMenu? Parent { get; set; }

    public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreates { get; set; } = new List<WizardIrModelMenuCreate>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResGroup> Gids { get; set; } = new List<ResGroup>();
}
