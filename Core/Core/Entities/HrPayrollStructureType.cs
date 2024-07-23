using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Salary Structure Type
/// </summary>
public partial class HrPayrollStructureType
{
    public int Id { get; set; }

    /// <summary>
    /// Default Working Hours
    /// </summary>
    public int? DefaultResourceCalendarId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Salary Structure Type
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceCalendar? DefaultResourceCalendar { get; set; }

    public virtual ICollection<HrContract> HrContracts { get; set; } = new List<HrContract>();

    public virtual ResUser? WriteU { get; set; }
}
