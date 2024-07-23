using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Picking Type
/// </summary>
public partial class StockPickingType
{
    public int Id { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Reference Sequence
    /// </summary>
    public int? SequenceId { get; set; }

    /// <summary>
    /// Default Source Location
    /// </summary>
    public int? DefaultLocationSrcId { get; set; }

    /// <summary>
    /// Default Destination Location
    /// </summary>
    public int? DefaultLocationDestId { get; set; }

    /// <summary>
    /// Operation Type for Returns
    /// </summary>
    public int? ReturnPickingTypeId { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Days
    /// </summary>
    public int? ReservationDaysBefore { get; set; }

    /// <summary>
    /// Days when starred
    /// </summary>
    public int? ReservationDaysBeforePriority { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Sequence Prefix
    /// </summary>
    public string SequenceCode { get; set; } = null!;

    /// <summary>
    /// Type of Operation
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Reservation Method
    /// </summary>
    public string ReservationMethod { get; set; } = null!;

    /// <summary>
    /// Barcode
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// Create Backorder
    /// </summary>
    public string CreateBackorder { get; set; } = null!;

    /// <summary>
    /// Operation Type
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Move Entire Packages
    /// </summary>
    public bool? ShowEntirePacks { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Create New Lots/Serial Numbers
    /// </summary>
    public bool? UseCreateLots { get; set; }

    /// <summary>
    /// Use Existing Lots/Serial Numbers
    /// </summary>
    public bool? UseExistingLots { get; set; }

    /// <summary>
    /// Print Label
    /// </summary>
    public bool? PrintLabel { get; set; }

    /// <summary>
    /// Show Detailed Operations
    /// </summary>
    public bool? ShowOperations { get; set; }

    /// <summary>
    /// Pre-fill Detailed Operations
    /// </summary>
    public bool? ShowReserved { get; set; }

    /// <summary>
    /// Show Reception Report at Validation
    /// </summary>
    public bool? AutoShowReceptionReport { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Create New Lots/Serial Numbers for Components
    /// </summary>
    public bool? UseCreateComponentsLots { get; set; }

    /// <summary>
    /// Consume Reserved Lots/Serial Numbers automatically
    /// </summary>
    public bool? UseAutoConsumeComponentsLots { get; set; }

    /// <summary>
    /// Create Repair Orders from Returns
    /// </summary>
    public bool? IsRepairable { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? DefaultLocationDest { get; set; }

    public virtual StockLocation? DefaultLocationSrc { get; set; }

    public virtual ICollection<StockPickingType> InverseReturnPickingType { get; set; } = new List<StockPickingType>();

    public virtual ICollection<MrpBom> MrpBoms { get; set; } = new List<MrpBom>();

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual StockPickingType? ReturnPickingType { get; set; }

    public virtual IrSequence? SequenceNavigation { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockRule> StockRules { get; set; } = new List<StockRule>();

    public virtual ICollection<StockWarehouse> StockWarehouseInTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseIntTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseManuTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseOutTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePackTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePbmTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePickTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePosTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseReturnTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseSamTypes { get; set; } = new List<StockWarehouse>();

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
