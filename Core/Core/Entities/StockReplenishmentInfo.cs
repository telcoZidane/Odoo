using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock supplier replenishment information
/// </summary>
public partial class StockReplenishmentInfo
{
    public int Id { get; set; }

    /// <summary>
    /// Orderpoint
    /// </summary>
    public int? OrderpointId { get; set; }

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

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; set; } = new List<StockReplenishmentOption>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; set; } = new List<ProductSupplierinfo>();
}
