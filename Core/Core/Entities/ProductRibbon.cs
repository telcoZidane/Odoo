using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product ribbon
/// </summary>
public partial class ProductRibbon
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Ribbon background color
    /// </summary>
    public string? BgColor { get; set; }

    /// <summary>
    /// Ribbon text color
    /// </summary>
    public string? TextColor { get; set; }

    /// <summary>
    /// Ribbon class
    /// </summary>
    public string HtmlClass { get; set; } = null!;

    /// <summary>
    /// Ribbon html
    /// </summary>
    public string Html { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

    public virtual ResUser? WriteU { get; set; }
}
