using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Production Document
/// </summary>
public partial class MrpDocument
{
    public int Id { get; set; }

    /// <summary>
    /// Related attachment
    /// </summary>
    public int IrAttachmentId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

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

    public virtual IrAttachment IrAttachment { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
