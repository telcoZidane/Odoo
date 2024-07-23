using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Page
/// </summary>
public partial class WebsitePage
{
    public int Id { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

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
    /// Theme Template
    /// </summary>
    public int? ThemeTemplateId { get; set; }

    /// <summary>
    /// Page URL
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Header Color
    /// </summary>
    public string? HeaderColor { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Is Indexed
    /// </summary>
    public bool? WebsiteIndexed { get; set; }

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
    /// Publishing Date
    /// </summary>
    public DateTime? DatePublish { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ThemeWebsitePage? ThemeTemplate { get; set; }

    public virtual IrUiView View { get; set; } = null!;

    public virtual Website? Website { get; set; }

    public virtual ICollection<WebsiteMenu> WebsiteMenus { get; set; } = new List<WebsiteMenu>();

    public virtual ICollection<WebsiteTrack> WebsiteTracks { get; set; } = new List<WebsiteTrack>();

    public virtual ResUser? WriteU { get; set; }
}
