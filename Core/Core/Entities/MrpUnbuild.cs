using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Unbuild Order
/// </summary>
public partial class MrpUnbuild
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
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// Bill of Material
    /// </summary>
    public int? BomId { get; set; }

    /// <summary>
    /// Manufacturing Order
    /// </summary>
    public int? MoId { get; set; }

    /// <summary>
    /// Lot/Serial Number
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Source Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Destination Location
    /// </summary>
    public int LocationDestId { get; set; }

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
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public double ProductQty { get; set; }

    public virtual MrpBom? Bom { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual StockLot? Lot { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual MrpProduction? Mo { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual UomUom ProductUom { get; set; } = null!;

    public virtual ICollection<StockMove> StockMoveConsumeUnbuilds { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMoveUnbuilds { get; set; } = new List<StockMove>();

    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuilds { get; set; } = new List<StockWarnInsufficientQtyUnbuild>();

    public virtual ResUser? WriteU { get; set; }
}
