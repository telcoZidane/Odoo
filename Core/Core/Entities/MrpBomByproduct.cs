using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Byproduct
/// </summary>
public partial class MrpBomByproduct
{
    public int Id { get; set; }

    /// <summary>
    /// By-product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// BoM
    /// </summary>
    public int? BomId { get; set; }

    /// <summary>
    /// Produced in Operation
    /// </summary>
    public int? OperationId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

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
    /// Cost Share (%)
    /// </summary>
    public decimal? CostShare { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual MrpBom? Bom { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual UomUom ProductUom { get; set; } = null!;

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; set; } = new List<ProductTemplateAttributeValue>();
}
