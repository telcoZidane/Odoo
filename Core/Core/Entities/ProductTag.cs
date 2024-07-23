using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Tag
/// </summary>
public partial class ProductTag
{
    public int Id { get; set; }

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
    /// Tag Name
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
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Ribbon
    /// </summary>
    public int? RibbonId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductRibbon? Ribbon { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductProduct> ProductProducts { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();
}
