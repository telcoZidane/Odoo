using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Get Refuse Reason
/// </summary>
public partial class ApplicantGetRefuseReason
{
    public int Id { get; set; }

    /// <summary>
    /// Refuse Reason
    /// </summary>
    public int RefuseReasonId { get; set; }

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
    /// Send Email
    /// </summary>
    public bool? SendMail { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrApplicantRefuseReason RefuseReason { get; set; } = null!;

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();
}
