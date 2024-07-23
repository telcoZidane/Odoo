using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Wizard to Split a Production
/// </summary>
public partial class MrpProductionSplit
{
    public int Id { get; set; }

    /// <summary>
    /// Split Productions
    /// </summary>
    public int? ProductionSplitMultiId { get; set; }

    /// <summary>
    /// Manufacturing Order
    /// </summary>
    public int? ProductionId { get; set; }

    /// <summary>
    /// Split #
    /// </summary>
    public int? Counter { get; set; }

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

    public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLines { get; set; } = new List<MrpProductionSplitLine>();

    public virtual MrpProduction? Production { get; set; }

    public virtual MrpProductionSplitMulti? ProductionSplitMulti { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
