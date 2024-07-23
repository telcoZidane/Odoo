using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class HrLeaveEmployeeTypeReport
{
    public long? Id { get; set; }

    public int? EmployeeId { get; set; }

    public bool? ActiveEmployee { get; set; }

    public double? NumberOfDays { get; set; }

    public int? DepartmentId { get; set; }

    public int? LeaveType { get; set; }

    public string? HolidayStatus { get; set; }

    public string? State { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public int? CompanyId { get; set; }
}
