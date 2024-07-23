using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Wizard in case of consumption in warning/strict and more component has been used for a MO (related to the bom)
/// </summary>
public partial class MrpConsumptionWarning
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

    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLines { get; set; } = new List<MrpConsumptionWarningLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();
}
