using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Slide / Partner decorated m2m
/// </summary>
public partial class SlideSlidePartner
{
    public int Id { get; set; }

    /// <summary>
    /// Content
    /// </summary>
    public int SlideId { get; set; }

    /// <summary>
    /// Channel
    /// </summary>
    public int? ChannelId { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Vote
    /// </summary>
    public int? Vote { get; set; }

    /// <summary>
    /// Quiz attempts count
    /// </summary>
    public int? QuizAttemptsCount { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Completed
    /// </summary>
    public bool? Completed { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Certification Succeeded
    /// </summary>
    public bool? SurveyScoringSuccess { get; set; }

    public virtual SlideChannel? Channel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual SlideSlide Slide { get; set; } = null!;

    public virtual ICollection<SurveyUserInput> SurveyUserInputs { get; set; } = new List<SurveyUserInput>();

    public virtual ResUser? WriteU { get; set; }
}
