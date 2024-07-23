using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Filters
/// </summary>
public partial class IrFilter
{
    public int Id { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public int? ActionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Filter Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Model
    /// </summary>
    public string ModelId { get; set; } = null!;

    /// <summary>
    /// Domain
    /// </summary>
    public string Domain { get; set; } = null!;

    /// <summary>
    /// Context
    /// </summary>
    public string Context { get; set; } = null!;

    /// <summary>
    /// Sort
    /// </summary>
    public string Sort { get; set; } = null!;

    /// <summary>
    /// Default Filter
    /// </summary>
    public bool? IsDefault { get; set; }

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

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilters { get; set; } = new List<WebsiteSnippetFilter>();

    public virtual ResUser? WriteU { get; set; }
}
