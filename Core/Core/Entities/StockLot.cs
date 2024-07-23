using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Lot/Serial
/// </summary>
public partial class StockLot
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int? ProductUomId { get; set; }

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
    /// Lot/Serial Number
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Internal Reference
    /// </summary>
    public string? Ref { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; set; } = new List<MrpUnbuild>();

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual UomUom? ProductUom { get; set; }

    public virtual ICollection<RepairLine> RepairLines { get; set; } = new List<RepairLine>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual ResUser? WriteU { get; set; }
}
