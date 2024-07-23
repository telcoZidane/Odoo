using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Skill Level
/// </summary>
public partial class HrSkillLevel
{
    public int Id { get; set; }

    /// <summary>
    /// Skill Type
    /// </summary>
    public int? SkillTypeId { get; set; }

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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Default Level
    /// </summary>
    public bool? DefaultLevel { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrApplicantSkill> HrApplicantSkills { get; set; } = new List<HrApplicantSkill>();

    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogs { get; set; } = new List<HrEmployeeSkillLog>();

    public virtual ICollection<HrEmployeeSkill> HrEmployeeSkills { get; set; } = new List<HrEmployeeSkill>();

    public virtual HrSkillType? SkillType { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
