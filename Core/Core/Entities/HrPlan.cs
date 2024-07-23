using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// plan
/// </summary>
public partial class HrPlan
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

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

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypes { get; set; } = new List<HrPlanActivityType>();

    public virtual ICollection<HrPlanWizard> HrPlanWizards { get; set; } = new List<HrPlanWizard>();

    public virtual ResUser? WriteU { get; set; }
}
