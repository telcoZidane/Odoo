using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Survey Question
/// </summary>
public partial class SurveyQuestion
{
    public int Id { get; set; }

    /// <summary>
    /// Survey
    /// </summary>
    public int? SurveyId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// # Questions Randomly Picked
    /// </summary>
    public int? RandomQuestionsCount { get; set; }

    /// <summary>
    /// Page
    /// </summary>
    public int? PageId { get; set; }

    /// <summary>
    /// Time limit (seconds)
    /// </summary>
    public int? TimeLimit { get; set; }

    /// <summary>
    /// Minimum Text Length
    /// </summary>
    public int? ValidationLengthMin { get; set; }

    /// <summary>
    /// Maximum Text Length
    /// </summary>
    public int? ValidationLengthMax { get; set; }

    /// <summary>
    /// Triggering Question
    /// </summary>
    public int? TriggeringQuestionId { get; set; }

    /// <summary>
    /// Triggering Answer
    /// </summary>
    public int? TriggeringAnswerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Question Type
    /// </summary>
    public string? QuestionType { get; set; }

    /// <summary>
    /// Matrix Type
    /// </summary>
    public string? MatrixSubtype { get; set; }

    /// <summary>
    /// Correct date answer
    /// </summary>
    public DateOnly? AnswerDate { get; set; }

    /// <summary>
    /// Minimum Date
    /// </summary>
    public DateOnly? ValidationMinDate { get; set; }

    /// <summary>
    /// Maximum Date
    /// </summary>
    public DateOnly? ValidationMaxDate { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Placeholder
    /// </summary>
    public string? QuestionPlaceholder { get; set; }

    /// <summary>
    /// Comment Message
    /// </summary>
    public string? CommentsMessage { get; set; }

    /// <summary>
    /// Validation Error message
    /// </summary>
    public string? ValidationErrorMsg { get; set; }

    /// <summary>
    /// Error message
    /// </summary>
    public string? ConstrErrorMsg { get; set; }

    /// <summary>
    /// Is a page?
    /// </summary>
    public bool? IsPage { get; set; }

    /// <summary>
    /// Scored
    /// </summary>
    public bool? IsScoredQuestion { get; set; }

    /// <summary>
    /// Save as user email
    /// </summary>
    public bool? SaveAsEmail { get; set; }

    /// <summary>
    /// Save as user nickname
    /// </summary>
    public bool? SaveAsNickname { get; set; }

    /// <summary>
    /// The question is limited in time
    /// </summary>
    public bool? IsTimeLimited { get; set; }

    /// <summary>
    /// Show Comments Field
    /// </summary>
    public bool? CommentsAllowed { get; set; }

    /// <summary>
    /// Comment is an answer
    /// </summary>
    public bool? CommentCountAsAnswer { get; set; }

    /// <summary>
    /// Validate entry
    /// </summary>
    public bool? ValidationRequired { get; set; }

    /// <summary>
    /// Input must be an email
    /// </summary>
    public bool? ValidationEmail { get; set; }

    /// <summary>
    /// Mandatory Answer
    /// </summary>
    public bool? ConstrMandatory { get; set; }

    /// <summary>
    /// Conditional Display
    /// </summary>
    public bool? IsConditional { get; set; }

    /// <summary>
    /// Correct datetime answer
    /// </summary>
    public DateTime? AnswerDatetime { get; set; }

    /// <summary>
    /// Minimum Datetime
    /// </summary>
    public DateTime? ValidationMinDatetime { get; set; }

    /// <summary>
    /// Maximum Datetime
    /// </summary>
    public DateTime? ValidationMaxDatetime { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Correct numerical answer
    /// </summary>
    public double? AnswerNumericalBox { get; set; }

    /// <summary>
    /// Score
    /// </summary>
    public double? AnswerScore { get; set; }

    /// <summary>
    /// Minimum value
    /// </summary>
    public double? ValidationMinFloatValue { get; set; }

    /// <summary>
    /// Maximum value
    /// </summary>
    public double? ValidationMaxFloatValue { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<SurveyQuestion> InversePage { get; set; } = new List<SurveyQuestion>();

    public virtual ICollection<SurveyQuestion> InverseTriggeringQuestion { get; set; } = new List<SurveyQuestion>();

    public virtual SurveyQuestion? Page { get; set; }

    public virtual SurveySurvey? Survey { get; set; }

    public virtual ICollection<SurveyQuestionAnswer> SurveyQuestionAnswerMatrixQuestions { get; set; } = new List<SurveyQuestionAnswer>();

    public virtual ICollection<SurveyQuestionAnswer> SurveyQuestionAnswerQuestions { get; set; } = new List<SurveyQuestionAnswer>();

    public virtual ICollection<SurveySurvey> SurveySurveys { get; set; } = new List<SurveySurvey>();

    public virtual ICollection<SurveyUserInputLine> SurveyUserInputLines { get; set; } = new List<SurveyUserInputLine>();

    public virtual ICollection<SurveyUserInput> SurveyUserInputsNavigation { get; set; } = new List<SurveyUserInput>();

    public virtual SurveyQuestionAnswer? TriggeringAnswer { get; set; }

    public virtual SurveyQuestion? TriggeringQuestion { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<SurveyUserInput> SurveyUserInputs { get; set; } = new List<SurveyUserInput>();
}
