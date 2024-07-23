using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// View
/// </summary>
public partial class IrUiView
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// Inherited View
    /// </summary>
    public int? InheritId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// View Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Model
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Key
    /// </summary>
    public string? Key { get; set; }

    /// <summary>
    /// View Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Arch Filename
    /// </summary>
    public string? ArchFs { get; set; }

    /// <summary>
    /// Child Field
    /// </summary>
    public string? FieldParent { get; set; }

    /// <summary>
    /// View inheritance mode
    /// </summary>
    public string Mode { get; set; } = null!;

    /// <summary>
    /// Arch Blob
    /// </summary>
    public string? ArchDb { get; set; }

    /// <summary>
    /// Previous View Architecture
    /// </summary>
    public string? ArchPrev { get; set; }

    /// <summary>
    /// Modified Architecture
    /// </summary>
    public bool? ArchUpdated { get; set; }

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

    /// <summary>
    /// Show As Optional Inherit
    /// </summary>
    public bool? CustomizeShow { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Theme Template
    /// </summary>
    public int? ThemeTemplateId { get; set; }

    /// <summary>
    /// Website opengraph image
    /// </summary>
    public string? WebsiteMetaOgImg { get; set; }

    /// <summary>
    /// Visibility
    /// </summary>
    public string? Visibility { get; set; }

    /// <summary>
    /// Visibility Password
    /// </summary>
    public string? VisibilityPassword { get; set; }

    /// <summary>
    /// Website meta title
    /// </summary>
    public string? WebsiteMetaTitle { get; set; }

    /// <summary>
    /// Website meta description
    /// </summary>
    public string? WebsiteMetaDescription { get; set; }

    /// <summary>
    /// Website meta keywords
    /// </summary>
    public string? WebsiteMetaKeywords { get; set; }

    /// <summary>
    /// Seo name
    /// </summary>
    public string? SeoName { get; set; }

    /// <summary>
    /// Track
    /// </summary>
    public bool? Track { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? Inherit { get; set; }

    public virtual ICollection<IrUiView> InverseInherit { get; set; } = new List<IrUiView>();

    public virtual ICollection<IrActWindow> IrActWindowSearchViews { get; set; } = new List<IrActWindow>();

    public virtual ICollection<IrActWindow> IrActWindowViews { get; set; } = new List<IrActWindow>();

    public virtual ICollection<IrActWindowView> IrActWindowViewsNavigation { get; set; } = new List<IrActWindowView>();

    public virtual ICollection<IrUiViewCustom> IrUiViewCustoms { get; set; } = new List<IrUiViewCustom>();

    public virtual ICollection<PaymentProvider> PaymentProviderExpressCheckoutFormViews { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<PaymentProvider> PaymentProviderInlineFormViews { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<PaymentProvider> PaymentProviderRedirectFormViews { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<PaymentProvider> PaymentProviderTokenInlineFormViews { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<ReportLayout> ReportLayouts { get; set; } = new List<ReportLayout>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCountry> ResCountries { get; set; } = new List<ResCountry>();

    public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardCompareViews { get; set; } = new List<ResetViewArchWizard>();

    public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardViews { get; set; } = new List<ResetViewArchWizard>();

    public virtual ThemeIrUiView? ThemeTemplate { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatures { get; set; } = new List<WebsiteConfiguratorFeature>();

    public virtual ICollection<WebsiteEventMenu> WebsiteEventMenus { get; set; } = new List<WebsiteEventMenu>();

    public virtual ICollection<WebsitePage> WebsitePages { get; set; } = new List<WebsitePage>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResGroup> Groups { get; set; } = new List<ResGroup>();
}
