using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Resume line of an employee
/// </summary>
public partial class HrResumeLine
{
    public int Id { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public int? LineTypeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Display Type
    /// </summary>
    public string? DisplayType { get; set; }

    /// <summary>
    /// Date Start
    /// </summary>
    public DateOnly DateStart { get; set; }

    /// <summary>
    /// Date End
    /// </summary>
    public DateOnly? DateEnd { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Certification
    /// </summary>
    public int? SurveyId { get; set; }

    /// <summary>
    /// Course
    /// </summary>
    public int? ChannelId { get; set; }

    public virtual SlideChannel? Channel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual HrResumeLineType? LineType { get; set; }

    public virtual SurveySurvey? Survey { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
