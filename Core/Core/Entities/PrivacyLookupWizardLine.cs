using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Privacy Lookup Wizard Line
/// </summary>
public partial class PrivacyLookupWizardLine
{
    public int Id { get; set; }

    /// <summary>
    /// Wizard
    /// </summary>
    public int? WizardId { get; set; }

    /// <summary>
    /// Resource ID
    /// </summary>
    public int ResId { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public int? ResModelId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Resource name
    /// </summary>
    public string? ResName { get; set; }

    /// <summary>
    /// Document Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Execution Details
    /// </summary>
    public string? ExecutionDetails { get; set; }

    /// <summary>
    /// Has Active
    /// </summary>
    public bool? HasActive { get; set; }

    /// <summary>
    /// Is Active
    /// </summary>
    public bool? IsActive { get; set; }

    /// <summary>
    /// Is Unlinked
    /// </summary>
    public bool? IsUnlinked { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel? ResModelNavigation { get; set; }

    public virtual PrivacyLookupWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
