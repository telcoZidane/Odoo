using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website Configurator Feature
/// </summary>
public partial class WebsiteConfiguratorFeature
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Page View
    /// </summary>
    public int? PageViewId { get; set; }

    /// <summary>
    /// Module
    /// </summary>
    public int? ModuleId { get; set; }

    /// <summary>
    /// Menu Sequence
    /// </summary>
    public int? MenuSequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Icon
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Iap Page Code
    /// </summary>
    public string? IapPageCode { get; set; }

    /// <summary>
    /// Website Config Preselection
    /// </summary>
    public string? WebsiteConfigPreselection { get; set; }

    /// <summary>
    /// Feature Url
    /// </summary>
    public string? FeatureUrl { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Menu Company
    /// </summary>
    public bool? MenuCompany { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModuleModule? Module { get; set; }

    public virtual IrUiView? PageView { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
