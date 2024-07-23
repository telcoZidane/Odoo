using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Channel/Course Groups
/// </summary>
public partial class SlideChannelTagGroup
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Group Name
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

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<SlideChannelTag> SlideChannelTags { get; set; } = new List<SlideChannelTag>();

    public virtual ResUser? WriteU { get; set; }
}
