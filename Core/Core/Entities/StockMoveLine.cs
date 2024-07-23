using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Moves (Stock Move Line)
/// </summary>
public partial class StockMoveLine
{
    public int Id { get; set; }

    /// <summary>
    /// Transfer
    /// </summary>
    public int? PickingId { get; set; }

    /// <summary>
    /// Stock Operation
    /// </summary>
    public int? MoveId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// Source Package
    /// </summary>
    public int? PackageId { get; set; }

    /// <summary>
    /// Package Level
    /// </summary>
    public int? PackageLevelId { get; set; }

    /// <summary>
    /// Lot/Serial Number
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Destination Package
    /// </summary>
    public int? ResultPackageId { get; set; }

    /// <summary>
    /// From Owner
    /// </summary>
    public int? OwnerId { get; set; }

    /// <summary>
    /// From
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// To
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
    /// Product Category
    /// </summary>
    public string? ProductCategoryName { get; set; }

    /// <summary>
    /// Lot/Serial Number Name
    /// </summary>
    public string? LotName { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// Description picking
    /// </summary>
    public string? DescriptionPicking { get; set; }

    /// <summary>
    /// Real Reserved Quantity
    /// </summary>
    public decimal? ReservedQty { get; set; }

    /// <summary>
    /// Reserved
    /// </summary>
    public decimal ReservedUomQty { get; set; }

    /// <summary>
    /// Done
    /// </summary>
    public decimal? QtyDone { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Work Order
    /// </summary>
    public int? WorkorderId { get; set; }

    /// <summary>
    /// Production Order
    /// </summary>
    public int? ProductionId { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual StockLot? Lot { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual StockPackageLevel? PackageLevel { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom ProductUom { get; set; } = null!;

    public virtual MrpProduction? Production { get; set; }

    public virtual StockQuantPackage? ResultPackage { get; set; }

    public virtual MrpWorkorder? Workorder { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockMoveLine> ConsumeLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMoveLine> ProduceLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<ProductLabelLayout> ProductLabelLayouts { get; set; } = new List<ProductLabelLayout>();
}
