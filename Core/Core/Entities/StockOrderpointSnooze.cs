using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Snooze Orderpoint
/// </summary>
public partial class StockOrderpointSnooze
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
    /// Snooze for
    /// </summary>
    public string? PredefinedDate { get; set; }

    /// <summary>
    /// Snooze Date
    /// </summary>
    public DateOnly? SnoozedUntil { get; set; }

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

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();
}
