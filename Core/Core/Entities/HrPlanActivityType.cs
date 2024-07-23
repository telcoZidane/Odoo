using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Plan activity type
/// </summary>
public partial class HrPlanActivityType
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Activity Type
    /// </summary>
    public int? ActivityTypeId { get; set; }

    /// <summary>
    /// Other Responsible
    /// </summary>
    public int? ResponsibleId { get; set; }

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
    /// Summary
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public string Responsible { get; set; } = null!;

    /// <summary>
    /// Note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual MailActivityType? ActivityType { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrPlan? Plan { get; set; }

    public virtual ResUser? ResponsibleNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
