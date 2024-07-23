using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock Track Confirmation
/// </summary>
public partial class StockTrackConfirmation
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
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockTrackLine> StockTrackLines { get; set; } = new List<StockTrackLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductProduct> ProductProducts { get; set; } = new List<ProductProduct>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();
}
