using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Backorder Confirmation Line
/// </summary>
public partial class StockBackorderConfirmationLine
{
    public int Id { get; set; }

    /// <summary>
    /// Immediate Transfer
    /// </summary>
    public int? BackorderConfirmationId { get; set; }

    /// <summary>
    /// Transfer
    /// </summary>
    public int? PickingId { get; set; }

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

    public virtual StockBackorderConfirmation? BackorderConfirmation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
