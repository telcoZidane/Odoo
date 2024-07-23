using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Resource Time Off Detail
/// </summary>
public partial class ResourceCalendarLeaf
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Working Hours
    /// </summary>
    public int? CalendarId { get; set; }

    /// <summary>
    /// Resource
    /// </summary>
    public int? ResourceId { get; set; }

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
    public string? Name { get; set; }

    /// <summary>
    /// Time Type
    /// </summary>
    public string? TimeType { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime DateFrom { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateTime DateTo { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Leave Request
    /// </summary>
    public int? HolidayId { get; set; }

    public virtual ResourceCalendar? Calendar { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrLeave? Holiday { get; set; }

    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; set; } = new List<MrpWorkorder>();

    public virtual ResourceResource? Resource { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
