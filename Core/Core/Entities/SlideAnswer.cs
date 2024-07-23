using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Slide Question&apos;s Answer
/// </summary>
public partial class SlideAnswer
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Question
    /// </summary>
    public int QuestionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Answer
    /// </summary>
    public string TextValue { get; set; } = null!;

    /// <summary>
    /// Comment
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Is correct answer
    /// </summary>
    public bool? IsCorrect { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SlideQuestion Question { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
