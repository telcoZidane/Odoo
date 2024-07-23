using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Immediate Transfer
/// </summary>
public partial class StockImmediateTransfer
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
    /// Show Transfers
    /// </summary>
    public bool? ShowTransfers { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLines { get; set; } = new List<StockImmediateTransferLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();
}
