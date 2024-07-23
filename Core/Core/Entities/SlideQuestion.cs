using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Content Quiz Question
/// </summary>
public partial class SlideQuestion
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Content
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
    /// Question Name
    /// </summary>
    public string Question { get; set; } = null!;

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

    public virtual ICollection<SlideAnswer> SlideAnswers { get; set; } = new List<SlideAnswer>();

    public virtual ResUser? WriteU { get; set; }
}
