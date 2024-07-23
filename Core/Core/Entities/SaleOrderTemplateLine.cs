using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Quotation Template Line
/// </summary>
public partial class SaleOrderTemplateLine
{
    public int Id { get; set; }

    /// <summary>
    /// Quotation Template Reference
    /// </summary>
    public int SaleOrderTemplateId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int? ProductUomId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Display Type
    /// </summary>
    public string? DisplayType { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductUomQty { get; set; }

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

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual SaleOrderTemplate SaleOrderTemplate { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
