using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock Request an Inventory Count
/// </summary>
public partial class StockRequestCount
{
    public int Id { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Count
    /// </summary>
    public string? SetCount { get; set; }

    /// <summary>
    /// Inventory Date
    /// </summary>
    public DateOnly InventoryDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Accounting Date
    /// </summary>
    public DateOnly? AccountingDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();
}
