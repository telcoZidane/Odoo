using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Immediate Transfer Line
/// </summary>
public partial class StockImmediateTransferLine
{
    public int Id { get; set; }

    /// <summary>
    /// Immediate Transfer
    /// </summary>
    public int ImmediateTransferId { get; set; }

    /// <summary>
    /// Transfer
    /// </summary>
    public int PickingId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// To Process
    /// </summary>
    public bool? ToImmediate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockImmediateTransfer ImmediateTransfer { get; set; } = null!;

    public virtual StockPicking Picking { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
