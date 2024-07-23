using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Template Attribute Exclusion
/// </summary>
public partial class ProductTemplateAttributeExclusion
{
    public int Id { get; set; }

    /// <summary>
    /// Attribute Value
    /// </summary>
    public int? ProductTemplateAttributeValueId { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int ProductTmplId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplateAttributeValue? ProductTemplateAttributeValue { get; set; }

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; set; } = new List<ProductTemplateAttributeValue>();
}
