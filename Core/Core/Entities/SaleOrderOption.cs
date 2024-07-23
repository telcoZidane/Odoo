using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sale Options
/// </summary>
public partial class SaleOrderOption
{
    public int Id { get; set; }

    /// <summary>
    /// Sales Order Reference
    /// </summary>
    public int? OrderId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Line
    /// </summary>
    public int? LineId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int UomId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public decimal PriceUnit { get; set; }

    /// <summary>
    /// Discount (%)
    /// </summary>
    public decimal? Discount { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SaleOrderLine? Line { get; set; }

    public virtual SaleOrder? Order { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual UomUom Uom { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
