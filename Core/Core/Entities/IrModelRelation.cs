using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Relation Model
/// </summary>
public partial class IrModelRelation
{
    public int Id { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int Model { get; set; }

    /// <summary>
    /// Module
    /// </summary>
    public int Module { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Relation Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Write Date
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Create Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel ModelNavigation { get; set; } = null!;

    public virtual IrModuleModule ModuleNavigation { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
