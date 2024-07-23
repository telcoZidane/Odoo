using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Image
/// </summary>
public partial class ProductImage
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int? ProductTmplId { get; set; }

    /// <summary>
    /// Product Variant
    /// </summary>
    public int? ProductVariantId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Video URL
    /// </summary>
    public string? VideoUrl { get; set; }

    /// <summary>
    /// Can Image 1024 be zoomed
    /// </summary>
    public bool? CanImage1024BeZoomed { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ProductProduct? ProductVariant { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
