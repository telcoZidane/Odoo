using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Refuse Reason of Applicant
/// </summary>
public partial class HrApplicantRefuseReason
{
    public int Id { get; set; }

    /// <summary>
    /// Email Template
    /// </summary>
    public int? TemplateId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; set; } = new List<ApplicantGetRefuseReason>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
