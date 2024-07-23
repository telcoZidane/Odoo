using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Tag Category
/// </summary>
public partial class EventTagCategory
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
    /// Name
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
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<EventTag> EventTags { get; set; } = new List<EventTag>();

    public virtual ResUser? WriteU { get; set; }
}
