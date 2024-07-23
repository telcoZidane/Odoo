using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Attribute Custom Value
/// </summary>
public partial class ProductAttributeCustomValue
{
    public int Id { get; set; }

    /// <summary>
    /// Attribute Value
    /// </summary>
    public int CustomProductTemplateAttributeValueId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Custom Value
    /// </summary>
    public string? CustomValue { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Sales Order Line
    /// </summary>
    public int SaleOrderLineId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplateAttributeValue CustomProductTemplateAttributeValue { get; set; } = null!;

    public virtual SaleOrderLine SaleOrderLine { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
