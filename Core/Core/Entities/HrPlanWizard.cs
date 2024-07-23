using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Plan Wizard
/// </summary>
public partial class HrPlanWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Plan
    /// </summary>
    public int? PlanId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrPlan? Plan { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrEmployee> PlanWizards { get; set; } = new List<HrEmployee>();
}
