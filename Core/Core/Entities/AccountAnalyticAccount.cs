using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Analytic Account
/// </summary>
public partial class AccountAnalyticAccount
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Plan
    /// </summary>
    public int PlanId { get; set; }

    /// <summary>
    /// Root Plan
    /// </summary>
    public int? RootPlanId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Analytic Account
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Reference
    /// </summary>
    public string? Code { get; set; }

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

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; set; } = new List<MrpWorkcenter>();

    public virtual ResPartner? Partner { get; set; }

    public virtual AccountAnalyticPlan Plan { get; set; } = null!;

    public virtual ICollection<ProjectProject> ProjectProjects { get; set; } = new List<ProjectProject>();

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual AccountAnalyticPlan? RootPlan { get; set; }

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }
}
