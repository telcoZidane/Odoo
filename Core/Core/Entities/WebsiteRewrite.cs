using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website rewrite
/// </summary>
public partial class WebsiteRewrite
{
    public int Id { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Route
    /// </summary>
    public int? RouteId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

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
    /// URL from
    /// </summary>
    public string? UrlFrom { get; set; }

    /// <summary>
    /// URL to
    /// </summary>
    public string? UrlTo { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public string? RedirectType { get; set; }

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

    public virtual WebsiteRoute? Route { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
