using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock warehouse replenishment option
/// </summary>
public partial class StockReplenishmentOption
{
    public int Id { get; set; }

    /// <summary>
    /// Route
    /// </summary>
    public int? RouteId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Replenishment Info
    /// </summary>
    public int? ReplenishmentInfoId { get; set; }

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

    public virtual ProductProduct? Product { get; set; }

    public virtual StockReplenishmentInfo? ReplenishmentInfo { get; set; }

    public virtual StockRoute? Route { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
