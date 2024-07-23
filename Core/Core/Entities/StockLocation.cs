using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Inventory Locations
/// </summary>
public partial class StockLocation
{
    public int Id { get; set; }

    /// <summary>
    /// Parent Location
    /// </summary>
    public int? LocationId { get; set; }

    /// <summary>
    /// Corridor (X)
    /// </summary>
    public int? Posx { get; set; }

    /// <summary>
    /// Shelves (Y)
    /// </summary>
    public int? Posy { get; set; }

    /// <summary>
    /// Height (Z)
    /// </summary>
    public int? Posz { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Removal Strategy
    /// </summary>
    public int? RemovalStrategyId { get; set; }

    /// <summary>
    /// Inventory Frequency (Days)
    /// </summary>
    public int? CyclicInventoryFrequency { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Storage Category
    /// </summary>
    public int? StorageCategoryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Location Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Full Location Name
    /// </summary>
    public string? CompleteName { get; set; }

    /// <summary>
    /// Location Type
    /// </summary>
    public string Usage { get; set; } = null!;

    /// <summary>
    /// Parent Path
    /// </summary>
    public string? ParentPath { get; set; }

    /// <summary>
    /// Barcode
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// Last Effective Inventory
    /// </summary>
    public DateOnly? LastInventoryDate { get; set; }

    /// <summary>
    /// Next Expected Inventory
    /// </summary>
    public DateOnly? NextInventoryDate { get; set; }

    /// <summary>
    /// Additional Information
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Is a Scrap Location?
    /// </summary>
    public bool? ScrapLocation { get; set; }

    /// <summary>
    /// Is a Return Location?
    /// </summary>
    public bool? ReturnLocation { get; set; }

    /// <summary>
    /// Replenish Location
    /// </summary>
    public bool? ReplenishLocation { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Stock Valuation Account (Incoming)
    /// </summary>
    public int? ValuationInAccountId { get; set; }

    /// <summary>
    /// Stock Valuation Account (Outgoing)
    /// </summary>
    public int? ValuationOutAccountId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockLocation> InverseLocation { get; set; } = new List<StockLocation>();

    public virtual StockLocation? Location { get; set; }

    public virtual ICollection<MrpProduction> MrpProductionLocationDests { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpProduction> MrpProductionLocationSrcs { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpProduction> MrpProductionProductionLocations { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpUnbuild> MrpUnbuildLocationDests { get; set; } = new List<MrpUnbuild>();

    public virtual ICollection<MrpUnbuild> MrpUnbuildLocations { get; set; } = new List<MrpUnbuild>();

    public virtual ProductRemoval? RemovalStrategy { get; set; }

    public virtual ICollection<RepairLine> RepairLineLocationDests { get; set; } = new List<RepairLine>();

    public virtual ICollection<RepairLine> RepairLineLocations { get; set; } = new List<RepairLine>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<StockMoveLine> StockMoveLineLocationDests { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMoveLine> StockMoveLineLocations { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoveLocationDests { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMoveLocations { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPackageDestination> StockPackageDestinations { get; set; } = new List<StockPackageDestination>();

    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; set; } = new List<StockPackageLevel>();

    public virtual ICollection<StockPicking> StockPickingLocationDests { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockPicking> StockPickingLocations { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockPickingType> StockPickingTypeDefaultLocationDests { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockPickingType> StockPickingTypeDefaultLocationSrcs { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockPutawayRule> StockPutawayRuleLocationIns { get; set; } = new List<StockPutawayRule>();

    public virtual ICollection<StockPutawayRule> StockPutawayRuleLocationOuts { get; set; } = new List<StockPutawayRule>();

    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingLocations { get; set; } = new List<StockReturnPicking>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingOriginalLocations { get; set; } = new List<StockReturnPicking>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingParentLocations { get; set; } = new List<StockReturnPicking>();

    public virtual ICollection<StockRule> StockRuleLocationDests { get; set; } = new List<StockRule>();

    public virtual ICollection<StockRule> StockRuleLocationSrcs { get; set; } = new List<StockRule>();

    public virtual ICollection<StockScrap> StockScrapLocations { get; set; } = new List<StockScrap>();

    public virtual ICollection<StockScrap> StockScrapScrapLocations { get; set; } = new List<StockScrap>();

    public virtual ICollection<StockWarehouse> StockWarehouseLotStocks { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehousePbmLocs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseSamLocs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseViewLocations { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhInputStockLocs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhOutputStockLocs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhPackStockLocs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhQcStockLocs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairs { get; set; } = new List<StockWarnInsufficientQtyRepair>();

    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScraps { get; set; } = new List<StockWarnInsufficientQtyScrap>();

    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuilds { get; set; } = new List<StockWarnInsufficientQtyUnbuild>();

    public virtual StockStorageCategory? StorageCategory { get; set; }

    public virtual AccountAccount? ValuationInAccount { get; set; }

    public virtual AccountAccount? ValuationOutAccount { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
