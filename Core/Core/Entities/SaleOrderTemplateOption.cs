using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Quotation Template Option
/// </summary>
public partial class SaleOrderTemplateOption
{
    public int Id { get; set; }

    /// <summary>
    /// Quotation Template Reference
    /// </summary>
    public int SaleOrderTemplateId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int UomId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal Quantity { get; set; }

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

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual SaleOrderTemplate SaleOrderTemplate { get; set; } = null!;

    public virtual UomUom Uom { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
