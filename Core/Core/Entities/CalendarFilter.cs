using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Calendar Filters
/// </summary>
public partial class CalendarFilter
{
    public int Id { get; set; }

    /// <summary>
    /// Me
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Employee
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
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Checked
    /// </summary>
    public bool? PartnerChecked { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
