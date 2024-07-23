using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock Rules report
/// </summary>
public partial class StockRulesReport
{
    public int Id { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int ProductTmplId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Has variants
    /// </summary>
    public bool ProductHasVariants { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockRoute> StockRoutes { get; set; } = new List<StockRoute>();

    public virtual ICollection<StockWarehouse> StockWarehouses { get; set; } = new List<StockWarehouse>();
}
