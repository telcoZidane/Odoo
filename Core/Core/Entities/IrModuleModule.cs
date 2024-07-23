﻿using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class IrModuleModule
{
    public int Id { get; set; }

    public int? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public int? WriteUid { get; set; }

    public string? Website { get; set; }

    public string? Summary { get; set; }

    public string Name { get; set; } = null!;

    public string? Author { get; set; }

    public string? Icon { get; set; }

    public string? State { get; set; }

    public string? LatestVersion { get; set; }

    public string? Shortdesc { get; set; }

    public int? CategoryId { get; set; }

    public string? Description { get; set; }

    public bool? Application { get; set; }

    public bool? Demo { get; set; }

    public bool? Web { get; set; }

    public string? License { get; set; }

    public int? Sequence { get; set; }

    public bool? AutoInstall { get; set; }

    public bool? ToBuy { get; set; }

    /// <summary>
    /// Maintainer
    /// </summary>
    public string? Maintainer { get; set; }

    /// <summary>
    /// Published Version
    /// </summary>
    public string? PublishedVersion { get; set; }

    /// <summary>
    /// URL
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Contributors
    /// </summary>
    public string? Contributors { get; set; }

    /// <summary>
    /// Menus
    /// </summary>
    public string? MenusByModule { get; set; }

    /// <summary>
    /// Reports
    /// </summary>
    public string? ReportsByModule { get; set; }

    /// <summary>
    /// Views
    /// </summary>
    public string? ViewsByModule { get; set; }

    public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequests { get; set; } = new List<BaseModuleInstallRequest>();

    public virtual ICollection<BaseModuleInstallReview> BaseModuleInstallReviews { get; set; } = new List<BaseModuleInstallReview>();

    public virtual ICollection<BaseModuleUninstall> BaseModuleUninstalls { get; set; } = new List<BaseModuleUninstall>();

    public virtual IrModuleCategory? Category { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrDemoFailure> IrDemoFailures { get; set; } = new List<IrDemoFailure>();

    public virtual ICollection<IrModelConstraint> IrModelConstraints { get; set; } = new List<IrModelConstraint>();

    public virtual ICollection<IrModelRelation> IrModelRelations { get; set; } = new List<IrModelRelation>();

    public virtual ICollection<IrModuleModuleDependency> IrModuleModuleDependencies { get; set; } = new List<IrModuleModuleDependency>();

    public virtual ICollection<IrModuleModuleExclusion> IrModuleModuleExclusions { get; set; } = new List<IrModuleModuleExclusion>();

    public virtual ICollection<PaymentProvider> PaymentProviders { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatures { get; set; } = new List<WebsiteConfiguratorFeature>();

    public virtual ICollection<Website> Websites { get; set; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<BaseLanguageExport> Wizs { get; set; } = new List<BaseLanguageExport>();
}
