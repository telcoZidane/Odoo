using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website Event Menu
/// </summary>
public partial class WebsiteEventMenu
{
    public int Id { get; set; }

    /// <summary>
    /// Menu
    /// </summary>
    public int? MenuId { get; set; }

    /// <summary>
    /// Event
    /// </summary>
    public int? EventId { get; set; }

    /// <summary>
    /// View
    /// </summary>
    public int? ViewId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Menu Type
    /// </summary>
    public string MenuType { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual EventEvent? Event { get; set; }

    public virtual WebsiteMenu? Menu { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
