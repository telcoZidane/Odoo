using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Bill of Material Line
/// </summary>
public partial class MrpBomLine
{
    public int Id { get; set; }

    /// <summary>
    /// Component
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int? ProductTmplId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Product Unit of Measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Parent BoM
    /// </summary>
    public int BomId { get; set; }

    /// <summary>
    /// Consumed in Operation
    /// </summary>
    public int? OperationId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductQty { get; set; }

    /// <summary>
    /// Manual Consumption
    /// </summary>
    public bool? ManualConsumption { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Cost Share (%)
    /// </summary>
    public decimal? CostShare { get; set; }

    public virtual MrpBom Bom { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual UomUom ProductUom { get; set; } = null!;

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; set; } = new List<ProductTemplateAttributeValue>();
}
