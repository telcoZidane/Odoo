using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Packaging
/// </summary>
public partial class ProductPackaging
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

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
    /// Product Packaging
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Barcode
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// Contained Quantity
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Sales
    /// </summary>
    public bool? Sales { get; set; }

    /// <summary>
    /// Package Type
    /// </summary>
    public int? PackageTypeId { get; set; }

    /// <summary>
    /// Purchase
    /// </summary>
    public bool? Purchase { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockPackageType? PackageType { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockRoute> Routes { get; set; } = new List<StockRoute>();
}
