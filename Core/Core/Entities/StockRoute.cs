using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Inventory Routes
/// </summary>
public partial class StockRoute
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Supplied Warehouse
    /// </summary>
    public int? SuppliedWhId { get; set; }

    /// <summary>
    /// Supplying Warehouse
    /// </summary>
    public int? SupplierWhId { get; set; }

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
    /// Route
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Applicable on Product
    /// </summary>
    public bool? ProductSelectable { get; set; }

    /// <summary>
    /// Applicable on Product Category
    /// </summary>
    public bool? ProductCategSelectable { get; set; }

    /// <summary>
    /// Applicable on Warehouse
    /// </summary>
    public bool? WarehouseSelectable { get; set; }

    /// <summary>
    /// Applicable on Packaging
    /// </summary>
    public bool? PackagingSelectable { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Selectable on Sales Order Line
    /// </summary>
    public bool? SaleSelectable { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; set; } = new List<StockReplenishmentOption>();

    public virtual ICollection<StockRule> StockRules { get; set; } = new List<StockRule>();

    public virtual ICollection<StockWarehouse> StockWarehouseCrossdockRoutes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseDeliveryRoutes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehousePbmRoutes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseReceptionRoutes { get; set; } = new List<StockWarehouse>();

    public virtual StockWarehouse? SuppliedWh { get; set; }

    public virtual StockWarehouse? SupplierWh { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductCategory> Categs { get; set; } = new List<ProductCategory>();

    public virtual ICollection<StockMove> Moves { get; set; } = new List<StockMove>();

    public virtual ICollection<ProductPackaging> Packagings { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<ProductReplenish> ProductReplenishes { get; set; } = new List<ProductReplenish>();

    public virtual ICollection<ProductTemplate> Products { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<StockRulesReport> StockRulesReports { get; set; } = new List<StockRulesReport>();

    public virtual ICollection<StockWarehouse> Warehouses { get; set; } = new List<StockWarehouse>();
}
