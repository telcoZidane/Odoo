using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class HrLeaveReportCalendar
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public DateTime? StartDatetime { get; set; }

    public DateTime? StopDatetime { get; set; }

    public int? EmployeeId { get; set; }

    public string? State { get; set; }

    public int? DepartmentId { get; set; }

    public double? Duration { get; set; }

    public int? CompanyId { get; set; }

    public int? JobId { get; set; }

    public string? Tz { get; set; }

    public bool? IsStriked { get; set; }

    public bool? IsHatched { get; set; }
}
