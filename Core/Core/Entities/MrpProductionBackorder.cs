using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Wizard to mark as done or create back order
/// </summary>
public partial class MrpProductionBackorder
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

    public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLines { get; set; } = new List<MrpProductionBackorderLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();
}
