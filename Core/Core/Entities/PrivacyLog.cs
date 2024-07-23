using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Privacy Log
/// </summary>
public partial class PrivacyLog
{
    public int Id { get; set; }

    /// <summary>
    /// Handled By
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Anonymized Name
    /// </summary>
    public string AnonymizedName { get; set; } = null!;

    /// <summary>
    /// Anonymized Email
    /// </summary>
    public string AnonymizedEmail { get; set; } = null!;

    /// <summary>
    /// Execution Details
    /// </summary>
    public string? ExecutionDetails { get; set; }

    /// <summary>
    /// Found Records
    /// </summary>
    public string? RecordsDescription { get; set; }

    /// <summary>
    /// Additional Note
    /// </summary>
    public string? AdditionalNote { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PrivacyLookupWizard> PrivacyLookupWizards { get; set; } = new List<PrivacyLookupWizard>();

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
