using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Channel/Course Tag
/// </summary>
public partial class SlideChannelTag
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Group
    /// </summary>
    public int GroupId { get; set; }

    /// <summary>
    /// Group sequence
    /// </summary>
    public int? GroupSequence { get; set; }

    /// <summary>
    /// Color Index
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

    public virtual ResUser? CreateU { get; set; }

    public virtual SlideChannelTagGroup Group { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<SlideChannel> Channels { get; set; } = new List<SlideChannel>();
}
