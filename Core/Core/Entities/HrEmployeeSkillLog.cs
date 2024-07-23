using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Skills History
/// </summary>
public partial class HrEmployeeSkillLog
{
    public int Id { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Skill
    /// </summary>
    public int SkillId { get; set; }

    /// <summary>
    /// Skill Level
    /// </summary>
    public int SkillLevelId { get; set; }

    /// <summary>
    /// Skill Type
    /// </summary>
    public int SkillTypeId { get; set; }

    /// <summary>
    /// Progress
    /// </summary>
    public int? LevelProgress { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual HrSkill Skill { get; set; } = null!;

    public virtual HrSkillLevel SkillLevel { get; set; } = null!;

    public virtual HrSkillType SkillType { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
