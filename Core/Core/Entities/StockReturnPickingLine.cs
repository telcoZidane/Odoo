using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Return Picking Line
/// </summary>
public partial class StockReturnPickingLine
{
    public int Id { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Wizard
    /// </summary>
    public int? WizardId { get; set; }

    /// <summary>
    /// Move
    /// </summary>
    public int? MoveId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Update quantities on SO/PO
    /// </summary>
    public bool? ToRefund { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual StockReturnPicking? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
