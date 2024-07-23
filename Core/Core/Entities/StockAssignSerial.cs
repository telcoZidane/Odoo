using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock Assign Serial Numbers
/// </summary>
public partial class StockAssignSerial
{
    public int Id { get; set; }

    /// <summary>
    /// Move
    /// </summary>
    public int? MoveId { get; set; }

    /// <summary>
    /// Number of SN
    /// </summary>
    public int NextSerialCount { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// First SN
    /// </summary>
    public string NextSerialNumber { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Production
    /// </summary>
    public int? ProductionId { get; set; }

    /// <summary>
    /// Produced Serial Numbers
    /// </summary>
    public string? SerialNumbers { get; set; }

    /// <summary>
    /// Multiple Lot Components Names
    /// </summary>
    public string? MultipleLotComponentsNames { get; set; }

    /// <summary>
    /// Expected Quantity
    /// </summary>
    public decimal? ExpectedQty { get; set; }

    /// <summary>
    /// Produced Quantity
    /// </summary>
    public decimal? ProducedQty { get; set; }

    /// <summary>
    /// Show Apply
    /// </summary>
    public bool? ShowApply { get; set; }

    /// <summary>
    /// Show Backorders
    /// </summary>
    public bool? ShowBackorders { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual MrpProduction? Production { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
