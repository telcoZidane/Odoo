using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Survey
/// </summary>
public partial class SurveySurvey
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Number of attempts
    /// </summary>
    public int? AttemptsLimit { get; set; }

    /// <summary>
    /// Certified Email Template
    /// </summary>
    public int? CertificationMailTemplateId { get; set; }

    /// <summary>
    /// Certification Badge
    /// </summary>
    public int? CertificationBadgeId { get; set; }

    /// <summary>
    /// Current Question
    /// </summary>
    public int? SessionQuestionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Pagination
    /// </summary>
    public string QuestionsLayout { get; set; } = null!;

    /// <summary>
    /// Question Selection
    /// </summary>
    public string QuestionsSelection { get; set; } = null!;

    /// <summary>
    /// Display Progress as
    /// </summary>
    public string? ProgressionMode { get; set; }

    /// <summary>
    /// Access Mode
    /// </summary>
    public string AccessMode { get; set; } = null!;

    /// <summary>
    /// Access Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Scoring
    /// </summary>
    public string ScoringType { get; set; } = null!;

    /// <summary>
    /// Certification template
    /// </summary>
    public string? CertificationReportLayout { get; set; }

    /// <summary>
    /// Session State
    /// </summary>
    public string? SessionState { get; set; }

    /// <summary>
    /// Session Code
    /// </summary>
    public string? SessionCode { get; set; }

    /// <summary>
    /// Survey Title
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// End Message
    /// </summary>
    public string? DescriptionDone { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Require Login
    /// </summary>
    public bool? UsersLoginRequired { get; set; }

    /// <summary>
    /// Users can go back
    /// </summary>
    public bool? UsersCanGoBack { get; set; }

    /// <summary>
    /// Limited number of attempts
    /// </summary>
    public bool? IsAttemptsLimited { get; set; }

    /// <summary>
    /// The survey is limited in time
    /// </summary>
    public bool? IsTimeLimited { get; set; }

    /// <summary>
    /// Is a Certification
    /// </summary>
    public bool? Certification { get; set; }

    /// <summary>
    /// Give Badge
    /// </summary>
    public bool? CertificationGiveBadge { get; set; }

    /// <summary>
    /// Reward quick answers
    /// </summary>
    public bool? SessionSpeedRating { get; set; }

    /// <summary>
    /// Current Session Start Time
    /// </summary>
    public DateTime? SessionStartTime { get; set; }

    /// <summary>
    /// Current Question Start Time
    /// </summary>
    public DateTime? SessionQuestionStartTime { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Required Score (%)
    /// </summary>
    public double? ScoringSuccessMin { get; set; }

    /// <summary>
    /// Time limit (minutes)
    /// </summary>
    public double? TimeLimit { get; set; }

    public virtual GamificationBadge? CertificationBadge { get; set; }

    public virtual MailTemplate? CertificationMailTemplate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<GamificationBadge> GamificationBadges { get; set; } = new List<GamificationBadge>();

    public virtual ICollection<HrResumeLine> HrResumeLines { get; set; } = new List<HrResumeLine>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual SurveyQuestion? SessionQuestion { get; set; }

    public virtual ICollection<SlideSlide> SlideSlides { get; set; } = new List<SlideSlide>();

    public virtual ICollection<SurveyInvite> SurveyInvites { get; set; } = new List<SurveyInvite>();

    public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; } = new List<SurveyQuestion>();

    public virtual ICollection<SurveyUserInputLine> SurveyUserInputLines { get; set; } = new List<SurveyUserInputLine>();

    public virtual ICollection<SurveyUserInput> SurveyUserInputs { get; set; } = new List<SurveyUserInput>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
