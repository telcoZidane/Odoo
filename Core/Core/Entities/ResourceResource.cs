using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Resources
/// </summary>
public partial class ResourceResource
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Working Time
    /// </summary>
    public int CalendarId { get; set; }

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
    /// Type
    /// </summary>
    public string ResourceType { get; set; } = null!;

    /// <summary>
    /// Timezone
    /// </summary>
    public string Tz { get; set; } = null!;

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

    /// <summary>
    /// Efficiency Factor
    /// </summary>
    public double TimeEfficiency { get; set; }

    public virtual ResourceCalendar Calendar { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; set; } = new List<MrpWorkcenter>();

    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendances { get; set; } = new List<ResourceCalendarAttendance>();

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
