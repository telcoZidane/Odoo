using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Return Picking
/// </summary>
public partial class StockReturnPicking
{
    public int Id { get; set; }

    /// <summary>
    /// Picking
    /// </summary>
    public int? PickingId { get; set; }

    /// <summary>
    /// Original Location
    /// </summary>
    public int? OriginalLocationId { get; set; }

    /// <summary>
    /// Parent Location
    /// </summary>
    public int? ParentLocationId { get; set; }

    /// <summary>
    /// Return Location
    /// </summary>
    public int? LocationId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Chained Move Exists
    /// </summary>
    public bool? MoveDestExists { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockLocation? OriginalLocation { get; set; }

    public virtual StockLocation? ParentLocation { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; set; } = new List<StockReturnPickingLine>();

    public virtual ResUser? WriteU { get; set; }
}
