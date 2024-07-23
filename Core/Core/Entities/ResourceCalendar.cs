using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Resource Working Time
/// </summary>
public partial class ResourceCalendar
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

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
    /// Timezone
    /// </summary>
    public string Tz { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Calendar in 2 weeks mode
    /// </summary>
    public bool? TwoWeeksCalendar { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Average Hour per Day
    /// </summary>
    public double? HoursPerDay { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrContract> HrContracts { get; set; } = new List<HrContract>();

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDays { get; set; } = new List<HrLeaveStressDay>();

    public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypes { get; set; } = new List<HrPayrollStructureType>();

    public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; set; } = new List<MrpWorkcenter>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendances { get; set; } = new List<ResourceCalendarAttendance>();

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ICollection<ResourceResource> ResourceResources { get; set; } = new List<ResourceResource>();

    public virtual ResUser? WriteU { get; set; }
}
