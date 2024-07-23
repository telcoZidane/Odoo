using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Custom View
/// </summary>
public partial class IrUiViewCustom
{
    public int Id { get; set; }

    /// <summary>
    /// Original View
    /// </summary>
    public int RefId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// View Architecture
    /// </summary>
    public string Arch { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView Ref { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
