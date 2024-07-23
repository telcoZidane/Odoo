using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Note Stage
/// </summary>
public partial class NoteStage
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Stage Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Folded by Default
    /// </summary>
    public bool? Fold { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<NoteNote> Notes { get; set; } = new List<NoteNote>();
}
