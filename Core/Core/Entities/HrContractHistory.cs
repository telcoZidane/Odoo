using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class HrContractHistory
{
    public int? Id { get; set; }

    public int? EmployeeId { get; set; }

    public bool? ActiveEmployee { get; set; }

    public int? ContractId { get; set; }

    public bool? IsUnderContract { get; set; }

    public DateOnly? DateHired { get; set; }

    public string? Name { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public int? DepartmentId { get; set; }

    public int? StructureTypeId { get; set; }

    public int? HrResponsibleId { get; set; }

    public int? JobId { get; set; }

    public string? State { get; set; }

    public int? ResourceCalendarId { get; set; }

    public decimal? Wage { get; set; }

    public int? CompanyId { get; set; }

    public int? ContractTypeId { get; set; }
}
