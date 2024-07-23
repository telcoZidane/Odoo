using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Survey User Input Line
/// </summary>
public partial class SurveyUserInputLine
{
    public int Id { get; set; }

    /// <summary>
    /// User Input
    /// </summary>
    public int UserInputId { get; set; }

    /// <summary>
    /// Survey
    /// </summary>
    public int? SurveyId { get; set; }

    /// <summary>
    /// Question
    /// </summary>
    public int QuestionId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? QuestionSequence { get; set; }

    /// <summary>
    /// Suggested answer
    /// </summary>
    public int? SuggestedAnswerId { get; set; }

    /// <summary>
    /// Row answer
    /// </summary>
    public int? MatrixRowId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Answer Type
    /// </summary>
    public string? AnswerType { get; set; }

    /// <summary>
    /// Text answer
    /// </summary>
    public string? ValueCharBox { get; set; }

    /// <summary>
    /// Date answer
    /// </summary>
    public DateOnly? ValueDate { get; set; }

    /// <summary>
    /// Free Text answer
    /// </summary>
    public string? ValueTextBox { get; set; }

    /// <summary>
    /// Skipped
    /// </summary>
    public bool? Skipped { get; set; }

    /// <summary>
    /// Correct
    /// </summary>
    public bool? AnswerIsCorrect { get; set; }

    /// <summary>
    /// Datetime answer
    /// </summary>
    public DateTime? ValueDatetime { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Numerical answer
    /// </summary>
    public double? ValueNumericalBox { get; set; }

    /// <summary>
    /// Score
    /// </summary>
    public double? AnswerScore { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SurveyQuestionAnswer? MatrixRow { get; set; }

    public virtual SurveyQuestion Question { get; set; } = null!;

    public virtual SurveyQuestionAnswer? SuggestedAnswer { get; set; }

    public virtual SurveySurvey? Survey { get; set; }

    public virtual SurveyUserInput UserInput { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
