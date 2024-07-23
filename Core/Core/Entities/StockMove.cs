using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock Move
/// </summary>
public partial class StockMove
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// UoM
    /// </summary>
    public int ProductUom { get; set; }

    /// <summary>
    /// Source Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Destination Location
    /// </summary>
    public int LocationDestId { get; set; }

    /// <summary>
    /// Destination Address 
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Transfer
    /// </summary>
    public int? PickingId { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Stock Rule
    /// </summary>
    public int? RuleId { get; set; }

    /// <summary>
    /// Operation Type
    /// </summary>
    public int? PickingTypeId { get; set; }

    /// <summary>
    /// Origin return move
    /// </summary>
    public int? OriginReturnedMoveId { get; set; }

    /// <summary>
    /// Owner 
    /// </summary>
    public int? RestrictPartnerId { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Package Level
    /// </summary>
    public int? PackageLevelId { get; set; }

    /// <summary>
    /// Number of SN
    /// </summary>
    public int? NextSerialCount { get; set; }

    /// <summary>
    /// Original Reordering Rule
    /// </summary>
    public int? OrderpointId { get; set; }

    /// <summary>
    /// Packaging
    /// </summary>
    public int? ProductPackagingId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Source Document
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// Supply Method
    /// </summary>
    public string ProcureMethod { get; set; } = null!;

    /// <summary>
    /// Reference
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// First SN
    /// </summary>
    public string? NextSerial { get; set; }

    /// <summary>
    /// Date to Reserve
    /// </summary>
    public DateOnly? ReservationDate { get; set; }

    /// <summary>
    /// Description of Picking
    /// </summary>
    public string? DescriptionPicking { get; set; }

    /// <summary>
    /// Real Quantity
    /// </summary>
    public decimal? ProductQty { get; set; }

    /// <summary>
    /// Demand
    /// </summary>
    public decimal ProductUomQty { get; set; }

    /// <summary>
    /// Quantity Done
    /// </summary>
    public decimal? QuantityDone { get; set; }

    /// <summary>
    /// Scrapped
    /// </summary>
    public bool? Scrapped { get; set; }

    /// <summary>
    /// Propagate cancel and split
    /// </summary>
    public bool? PropagateCancel { get; set; }

    /// <summary>
    /// Inventory
    /// </summary>
    public bool? IsInventory { get; set; }

    /// <summary>
    /// Whether the move was added after the picking&apos;s confirmation
    /// </summary>
    public bool? Additional { get; set; }

    /// <summary>
    /// Date Scheduled
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Deadline
    /// </summary>
    public DateTime? DateDeadline { get; set; }

    /// <summary>
    /// Delay Alert Date
    /// </summary>
    public DateTime? DelayAlertDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public double? PriceUnit { get; set; }

    /// <summary>
    /// Analytic Account Line
    /// </summary>
    public int? AnalyticAccountLineId { get; set; }

    /// <summary>
    /// Update quantities on SO/PO
    /// </summary>
    public bool? ToRefund { get; set; }

    /// <summary>
    /// Sale Line
    /// </summary>
    public int? SaleLineId { get; set; }

    /// <summary>
    /// Purchase Order Line
    /// </summary>
    public int? PurchaseLineId { get; set; }

    /// <summary>
    /// Created Purchase Order Line
    /// </summary>
    public int? CreatedPurchaseLineId { get; set; }

    public bool? IsDone { get; set; }

    public double? UnitFactor { get; set; }

    /// <summary>
    /// Created Production Order
    /// </summary>
    public int? CreatedProductionId { get; set; }

    /// <summary>
    /// Production Order for finished products
    /// </summary>
    public int? ProductionId { get; set; }

    /// <summary>
    /// Production Order for components
    /// </summary>
    public int? RawMaterialProductionId { get; set; }

    /// <summary>
    /// Disassembly Order
    /// </summary>
    public int? UnbuildId { get; set; }

    /// <summary>
    /// Consumed Disassembly Order
    /// </summary>
    public int? ConsumeUnbuildId { get; set; }

    /// <summary>
    /// Operation To Consume
    /// </summary>
    public int? OperationId { get; set; }

    /// <summary>
    /// Work Order To Consume
    /// </summary>
    public int? WorkorderId { get; set; }

    /// <summary>
    /// BoM Line
    /// </summary>
    public int? BomLineId { get; set; }

    /// <summary>
    /// By-products
    /// </summary>
    public int? ByproductId { get; set; }

    /// <summary>
    /// Finished Lot/Serial Number
    /// </summary>
    public int? OrderFinishedLotId { get; set; }

    /// <summary>
    /// Cost Share (%)
    /// </summary>
    public decimal? CostShare { get; set; }

    /// <summary>
    /// Manual Consumption
    /// </summary>
    public bool? ManualConsumption { get; set; }

    /// <summary>
    /// Repair
    /// </summary>
    public int? RepairId { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual AccountAnalyticLine? AnalyticAccountLine { get; set; }

    public virtual MrpBomLine? BomLine { get; set; }

    public virtual MrpBomByproduct? Byproduct { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual MrpUnbuild? ConsumeUnbuild { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProduction? CreatedProduction { get; set; }

    public virtual PurchaseOrderLine? CreatedPurchaseLine { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual ICollection<StockMove> InverseOriginReturnedMove { get; set; } = new List<StockMove>();

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    public virtual StockLot? OrderFinishedLot { get; set; }

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    public virtual StockMove? OriginReturnedMove { get; set; }

    public virtual StockPackageLevel? PackageLevel { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual StockPickingType? PickingType { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductPackaging? ProductPackaging { get; set; }

    public virtual UomUom ProductUomNavigation { get; set; } = null!;

    public virtual MrpProduction? Production { get; set; }

    public virtual PurchaseOrderLine? PurchaseLine { get; set; }

    public virtual MrpProduction? RawMaterialProduction { get; set; }

    public virtual RepairOrder? Repair { get; set; }

    public virtual ICollection<RepairLine> RepairLines { get; set; } = new List<RepairLine>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ResPartner? RestrictPartner { get; set; }

    public virtual StockRule? Rule { get; set; }

    public virtual SaleOrderLine? SaleLine { get; set; }

    public virtual ICollection<StockAssignSerial> StockAssignSerials { get; set; } = new List<StockAssignSerial>();

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; set; } = new List<StockReturnPickingLine>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; set; } = new List<StockValuationLayer>();

    public virtual MrpUnbuild? Unbuild { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual MrpWorkorder? Workorder { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockMove> MoveDests { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> MoveOrigs { get; set; } = new List<StockMove>();

    public virtual ICollection<StockRoute> Routes { get; set; } = new List<StockRoute>();
}
