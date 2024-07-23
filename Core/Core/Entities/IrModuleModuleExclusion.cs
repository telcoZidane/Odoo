using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Module exclusion
/// </summary>
public partial class IrModuleModuleExclusion
{
    public int Id { get; set; }

    /// <summary>
    /// Module
    /// </summary>
    public int? ModuleId { get; set; }

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
    public string? Name { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModuleModule? Module { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
