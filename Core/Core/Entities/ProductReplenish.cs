using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Replenish
/// </summary>
public partial class ProductReplenish
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
    /// Unit of measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int WarehouseId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

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
    /// Scheduled Date
    /// </summary>
    public DateTime DatePlanned { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public double Quantity { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual UomUom ProductUom { get; set; } = null!;

    public virtual StockWarehouse Warehouse { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockRoute> StockRoutes { get; set; } = new List<StockRoute>();
}
