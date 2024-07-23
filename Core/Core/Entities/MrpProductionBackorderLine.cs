using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Backorder Confirmation Line
/// </summary>
public partial class MrpProductionBackorderLine
{
    public int Id { get; set; }

    /// <summary>
    /// MO Backorder
    /// </summary>
    public int MrpProductionBackorderId { get; set; }

    /// <summary>
    /// Manufacturing Order
    /// </summary>
    public int MrpProductionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// To Backorder
    /// </summary>
    public bool? ToBackorder { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProduction MrpProduction { get; set; } = null!;

    public virtual MrpProductionBackorder MrpProductionBackorder { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
