using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Analytic Plans
/// </summary>
public partial class AccountAnalyticPlan
{
    public int Id { get; set; }

    /// <summary>
    /// Parent
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public int? Color { get; set; }

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
    /// Parent Path
    /// </summary>
    public string? ParentPath { get; set; }

    /// <summary>
    /// Complete Name
    /// </summary>
    public string? CompleteName { get; set; }

    /// <summary>
    /// Default Applicability
    /// </summary>
    public string DefaultApplicability { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountPlans { get; set; } = new List<AccountAnalyticAccount>();

    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountRootPlans { get; set; } = new List<AccountAnalyticAccount>();

    public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilities { get; set; } = new List<AccountAnalyticApplicability>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<AccountAnalyticPlan> InverseParent { get; set; } = new List<AccountAnalyticPlan>();

    public virtual AccountAnalyticPlan? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
