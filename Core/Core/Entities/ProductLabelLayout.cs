using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Choose the sheet layout to print the labels
/// </summary>
public partial class ProductLabelLayout
{
    public int Id { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public int CustomQuantity { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Format
    /// </summary>
    public string PrintFormat { get; set; } = null!;

    /// <summary>
    /// Extra Content
    /// </summary>
    public string? ExtraHtml { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Quantity to print
    /// </summary>
    public string PickingQuantity { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductProduct> ProductProducts { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();
}
