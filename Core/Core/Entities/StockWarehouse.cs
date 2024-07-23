using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Warehouse
/// </summary>
public partial class StockWarehouse
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// View Location
    /// </summary>
    public int ViewLocationId { get; set; }

    /// <summary>
    /// Location Stock
    /// </summary>
    public int LotStockId { get; set; }

    /// <summary>
    /// Input Location
    /// </summary>
    public int? WhInputStockLocId { get; set; }

    /// <summary>
    /// Quality Control Location
    /// </summary>
    public int? WhQcStockLocId { get; set; }

    /// <summary>
    /// Output Location
    /// </summary>
    public int? WhOutputStockLocId { get; set; }

    /// <summary>
    /// Packing Location
    /// </summary>
    public int? WhPackStockLocId { get; set; }

    /// <summary>
    /// MTO rule
    /// </summary>
    public int? MtoPullId { get; set; }

    /// <summary>
    /// Pick Type
    /// </summary>
    public int? PickTypeId { get; set; }

    /// <summary>
    /// Pack Type
    /// </summary>
    public int? PackTypeId { get; set; }

    /// <summary>
    /// Out Type
    /// </summary>
    public int? OutTypeId { get; set; }

    /// <summary>
    /// In Type
    /// </summary>
    public int? InTypeId { get; set; }

    /// <summary>
    /// Internal Type
    /// </summary>
    public int? IntTypeId { get; set; }

    /// <summary>
    /// Return Type
    /// </summary>
    public int? ReturnTypeId { get; set; }

    /// <summary>
    /// Crossdock Route
    /// </summary>
    public int? CrossdockRouteId { get; set; }

    /// <summary>
    /// Receipt Route
    /// </summary>
    public int? ReceptionRouteId { get; set; }

    /// <summary>
    /// Delivery Route
    /// </summary>
    public int? DeliveryRouteId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Short Name
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Incoming Shipments
    /// </summary>
    public string ReceptionSteps { get; set; } = null!;

    /// <summary>
    /// Outgoing Shipments
    /// </summary>
    public string DeliverySteps { get; set; } = null!;

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
    /// Buy rule
    /// </summary>
    public int? BuyPullId { get; set; }

    /// <summary>
    /// Buy to Resupply
    /// </summary>
    public bool? BuyToResupply { get; set; }

    /// <summary>
    /// Point of Sale Operation Type
    /// </summary>
    public int? PosTypeId { get; set; }

    /// <summary>
    /// Manufacture Rule
    /// </summary>
    public int? ManufacturePullId { get; set; }

    /// <summary>
    /// Manufacture MTO Rule
    /// </summary>
    public int? ManufactureMtoPullId { get; set; }

    /// <summary>
    /// Picking Before Manufacturing MTO Rule
    /// </summary>
    public int? PbmMtoPullId { get; set; }

    /// <summary>
    /// Stock After Manufacturing Rule
    /// </summary>
    public int? SamRuleId { get; set; }

    /// <summary>
    /// Manufacturing Operation Type
    /// </summary>
    public int? ManuTypeId { get; set; }

    /// <summary>
    /// Picking Before Manufacturing Operation Type
    /// </summary>
    public int? PbmTypeId { get; set; }

    /// <summary>
    /// Stock After Manufacturing Operation Type
    /// </summary>
    public int? SamTypeId { get; set; }

    /// <summary>
    /// Picking Before Manufacturing Route
    /// </summary>
    public int? PbmRouteId { get; set; }

    /// <summary>
    /// Picking before Manufacturing Location
    /// </summary>
    public int? PbmLocId { get; set; }

    /// <summary>
    /// Stock after Manufacturing Location
    /// </summary>
    public int? SamLocId { get; set; }

    /// <summary>
    /// Manufacture
    /// </summary>
    public string ManufactureSteps { get; set; } = null!;

    /// <summary>
    /// Manufacture to Resupply
    /// </summary>
    public bool? ManufactureToResupply { get; set; }

    public virtual StockRule? BuyPull { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockRoute? CrossdockRoute { get; set; }

    public virtual StockRoute? DeliveryRoute { get; set; }

    public virtual StockPickingType? InType { get; set; }

    public virtual StockPickingType? IntType { get; set; }

    public virtual StockLocation LotStock { get; set; } = null!;

    public virtual StockPickingType? ManuType { get; set; }

    public virtual StockRule? ManufactureMtoPull { get; set; }

    public virtual StockRule? ManufacturePull { get; set; }

    public virtual StockRule? MtoPull { get; set; }

    public virtual StockPickingType? OutType { get; set; }

    public virtual StockPickingType? PackType { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockLocation? PbmLoc { get; set; }

    public virtual StockRule? PbmMtoPull { get; set; }

    public virtual StockRoute? PbmRoute { get; set; }

    public virtual StockPickingType? PbmType { get; set; }

    public virtual StockPickingType? PickType { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual StockPickingType? PosType { get; set; }

    public virtual ICollection<ProductReplenish> ProductReplenishes { get; set; } = new List<ProductReplenish>();

    public virtual StockRoute? ReceptionRoute { get; set; }

    public virtual StockPickingType? ReturnType { get; set; }

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual StockLocation? SamLoc { get; set; }

    public virtual StockRule? SamRule { get; set; }

    public virtual StockPickingType? SamType { get; set; }

    public virtual ICollection<StockLocation> StockLocations { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPickingType> StockPickingTypes { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockRoute> StockRouteSuppliedWhs { get; set; } = new List<StockRoute>();

    public virtual ICollection<StockRoute> StockRouteSupplierWhs { get; set; } = new List<StockRoute>();

    public virtual ICollection<StockRule> StockRulePropagateWarehouses { get; set; } = new List<StockRule>();

    public virtual ICollection<StockRule> StockRuleWarehouses { get; set; } = new List<StockRule>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual StockLocation ViewLocation { get; set; } = null!;

    public virtual ICollection<Website> Websites { get; set; } = new List<Website>();

    public virtual StockLocation? WhInputStockLoc { get; set; }

    public virtual StockLocation? WhOutputStockLoc { get; set; }

    public virtual StockLocation? WhPackStockLoc { get; set; }

    public virtual StockLocation? WhQcStockLoc { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockRoute> Routes { get; set; } = new List<StockRoute>();

    public virtual ICollection<StockRulesReport> StockRulesReports { get; set; } = new List<StockRulesReport>();

    public virtual ICollection<StockWarehouse> SuppliedWhs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> SupplierWhs { get; set; } = new List<StockWarehouse>();
}
