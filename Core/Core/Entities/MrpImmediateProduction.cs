using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Immediate Production
/// </summary>
public partial class MrpImmediateProduction
{
    public int Id { get; set; }

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

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLines { get; set; } = new List<MrpImmediateProductionLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();
}
