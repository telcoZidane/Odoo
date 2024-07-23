using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Immediate Production Line
/// </summary>
public partial class MrpImmediateProductionLine
{
    public int Id { get; set; }

    /// <summary>
    /// Immediate Production
    /// </summary>
    public int ImmediateProductionId { get; set; }

    /// <summary>
    /// Production
    /// </summary>
    public int ProductionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// To Process
    /// </summary>
    public bool? ToImmediate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpImmediateProduction ImmediateProduction { get; set; } = null!;

    public virtual MrpProduction Production { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
