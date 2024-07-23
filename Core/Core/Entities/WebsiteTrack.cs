using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Visited Pages
/// </summary>
public partial class WebsiteTrack
{
    public int Id { get; set; }

    /// <summary>
    /// Visitor
    /// </summary>
    public int VisitorId { get; set; }

    /// <summary>
    /// Page
    /// </summary>
    public int? PageId { get; set; }

    /// <summary>
    /// Url
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Visit Date
    /// </summary>
    public DateTime VisitDatetime { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    public virtual WebsitePage? Page { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual WebsiteVisitor Visitor { get; set; } = null!;
}
