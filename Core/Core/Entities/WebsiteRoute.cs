using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// All Website Route
/// </summary>
public partial class WebsiteRoute
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Route
    /// </summary>
    public string? Path { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<WebsiteRewrite> WebsiteRewrites { get; set; } = new List<WebsiteRewrite>();

    public virtual ResUser? WriteU { get; set; }
}
