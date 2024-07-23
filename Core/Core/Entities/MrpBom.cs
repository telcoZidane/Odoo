using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Bill of Material
/// </summary>
public partial class MrpBom
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductTmplId { get; set; }

    /// <summary>
    /// Product Variant
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Operation Type
    /// </summary>
    public int? PickingTypeId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

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
    public string? Code { get; set; }

    /// <summary>
    /// BoM Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Manufacturing Readiness
    /// </summary>
    public string ReadyToProduce { get; set; } = null!;

    /// <summary>
    /// Flexible Consumption
    /// </summary>
    public string Consumption { get; set; } = null!;

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductQty { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Operation Dependencies
    /// </summary>
    public bool? AllowOperationDependencies { get; set; }

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

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; set; } = new List<MrpBomByproduct>();

    public virtual ICollection<MrpBomLine> MrpBomLines { get; set; } = new List<MrpBomLine>();

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenters { get; set; } = new List<MrpRoutingWorkcenter>();

    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; set; } = new List<MrpUnbuild>();

    public virtual StockPickingType? PickingType { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual UomUom ProductUom { get; set; } = null!;

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ResUser? WriteU { get; set; }
}
