using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Survey User Input
/// </summary>
public partial class SurveyUserInput
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Survey
    /// </summary>
    public int SurveyId { get; set; }

    /// <summary>
    /// Last displayed question/page
    /// </summary>
    public int? LastDisplayedPageId { get; set; }

    /// <summary>
    /// Contact
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Identification token
    /// </summary>
    public string AccessToken { get; set; } = null!;

    /// <summary>
    /// Invite token
    /// </summary>
    public string? InviteToken { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Nickname
    /// </summary>
    public string? Nickname { get; set; }

    /// <summary>
    /// Test Entry
    /// </summary>
    public bool? TestEntry { get; set; }

    /// <summary>
    /// Quizz Passed
    /// </summary>
    public bool? ScoringSuccess { get; set; }

    /// <summary>
    /// Is in a Session
    /// </summary>
    public bool? IsSessionAnswer { get; set; }

    /// <summary>
    /// Start date and time
    /// </summary>
    public DateTime? StartDatetime { get; set; }

    /// <summary>
    /// End date and time
    /// </summary>
    public DateTime? EndDatetime { get; set; }

    /// <summary>
    /// Deadline
    /// </summary>
    public DateTime? Deadline { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Score (%)
    /// </summary>
    public double? ScoringPercentage { get; set; }

    /// <summary>
    /// Total Score
    /// </summary>
    public double? ScoringTotal { get; set; }

    /// <summary>
    /// Related course slide
    /// </summary>
    public int? SlideId { get; set; }

    /// <summary>
    /// Subscriber information
    /// </summary>
    public int? SlidePartnerId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SurveyQuestion? LastDisplayedPage { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual SlideSlide? Slide { get; set; }

    public virtual SlideSlidePartner? SlidePartner { get; set; }

    public virtual SurveySurvey Survey { get; set; } = null!;

    public virtual ICollection<SurveyUserInputLine> SurveyUserInputLines { get; set; } = new List<SurveyUserInputLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; } = new List<SurveyQuestion>();
}
