using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Email Aliases
/// </summary>
public partial class MailAlias
{
    public int Id { get; set; }

    /// <summary>
    /// Aliased Model
    /// </summary>
    public int AliasModelId { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? AliasUserId { get; set; }

    /// <summary>
    /// Record Thread ID
    /// </summary>
    public int? AliasForceThreadId { get; set; }

    /// <summary>
    /// Parent Model
    /// </summary>
    public int? AliasParentModelId { get; set; }

    /// <summary>
    /// Parent Record Thread ID
    /// </summary>
    public int? AliasParentThreadId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Alias Name
    /// </summary>
    public string? AliasName { get; set; }

    /// <summary>
    /// Alias Contact Security
    /// </summary>
    public string AliasContact { get; set; } = null!;

    /// <summary>
    /// Custom Bounced Message
    /// </summary>
    public string? AliasBouncedContent { get; set; }

    /// <summary>
    /// Default Values
    /// </summary>
    public string AliasDefaults { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();

    public virtual IrModel AliasModel { get; set; } = null!;

    public virtual IrModel? AliasParentModel { get; set; }

    public virtual ResUser? AliasUser { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmTeam> CrmTeams { get; set; } = new List<CrmTeam>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrRecruitmentSource> HrRecruitmentSources { get; set; } = new List<HrRecruitmentSource>();

    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategories { get; set; } = new List<MaintenanceEquipmentCategory>();

    public virtual ICollection<ProjectProject> ProjectProjects { get; set; } = new List<ProjectProject>();

    public virtual ResUser? WriteU { get; set; }
}
