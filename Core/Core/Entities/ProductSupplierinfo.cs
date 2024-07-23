using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Supplier Pricelist
/// </summary>
public partial class ProductSupplierinfo
{
    public int Id { get; set; }

    /// <summary>
    /// Vendor
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Product Variant
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int? ProductTmplId { get; set; }

    /// <summary>
    /// Delivery Lead Time
    /// </summary>
    public int Delay { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Vendor Product Name
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// Vendor Product Code
    /// </summary>
    public string? ProductCode { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateOnly? DateStart { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? DateEnd { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal MinQty { get; set; }

    /// <summary>
    /// Price
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfos { get; set; } = new List<StockReplenishmentInfo>();
}
