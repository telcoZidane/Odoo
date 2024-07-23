using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Production Order
/// </summary>
public partial class MrpProduction
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Backorder Sequence
    /// </summary>
    public int? BackorderSequence { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Product Unit of Measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// Lot/Serial Number
    /// </summary>
    public int? LotProducingId { get; set; }

    /// <summary>
    /// Operation Type
    /// </summary>
    public int PickingTypeId { get; set; }

    /// <summary>
    /// Components Location
    /// </summary>
    public int LocationSrcId { get; set; }

    /// <summary>
    /// Finished Products Location
    /// </summary>
    public int LocationDestId { get; set; }

    /// <summary>
    /// Bill of Material
    /// </summary>
    public int? BomId { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? ProcurementGroupId { get; set; }

    /// <summary>
    /// Orderpoint
    /// </summary>
    public int? OrderpointId { get; set; }

    /// <summary>
    /// Production Location
    /// </summary>
    public int? ProductionLocationId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// MO Readiness
    /// </summary>
    public string? ReservationState { get; set; }

    /// <summary>
    /// Custom Description
    /// </summary>
    public string? ProductDescriptionVariants { get; set; }

    /// <summary>
    /// Consumption
    /// </summary>
    public string Consumption { get; set; } = null!;

    /// <summary>
    /// Quantity To Produce
    /// </summary>
    public decimal ProductQty { get; set; }

    /// <summary>
    /// Quantity Producing
    /// </summary>
    public decimal? QtyProducing { get; set; }

    /// <summary>
    /// Propagate cancel and split
    /// </summary>
    public bool? PropagateCancel { get; set; }

    /// <summary>
    /// Is Locked
    /// </summary>
    public bool? IsLocked { get; set; }

    /// <summary>
    /// Its Operations are Planned
    /// </summary>
    public bool? IsPlanned { get; set; }

    /// <summary>
    /// Allow Work Order Dependencies
    /// </summary>
    public bool? AllowWorkorderDependencies { get; set; }

    /// <summary>
    /// Scheduled Date
    /// </summary>
    public DateTime DatePlannedStart { get; set; }

    /// <summary>
    /// Scheduled End Date
    /// </summary>
    public DateTime? DatePlannedFinished { get; set; }

    /// <summary>
    /// Deadline
    /// </summary>
    public DateTime? DateDeadline { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateTime? DateFinished { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Total Quantity
    /// </summary>
    public double? ProductUomQty { get; set; }

    /// <summary>
    /// Analytic Account
    /// </summary>
    public int? AnalyticAccountId { get; set; }

    /// <summary>
    /// Extra Unit Cost
    /// </summary>
    public double? ExtraCost { get; set; }

    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    public virtual MrpBom? Bom { get; set; }

    public virtual ICollection<ChangeProductionQty> ChangeProductionQties { get; set; } = new List<ChangeProductionQty>();

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual StockLocation LocationSrc { get; set; } = null!;

    public virtual StockLot? LotProducing { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLines { get; set; } = new List<MrpConsumptionWarningLine>();

    public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLines { get; set; } = new List<MrpImmediateProductionLine>();

    public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLines { get; set; } = new List<MrpProductionBackorderLine>();

    public virtual ICollection<MrpProductionSplit> MrpProductionSplits { get; set; } = new List<MrpProductionSplit>();

    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; set; } = new List<MrpUnbuild>();

    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; set; } = new List<MrpWorkorder>();

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    public virtual StockPickingType PickingType { get; set; } = null!;

    public virtual ProcurementGroup? ProcurementGroup { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual UomUom ProductUom { get; set; } = null!;

    public virtual StockLocation? ProductionLocation { get; set; }

    public virtual ICollection<StockAssignSerial> StockAssignSerials { get; set; } = new List<StockAssignSerial>();

    public virtual ICollection<StockMove> StockMoveCreatedProductions { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoveProductions { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMoveRawMaterialProductions { get; set; } = new List<StockMove>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpConsumptionWarning> MrpConsumptionWarnings { get; set; } = new List<MrpConsumptionWarning>();

    public virtual ICollection<MrpImmediateProduction> MrpImmediateProductions { get; set; } = new List<MrpImmediateProduction>();

    public virtual ICollection<MrpProductionBackorder> MrpProductionBackorders { get; set; } = new List<MrpProductionBackorder>();
}
