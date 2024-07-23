using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Channel / Partners (Members)
/// </summary>
public partial class SlideChannelPartner
{
    public int Id { get; set; }

    /// <summary>
    /// Channel
    /// </summary>
    public int ChannelId { get; set; }

    /// <summary>
    /// % Completed Slides
    /// </summary>
    public int? Completion { get; set; }

    /// <summary>
    /// # Completed Slides
    /// </summary>
    public int? CompletedSlidesCount { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Is Completed
    /// </summary>
    public bool? Completed { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual SlideChannel Channel { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
