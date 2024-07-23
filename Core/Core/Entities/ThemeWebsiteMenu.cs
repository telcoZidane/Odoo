using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website Theme Menu
/// </summary>
public partial class ThemeWebsiteMenu
{
    public int Id { get; set; }

    /// <summary>
    /// Page
    /// </summary>
    public int? PageId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Parent
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
    /// Url
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Mega Menu Classes
    /// </summary>
    public string? MegaMenuClasses { get; set; }

    /// <summary>
    /// Name
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
    /// Use Main Menu As Parent
    /// </summary>
    public bool? UseMainMenuAsParent { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ThemeWebsiteMenu> InverseParent { get; set; } = new List<ThemeWebsiteMenu>();

    public virtual ThemeWebsitePage? Page { get; set; }

    public virtual ThemeWebsiteMenu? Parent { get; set; }

    public virtual ICollection<WebsiteMenu> WebsiteMenus { get; set; } = new List<WebsiteMenu>();

    public virtual ResUser? WriteU { get; set; }
}
