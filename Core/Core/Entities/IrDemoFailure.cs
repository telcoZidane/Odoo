using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Demo failure
/// </summary>
public partial class IrDemoFailure
{
    public int Id { get; set; }

    /// <summary>
    /// Module
    /// </summary>
    public int ModuleId { get; set; }

    /// <summary>
    /// Wizard
    /// </summary>
    public int? WizardId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Error
    /// </summary>
    public string? Error { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModuleModule Module { get; set; } = null!;

    public virtual IrDemoFailureWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
