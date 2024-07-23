using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Template Attribute Line
/// </summary>
public partial class ProductTemplateAttributeLine
{
    public int Id { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int ProductTmplId { get; set; }

    /// <summary>
    /// Attribute
    /// </summary>
    public int AttributeId { get; set; }

    /// <summary>
    /// Value Count
    /// </summary>
    public int? ValueCount { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ProductAttribute Attribute { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; set; } = new List<ProductTemplateAttributeValue>();

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>();
}
