using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Module Uninstall
/// </summary>
public partial class BaseModuleUninstall
{
    public int Id { get; set; }

    /// <summary>
    /// Module
    /// </summary>
    public int ModuleId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Show All
    /// </summary>
    public bool? ShowAll { get; set; }

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

    public virtual ResUser? WriteU { get; set; }
}
