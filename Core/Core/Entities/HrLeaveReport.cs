using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class HrLeaveReport
{
    public long? Id { get; set; }

    public int? AllocationId { get; set; }

    public int? LeaveId { get; set; }

    public int? EmployeeId { get; set; }

    public string? Name { get; set; }

    public bool? ActiveEmployee { get; set; }

    public bool? Active { get; set; }

    public double? NumberOfDays { get; set; }

    public string? LeaveType { get; set; }

    public int? CategoryId { get; set; }

    public int? DepartmentId { get; set; }

    public int? HolidayStatusId { get; set; }

    public string? State { get; set; }

    public string? HolidayType { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public int? CompanyId { get; set; }
}
