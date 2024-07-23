using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock Rule
/// </summary>
public partial class StockRule
{
    public int Id { get; set; }

    /// <summary>
    /// Fixed Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Destination Location
    /// </summary>
    public int LocationDestId { get; set; }

    /// <summary>
    /// Source Location
    /// </summary>
    public int? LocationSrcId { get; set; }

    /// <summary>
    /// Route
    /// </summary>
    public int RouteId { get; set; }

    /// <summary>
    /// Route Sequence
    /// </summary>
    public int? RouteSequence { get; set; }

    /// <summary>
    /// Operation Type
    /// </summary>
    public int PickingTypeId { get; set; }

    /// <summary>
    /// Lead Time
    /// </summary>
    public int? Delay { get; set; }

    /// <summary>
    /// Partner Address
    /// </summary>
    public int? PartnerAddressId { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Warehouse to Propagate
    /// </summary>
    public int? PropagateWarehouseId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Propagation of Procurement Group
    /// </summary>
    public string? GroupPropagationOption { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public string Action { get; set; } = null!;

    /// <summary>
    /// Supply Method
    /// </summary>
    public string ProcureMethod { get; set; } = null!;

    /// <summary>
    /// Automatic Move
    /// </summary>
    public string Auto { get; set; } = null!;

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Cancel Next Move
    /// </summary>
    public bool? PropagateCancel { get; set; }

    /// <summary>
    /// Propagation of carrier
    /// </summary>
    public bool? PropagateCarrier { get; set; }

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

    public virtual ProcurementGroup? Group { get; set; }

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual StockLocation? LocationSrc { get; set; }

    public virtual ResPartner? PartnerAddress { get; set; }

    public virtual StockPickingType PickingType { get; set; } = null!;

    public virtual StockWarehouse? PropagateWarehouse { get; set; }

    public virtual StockRoute Route { get; set; } = null!;

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockWarehouse> StockWarehouseBuyPulls { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseManufactureMtoPulls { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseManufacturePulls { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseMtoPulls { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePbmMtoPulls { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseSamRules { get; set; } = new List<StockWarehouse>();

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
