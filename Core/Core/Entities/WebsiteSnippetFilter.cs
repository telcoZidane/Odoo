using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website Snippet Filter
/// </summary>
public partial class WebsiteSnippetFilter
{
    public int Id { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Server Action
    /// </summary>
    public int? ActionServerId { get; set; }

    /// <summary>
    /// Filter
    /// </summary>
    public int? FilterId { get; set; }

    /// <summary>
    /// Limit
    /// </summary>
    public int Limit { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Field Names
    /// </summary>
    public string FieldNames { get; set; } = null!;

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// About cross selling products
    /// </summary>
    public bool? ProductCrossSelling { get; set; }

    public virtual IrActServer? ActionServer { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrFilter? Filter { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
