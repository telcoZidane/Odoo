using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// E-Commerce Extra Info Shown on product page
/// </summary>
public partial class WebsiteSaleExtraField
{
    public int Id { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int FieldId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField Field { get; set; } = null!;

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
