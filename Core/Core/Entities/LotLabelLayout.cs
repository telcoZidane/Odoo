using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Choose the sheet layout to print lot labels
/// </summary>
public partial class LotLabelLayout
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
    /// Quantity to print
    /// </summary>
    public string LabelQuantity { get; set; } = null!;

    /// <summary>
    /// Format
    /// </summary>
    public string PrintFormat { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();
}
