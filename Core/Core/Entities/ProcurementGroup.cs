using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Procurement Group
/// </summary>
public partial class ProcurementGroup
{
    public int Id { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

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
    public string Name { get; set; } = null!;

    /// <summary>
    /// Delivery Type
    /// </summary>
    public string MoveType { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Sale Order
    /// </summary>
    public int? SaleId { get; set; }

    /// <summary>
    /// POS Order
    /// </summary>
    public int? PosOrderId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ResPartner? Partner { get; set; }

    public virtual PosOrder? PosOrder { get; set; }

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual SaleOrder? Sale { get; set; }

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockRule> StockRules { get; set; } = new List<StockRule>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ResUser? WriteU { get; set; }
}
