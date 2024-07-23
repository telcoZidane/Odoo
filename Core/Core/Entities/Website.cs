using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website
/// </summary>
public partial class Website
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Default Language
    /// </summary>
    public int DefaultLangId { get; set; }

    /// <summary>
    /// Public User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Theme
    /// </summary>
    public int? ThemeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Website Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Website Domain
    /// </summary>
    public string? Domain { get; set; }

    /// <summary>
    /// Twitter Account
    /// </summary>
    public string? SocialTwitter { get; set; }

    /// <summary>
    /// Facebook Account
    /// </summary>
    public string? SocialFacebook { get; set; }

    /// <summary>
    /// GitHub Account
    /// </summary>
    public string? SocialGithub { get; set; }

    /// <summary>
    /// LinkedIn Account
    /// </summary>
    public string? SocialLinkedin { get; set; }

    /// <summary>
    /// Youtube Account
    /// </summary>
    public string? SocialYoutube { get; set; }

    /// <summary>
    /// Instagram Account
    /// </summary>
    public string? SocialInstagram { get; set; }

    /// <summary>
    /// Google Analytics Key
    /// </summary>
    public string? GoogleAnalyticsKey { get; set; }

    /// <summary>
    /// Google Search Console
    /// </summary>
    public string? GoogleSearchConsole { get; set; }

    /// <summary>
    /// Google Maps API Key
    /// </summary>
    public string? GoogleMapsApiKey { get; set; }

    /// <summary>
    /// Plausible Shared Key
    /// </summary>
    public string? PlausibleSharedKey { get; set; }

    /// <summary>
    /// Plausible Site
    /// </summary>
    public string? PlausibleSite { get; set; }

    /// <summary>
    /// CDN Base URL
    /// </summary>
    public string? CdnUrl { get; set; }

    /// <summary>
    /// Homepage Url
    /// </summary>
    public string? HomepageUrl { get; set; }

    /// <summary>
    /// Customer Account
    /// </summary>
    public string? AuthSignupUninvited { get; set; }

    /// <summary>
    /// CDN Filters
    /// </summary>
    public string? CdnFilters { get; set; }

    /// <summary>
    /// Custom &lt;head&gt; code
    /// </summary>
    public string? CustomCodeHead { get; set; }

    /// <summary>
    /// Custom end of &lt;body&gt; code
    /// </summary>
    public string? CustomCodeFooter { get; set; }

    /// <summary>
    /// Robots.txt
    /// </summary>
    public string? RobotsTxt { get; set; }

    /// <summary>
    /// Autoredirect Language
    /// </summary>
    public bool? AutoRedirectLang { get; set; }

    /// <summary>
    /// Cookies Bar
    /// </summary>
    public bool? CookiesBar { get; set; }

    /// <summary>
    /// Configurator Done
    /// </summary>
    public bool? ConfiguratorDone { get; set; }

    /// <summary>
    /// Has Social Default Image
    /// </summary>
    public bool? HasSocialDefaultImage { get; set; }

    /// <summary>
    /// Content Delivery Network (CDN)
    /// </summary>
    public bool? CdnActivated { get; set; }

    /// <summary>
    /// Specific User Account
    /// </summary>
    public bool? SpecificUserAccount { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Default Sales Teams
    /// </summary>
    public int? CrmDefaultTeamId { get; set; }

    /// <summary>
    /// Default Salesperson
    /// </summary>
    public int? CrmDefaultUserId { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? SalespersonId { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? SalesteamId { get; set; }

    /// <summary>
    /// Cart Recovery Email
    /// </summary>
    public int? CartRecoveryMailTemplateId { get; set; }

    /// <summary>
    /// Number of products in the grid on the shop
    /// </summary>
    public int? ShopPpg { get; set; }

    /// <summary>
    /// Number of grid columns on the shop
    /// </summary>
    public int? ShopPpr { get; set; }

    /// <summary>
    /// Product Page Grid Columns
    /// </summary>
    public int? ProductPageGridColumns { get; set; }

    /// <summary>
    /// Shop Default Sort
    /// </summary>
    public string ShopDefaultSort { get; set; } = null!;

    /// <summary>
    /// Add To Cart Action
    /// </summary>
    public string? AddToCartAction { get; set; }

    /// <summary>
    /// Customer Accounts
    /// </summary>
    public string? AccountOnCheckout { get; set; }

    /// <summary>
    /// Product Page Image Layout
    /// </summary>
    public string ProductPageImageLayout { get; set; } = null!;

    /// <summary>
    /// Product Page Image Width
    /// </summary>
    public string ProductPageImageWidth { get; set; } = null!;

    /// <summary>
    /// Product Page Image Spacing
    /// </summary>
    public string ProductPageImageSpacing { get; set; } = null!;

    /// <summary>
    /// Text to show instead of price
    /// </summary>
    public string? PreventZeroPriceSaleText { get; set; }

    /// <summary>
    /// Contact Us Button URL
    /// </summary>
    public string? ContactUsButtonUrl { get; set; }

    /// <summary>
    /// Send email to customers who abandoned their cart.
    /// </summary>
    public bool? SendAbandonedCartEmail { get; set; }

    /// <summary>
    /// Hide &apos;Add To Cart&apos; when price = 0
    /// </summary>
    public bool? PreventZeroPriceSale { get; set; }

    /// <summary>
    /// Re-order From Portal
    /// </summary>
    public bool? EnabledPortalReorderButton { get; set; }

    /// <summary>
    /// Abandoned Delay
    /// </summary>
    public double? CartAbandonedDelay { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Minimal karma to see other user&apos;s profile
    /// </summary>
    public int? KarmaProfileMin { get; set; }

    /// <summary>
    /// Google Doc Key
    /// </summary>
    public string? WebsiteSlideGoogleAppKey { get; set; }

    /// <summary>
    /// Website Live Chat Channel
    /// </summary>
    public int? ChannelId { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual MailTemplate? CartRecoveryMailTemplate { get; set; }

    public virtual ImLivechatChannel? Channel { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? CrmDefaultTeam { get; set; }

    public virtual ResUser? CrmDefaultUser { get; set; }

    public virtual ResLang DefaultLang { get; set; } = null!;

    public virtual ICollection<EventEvent> EventEvents { get; set; } = new List<EventEvent>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();

    public virtual ICollection<IrAsset> IrAssets { get; set; } = new List<IrAsset>();

    public virtual ICollection<IrAttachment> IrAttachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<IrUiView> IrUiViews { get; set; } = new List<IrUiView>();

    public virtual ICollection<PaymentProvider> PaymentProviders { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<ProductPricelist> ProductPricelists { get; set; } = new List<ProductPricelist>();

    public virtual ICollection<ProductPublicCategory> ProductPublicCategories { get; set; } = new List<ProductPublicCategory>();

    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ResUser? Salesperson { get; set; }

    public virtual CrmTeam? Salesteam { get; set; }

    public virtual ICollection<SlideChannel> SlideChannels { get; set; } = new List<SlideChannel>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual IrModuleModule? Theme { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ICollection<WebsiteMenu> WebsiteMenus { get; set; } = new List<WebsiteMenu>();

    public virtual ICollection<WebsitePage> WebsitePages { get; set; } = new List<WebsitePage>();

    public virtual ICollection<WebsiteRewrite> WebsiteRewrites { get; set; } = new List<WebsiteRewrite>();

    public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFields { get; set; } = new List<WebsiteSaleExtraField>();

    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilters { get; set; } = new List<WebsiteSnippetFilter>();

    public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; set; } = new List<WebsiteVisitor>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<BaseLanguageInstall> BaseLanguageInstalls { get; set; } = new List<BaseLanguageInstall>();

    public virtual ICollection<ResLang> Langs { get; set; } = new List<ResLang>();
}
