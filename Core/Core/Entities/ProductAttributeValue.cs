using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Attribute Value
/// </summary>
public partial class ProductAttributeValue
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Attribute
    /// </summary>
    public int AttributeId { get; set; }

    /// <summary>
    /// Color Index
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
    /// Color
    /// </summary>
    public string? HtmlColor { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Is custom value
    /// </summary>
    public bool? IsCustom { get; set; }

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

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLines { get; set; } = new List<ProductTemplateAttributeLine>();
}
