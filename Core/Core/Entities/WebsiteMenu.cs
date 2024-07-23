using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website Menu
/// </summary>
public partial class WebsiteMenu
{
    public int Id { get; set; }

    /// <summary>
    /// Related Page
    /// </summary>
    public int? PageId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

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
    /// Theme Template
    /// </summary>
    public int? ThemeTemplateId { get; set; }

    /// <summary>
    /// Url
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Parent Path
    /// </summary>
    public string? ParentPath { get; set; }

    /// <summary>
    /// Mega Menu Classes
    /// </summary>
    public string? MegaMenuClasses { get; set; }

    /// <summary>
    /// Menu
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Mega Menu Content
    /// </summary>
    public string? MegaMenuContent { get; set; }

    /// <summary>
    /// New Window
    /// </summary>
    public bool? NewWindow { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<EventEvent> EventEvents { get; set; } = new List<EventEvent>();

    public virtual ICollection<WebsiteMenu> InverseParent { get; set; } = new List<WebsiteMenu>();

    public virtual WebsitePage? Page { get; set; }

    public virtual WebsiteMenu? Parent { get; set; }

    public virtual ThemeWebsiteMenu? ThemeTemplate { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ICollection<WebsiteEventMenu> WebsiteEventMenus { get; set; } = new List<WebsiteEventMenu>();

    public virtual ResUser? WriteU { get; set; }
}
