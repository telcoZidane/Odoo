using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class HrEmployeeSkillReport
{
    public long? Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? CompanyId { get; set; }

    public int? DepartmentId { get; set; }

    public int? SkillId { get; set; }

    public int? SkillTypeId { get; set; }

    public decimal? LevelProgress { get; set; }

    public string? SkillLevel { get; set; }
}
