using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Privacy Lookup Wizard
/// </summary>
public partial class PrivacyLookupWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Log
    /// </summary>
    public int? LogId { get; set; }

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
    /// Email
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Execution Details
    /// </summary>
    public string? ExecutionDetails { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual PrivacyLog? Log { get; set; }

    public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLines { get; set; } = new List<PrivacyLookupWizardLine>();

    public virtual ResUser? WriteU { get; set; }
}
