using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Template Attribute Value
/// </summary>
public partial class ProductTemplateAttributeValue
{
    public int Id { get; set; }

    /// <summary>
    /// Attribute Value
    /// </summary>
    public int ProductAttributeValueId { get; set; }

    /// <summary>
    /// Attribute Line
    /// </summary>
    public int AttributeLineId { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int? ProductTmplId { get; set; }

    /// <summary>
    /// Attribute
    /// </summary>
    public int? AttributeId { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Value Price Extra
    /// </summary>
    public decimal? PriceExtra { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? PtavActive { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ProductAttribute? Attribute { get; set; }

    public virtual ProductTemplateAttributeLine AttributeLine { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValues { get; set; } = new List<ProductAttributeCustomValue>();

    public virtual ProductAttributeValue ProductAttributeValue { get; set; } = null!;

    public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusionsNavigation { get; set; } = new List<ProductTemplateAttributeExclusion>();

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; set; } = new List<MrpBomByproduct>();

    public virtual ICollection<MrpBomLine> MrpBomLines { get; set; } = new List<MrpBomLine>();

    public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenters { get; set; } = new List<MrpRoutingWorkcenter>();

    public virtual ICollection<ProductProduct> ProductProducts { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusions { get; set; } = new List<ProductTemplateAttributeExclusion>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();
}
