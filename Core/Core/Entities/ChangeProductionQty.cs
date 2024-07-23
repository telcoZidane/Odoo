using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Change Production Qty
/// </summary>
public partial class ChangeProductionQty
{
    public int Id { get; set; }

    /// <summary>
    /// Manufacturing Order
    /// </summary>
    public int MoId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Quantity To Produce
    /// </summary>
    public decimal ProductQty { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProduction Mo { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
