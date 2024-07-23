using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Additional resource for a particular slide
/// </summary>
public partial class SlideSlideResource
{
    public int Id { get; set; }

    /// <summary>
    /// Slide
    /// </summary>
    public int SlideId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Resource Type
    /// </summary>
    public string ResourceType { get; set; } = null!;

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// File Name
    /// </summary>
    public string? FileName { get; set; }

    /// <summary>
    /// Link
    /// </summary>
    public string? Link { get; set; }

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
