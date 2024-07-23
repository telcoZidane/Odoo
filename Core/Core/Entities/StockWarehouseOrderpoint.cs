using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Minimum Inventory Rule
/// </summary>
public partial class StockWarehouseOrderpoint
{
    public int Id { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int WarehouseId { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int? ProductCategoryId { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Preferred Route
    /// </summary>
    public int? RouteId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Trigger
    /// </summary>
    public string Trigger { get; set; } = null!;

    /// <summary>
    /// Snoozed
    /// </summary>
    public DateOnly? SnoozedUntil { get; set; }

    /// <summary>
    /// Min Quantity
    /// </summary>
    public decimal ProductMinQty { get; set; }

    /// <summary>
    /// Max Quantity
    /// </summary>
    public decimal ProductMaxQty { get; set; }

    /// <summary>
    /// Multiple Quantity
    /// </summary>
    public decimal QtyMultiple { get; set; }

    /// <summary>
    /// To Order
    /// </summary>
    public decimal? QtyToOrder { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Product Supplier
    /// </summary>
    public int? SupplierId { get; set; }

    /// <summary>
    /// Vendor
    /// </summary>
    public int? VendorId { get; set; }

    /// <summary>
    /// Purchase Visibility Days
    /// </summary>
    public double? PurchaseVisibilityDays { get; set; }

    /// <summary>
    /// Bill of Materials
    /// </summary>
    public int? BomId { get; set; }

    /// <summary>
    /// Manufacturing Visibility Days
    /// </summary>
    public double? ManufacturingVisibilityDays { get; set; }

    public virtual MrpBom? Bom { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductCategory? ProductCategory { get; set; }

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual StockRoute? Route { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfos { get; set; } = new List<StockReplenishmentInfo>();

    public virtual ProductSupplierinfo? Supplier { get; set; }

    public virtual ResPartner? Vendor { get; set; }

    public virtual StockWarehouse Warehouse { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockOrderpointSnooze> StockOrderpointSnoozes { get; set; } = new List<StockOrderpointSnooze>();
}
