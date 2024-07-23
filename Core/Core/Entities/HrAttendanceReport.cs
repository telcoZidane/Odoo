using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class HrAttendanceReport
{
    public int? Id { get; set; }

    public int? DepartmentId { get; set; }

    public int? EmployeeId { get; set; }

    public int? CompanyId { get; set; }

    public DateOnly? CheckIn { get; set; }

    public double? WorkedHours { get; set; }

    public double? OvertimeHours { get; set; }
}
