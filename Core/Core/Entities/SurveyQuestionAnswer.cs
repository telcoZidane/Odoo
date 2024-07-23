using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Survey Label
/// </summary>
public partial class SurveyQuestionAnswer
{
    public int Id { get; set; }

    /// <summary>
    /// Question
    /// </summary>
    public int? QuestionId { get; set; }

    /// <summary>
    /// Question (as matrix row)
    /// </summary>
    public int? MatrixQuestionId { get; set; }

    /// <summary>
    /// Label Sequence order
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Image Filename
    /// </summary>
    public string? ValueImageFilename { get; set; }

    /// <summary>
    /// Suggested value
    /// </summary>
    public string Value { get; set; } = null!;

    /// <summary>
    /// Correct
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

    /// <summary>
    /// Score
    /// </summary>
    public double? AnswerScore { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SurveyQuestion? MatrixQuestion { get; set; }

    public virtual SurveyQuestion? Question { get; set; }

    public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; } = new List<SurveyQuestion>();

    public virtual ICollection<SurveyUserInputLine> SurveyUserInputLineMatrixRows { get; set; } = new List<SurveyUserInputLine>();

    public virtual ICollection<SurveyUserInputLine> SurveyUserInputLineSuggestedAnswers { get; set; } = new List<SurveyUserInputLine>();

    public virtual ResUser? WriteU { get; set; }
}
