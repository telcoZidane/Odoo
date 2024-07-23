using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Link Tracker Code
/// </summary>
public partial class LinkTrackerCode
{
    public int Id { get; set; }

    /// <summary>
    /// Link
    /// </summary>
    public int LinkId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Short URL Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual LinkTracker Link { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
