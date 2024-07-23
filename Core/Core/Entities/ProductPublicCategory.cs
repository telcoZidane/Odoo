using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website Product Category
/// </summary>
public partial class ProductPublicCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Parent Category
    /// </summary>
    public int? ParentId { get; set; }

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
    /// Website opengraph image
    /// </summary>
    public string? WebsiteMetaOgImg { get; set; }

    /// <summary>
    /// Parent Path
    /// </summary>
    public string? ParentPath { get; set; }

    /// <summary>
    /// Website meta title
    /// </summary>
    public string? WebsiteMetaTitle { get; set; }

    /// <summary>
    /// Website meta description
    /// </summary>
    public string? WebsiteMetaDescription { get; set; }

    /// <summary>
    /// Website meta keywords
    /// </summary>
    public string? WebsiteMetaKeywords { get; set; }

    /// <summary>
    /// Seo name
    /// </summary>
    public string? SeoName { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Category Description
    /// </summary>
    public string? WebsiteDescription { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductPublicCategory> InverseParent { get; set; } = new List<ProductPublicCategory>();

    public virtual ProductPublicCategory? Parent { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();
}
