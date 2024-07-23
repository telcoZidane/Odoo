﻿using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Theme Attachments
/// </summary>
public partial class ThemeIrAttachment
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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Key
    /// </summary>
    public string Key { get; set; } = null!;

    /// <summary>
    /// Url
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrAttachment> IrAttachments { get; set; } = new List<IrAttachment>();

    public virtual ResUser? WriteU { get; set; }
}
