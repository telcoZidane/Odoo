﻿using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Inventory Adjustment Reference / Reason
/// </summary>
public partial class StockInventoryAdjustmentName
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
    /// Inventory Adjustment Name
    /// </summary>
    public string? InventoryAdjustmentName { get; set; }

    /// <summary>
    /// Show warning
    /// </summary>
    public bool? ShowInfo { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();
}
