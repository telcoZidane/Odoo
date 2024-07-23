using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Embedded Slides View Counter
/// </summary>
public partial class SlideEmbed
{
    public int Id { get; set; }

    /// <summary>
    /// Presentation
    /// </summary>
    public int SlideId { get; set; }

    /// <summary>
    /// # Views
    /// </summary>
    public int? CountViews { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Third Party Website URL
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SlideSlide Slide { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
