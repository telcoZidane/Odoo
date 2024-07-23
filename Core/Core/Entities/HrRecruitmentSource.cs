using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Source of Applicants
/// </summary>
public partial class HrRecruitmentSource
{
    public int Id { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public int SourceId { get; set; }

    /// <summary>
    /// Job
    /// </summary>
    public int? JobId { get; set; }

    /// <summary>
    /// Alias ID
    /// </summary>
    public int? AliasId { get; set; }

    /// <summary>
    /// Medium
    /// </summary>
    public int? MediumId { get; set; }

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

    public virtual MailAlias? Alias { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrJob? Job { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual UtmSource Source { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
