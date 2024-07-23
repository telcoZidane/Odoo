using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Analytic Plan&apos;s Applicabilities
/// </summary>
public partial class AccountAnalyticApplicability
{
    public int Id { get; set; }

    /// <summary>
    /// Analytic Plan
    /// </summary>
    public int? AnalyticPlanId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Domain
    /// </summary>
    public string BusinessDomain { get; set; } = null!;

    /// <summary>
    /// Applicability
    /// </summary>
    public string Applicability { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int? ProductCategId { get; set; }

    /// <summary>
    /// Financial Accounts Prefix
    /// </summary>
    public string? AccountPrefix { get; set; }

    public virtual AccountAnalyticPlan? AnalyticPlan { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductCategory? ProductCateg { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
