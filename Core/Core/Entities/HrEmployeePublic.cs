using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class HrEmployeePublic
{
    public string? Name { get; set; }

    public bool? Active { get; set; }

    public int? Color { get; set; }

    public int? DepartmentId { get; set; }

    public int? JobId { get; set; }

    public string? JobTitle { get; set; }

    public int? CompanyId { get; set; }

    public int? AddressId { get; set; }

    public string? WorkPhone { get; set; }

    public string? MobilePhone { get; set; }

    public string? WorkEmail { get; set; }

    public int? WorkContactId { get; set; }

    public int? WorkLocationId { get; set; }

    public int? UserId { get; set; }

    public int? ResourceId { get; set; }

    public int? ResourceCalendarId { get; set; }

    public int? ParentId { get; set; }

    public int? CoachId { get; set; }

    public string? EmployeeType { get; set; }

    public int? LeaveManagerId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Id { get; set; }

    public int? CreateUid { get; set; }

    public int? WriteUid { get; set; }

    public DateTime? WriteDate { get; set; }

    public DateOnly? FirstContractDate { get; set; }

    public string? MobilityCard { get; set; }

    public int? ExpenseManagerId { get; set; }
}
