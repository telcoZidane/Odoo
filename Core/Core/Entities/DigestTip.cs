using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Digest Tips
/// </summary>
public partial class DigestTip
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Authorized Group
    /// </summary>
    public int? GroupId { get; set; }

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
    public string? Name { get; set; }

    /// <summary>
    /// Tip description
    /// </summary>
    public string? TipDescription { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResGroup? Group { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();
}
