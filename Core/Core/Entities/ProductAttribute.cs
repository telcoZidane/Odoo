using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Attribute
/// </summary>
public partial class ProductAttribute
{
    public int Id { get; set; }

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
    /// Variants Creation Mode
    /// </summary>
    public string CreateVariant { get; set; } = null!;

    /// <summary>
    /// Display Type
    /// </summary>
    public string DisplayType { get; set; } = null!;

    /// <summary>
    /// Attribute
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Visibility
    /// </summary>
    public string? Visibility { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>();

    public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLines { get; set; } = new List<ProductTemplateAttributeLine>();

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; set; } = new List<ProductTemplateAttributeValue>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();
}
