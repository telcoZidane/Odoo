using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Scrap
/// </summary>
public partial class StockScrap
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// Lot/Serial
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Package
    /// </summary>
    public int? PackageId { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? OwnerId { get; set; }

    /// <summary>
    /// Scrap Move
    /// </summary>
    public int? MoveId { get; set; }

    /// <summary>
    /// Picking
    /// </summary>
    public int? PickingId { get; set; }

    /// <summary>
    /// Source Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Scrap Location
    /// </summary>
    public int ScrapLocationId { get; set; }

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
    /// Source Document
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ScrapQty { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime? DateDone { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Manufacturing Order
    /// </summary>
    public int? ProductionId { get; set; }

    /// <summary>
    /// Work Order
    /// </summary>
    public int? WorkorderId { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockLot? Lot { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual UomUom ProductUom { get; set; } = null!;

    public virtual MrpProduction? Production { get; set; }

    public virtual StockLocation ScrapLocation { get; set; } = null!;

    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScraps { get; set; } = new List<StockWarnInsufficientQtyScrap>();

    public virtual MrpWorkorder? Workorder { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
