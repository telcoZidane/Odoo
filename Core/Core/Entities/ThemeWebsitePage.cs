using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website Theme Page
/// </summary>
public partial class ThemeWebsitePage
{
    public int Id { get; set; }

    /// <summary>
    /// View
    /// </summary>
    public int ViewId { get; set; }

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
    /// Header Color
    /// </summary>
    public string? HeaderColor { get; set; }

    /// <summary>
    /// Page Indexed
    /// </summary>
    public bool? WebsiteIndexed { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Header Overlay
    /// </summary>
    public bool? HeaderOverlay { get; set; }

    /// <summary>
    /// Header Visible
    /// </summary>
    public bool? HeaderVisible { get; set; }

    /// <summary>
    /// Footer Visible
    /// </summary>
    public bool? FooterVisible { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ThemeWebsiteMenu> ThemeWebsiteMenus { get; set; } = new List<ThemeWebsiteMenu>();

    public virtual ThemeIrUiView View { get; set; } = null!;

    public virtual ICollection<WebsitePage> WebsitePages { get; set; } = new List<WebsitePage>();

    public virtual ResUser? WriteU { get; set; }
}
