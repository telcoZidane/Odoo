using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Reset View Architecture Wizard
/// </summary>
public partial class ResetViewArchWizard
{
    public int Id { get; set; }

    /// <summary>
    /// View
    /// </summary>
    public int? ViewId { get; set; }

    /// <summary>
    /// Compare To View
    /// </summary>
    public int? CompareViewId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Reset Mode
    /// </summary>
    public string ResetMode { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual IrUiView? CompareView { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
