using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Skill level for an applicant
/// </summary>
public partial class HrApplicantSkill
{
    public int Id { get; set; }

    /// <summary>
    /// Applicant
    /// </summary>
    public int ApplicantId { get; set; }

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
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual HrApplicant Applicant { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual HrSkill Skill { get; set; } = null!;

    public virtual HrSkillLevel SkillLevel { get; set; } = null!;

    public virtual HrSkillType SkillType { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
