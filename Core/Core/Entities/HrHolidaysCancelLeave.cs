using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Cancel Leave Wizard
/// </summary>
public partial class HrHolidaysCancelLeave
{
    public int Id { get; set; }

    /// <summary>
    /// Leave
    /// </summary>
    public int LeaveId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Reason
    /// </summary>
    public string Reason { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrLeave Leave { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
