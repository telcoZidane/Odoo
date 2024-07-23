using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock Package Destination
/// </summary>
public partial class StockPackageDestination
{
    public int Id { get; set; }

    /// <summary>
    /// Picking
    /// </summary>
    public int PickingId { get; set; }

    /// <summary>
    /// Destination location
    /// </summary>
    public int LocationDestId { get; set; }

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

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual StockPicking Picking { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
