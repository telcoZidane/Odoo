using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product
/// </summary>
public partial class ProductTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int CategId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int UomId { get; set; }

    /// <summary>
    /// Purchase UoM
    /// </summary>
    public int UomPoId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Color Index
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
    /// Product Type
    /// </summary>
    public string DetailedType { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Internal Reference
    /// </summary>
    public string? DefaultCode { get; set; }

    /// <summary>
    /// Favorite
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Purchase Description
    /// </summary>
    public string? DescriptionPurchase { get; set; }

    /// <summary>
    /// Sales Description
    /// </summary>
    public string? DescriptionSale { get; set; }

    /// <summary>
    /// Sales Price
    /// </summary>
    public decimal? ListPrice { get; set; }

    /// <summary>
    /// Volume
    /// </summary>
    public decimal? Volume { get; set; }

    /// <summary>
    /// Weight
    /// </summary>
    public decimal? Weight { get; set; }

    /// <summary>
    /// Can be Sold
    /// </summary>
    public bool? SaleOk { get; set; }

    /// <summary>
    /// Can be Purchased
    /// </summary>
    public bool? PurchaseOk { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Can Image 1024 be zoomed
    /// </summary>
    public bool? CanImage1024BeZoomed { get; set; }

    /// <summary>
    /// Is a configurable product
    /// </summary>
    public bool? HasConfigurableAttributes { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Track Service
    /// </summary>
    public string? ServiceType { get; set; }

    /// <summary>
    /// Sales Order Line
    /// </summary>
    public string SaleLineWarn { get; set; } = null!;

    /// <summary>
    /// Re-Invoice Expenses
    /// </summary>
    public string? ExpensePolicy { get; set; }

    /// <summary>
    /// Invoicing Policy
    /// </summary>
    public string? InvoicePolicy { get; set; }

    /// <summary>
    /// Message for Sales Order Line
    /// </summary>
    public string? SaleLineWarnMsg { get; set; }

    /// <summary>
    /// Create on Order
    /// </summary>
    public string? ServiceTracking { get; set; }

    /// <summary>
    /// Tracking
    /// </summary>
    public string Tracking { get; set; } = null!;

    /// <summary>
    /// Description on Picking
    /// </summary>
    public string? DescriptionPicking { get; set; }

    /// <summary>
    /// Description on Delivery Orders
    /// </summary>
    public string? DescriptionPickingout { get; set; }

    /// <summary>
    /// Description on Receptions
    /// </summary>
    public string? DescriptionPickingin { get; set; }

    /// <summary>
    /// Customer Lead Time
    /// </summary>
    public double? SaleDelay { get; set; }

    /// <summary>
    /// Control Policy
    /// </summary>
    public string? PurchaseMethod { get; set; }

    /// <summary>
    /// Purchase Order Line Warning
    /// </summary>
    public string PurchaseLineWarn { get; set; } = null!;

    /// <summary>
    /// Message for Purchase Order Line
    /// </summary>
    public string? PurchaseLineWarnMsg { get; set; }

    /// <summary>
    /// Point of Sale Category
    /// </summary>
    public int? PosCategId { get; set; }

    /// <summary>
    /// Available in POS
    /// </summary>
    public bool? AvailableInPos { get; set; }

    /// <summary>
    /// To Weigh With Scale
    /// </summary>
    public bool? ToWeight { get; set; }

    /// <summary>
    /// Manufacturing Lead Time
    /// </summary>
    public double? ProduceDelay { get; set; }

    /// <summary>
    /// Days to prepare Manufacturing Order
    /// </summary>
    public double? DaysToPrepareMo { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Size X
    /// </summary>
    public int? WebsiteSizeX { get; set; }

    /// <summary>
    /// Size Y
    /// </summary>
    public int? WebsiteSizeY { get; set; }

    /// <summary>
    /// Ribbon
    /// </summary>
    public int? WebsiteRibbonId { get; set; }

    /// <summary>
    /// Website Sequence
    /// </summary>
    public int? WebsiteSequence { get; set; }

    /// <summary>
    /// Custom Unit of Measure
    /// </summary>
    public int? BaseUnitId { get; set; }

    /// <summary>
    /// Website opengraph image
    /// </summary>
    public string? WebsiteMetaOgImg { get; set; }

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
    /// Description for the website
    /// </summary>
    public string? WebsiteDescription { get; set; }

    /// <summary>
    /// Compare to Price
    /// </summary>
    public decimal? CompareListPrice { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Rating Last Value
    /// </summary>
    public double? RatingLastValue { get; set; }

    /// <summary>
    /// Base Unit Count
    /// </summary>
    public double BaseUnitCount { get; set; }

    /// <summary>
    /// Out-of-Stock Message
    /// </summary>
    public string? OutOfStockMessage { get; set; }

    /// <summary>
    /// Continue selling when out-of-stock
    /// </summary>
    public bool? AllowOutOfStockOrder { get; set; }

    /// <summary>
    /// Show availability Qty
    /// </summary>
    public bool? ShowAvailability { get; set; }

    /// <summary>
    /// Show Threshold
    /// </summary>
    public double? AvailableThreshold { get; set; }

    public bool? CanBeExpensed { get; set; }

    public virtual WebsiteBaseUnit? BaseUnit { get; set; }

    public virtual ProductCategory Categ { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<MrpBomLine> MrpBomLines { get; set; } = new List<MrpBomLine>();

    public virtual ICollection<MrpBom> MrpBoms { get; set; } = new List<MrpBom>();

    public virtual PosCategory? PosCateg { get; set; }

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductProduct> ProductProducts { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductReplenish> ProductReplenishes { get; set; } = new List<ProductReplenish>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusions { get; set; } = new List<ProductTemplateAttributeExclusion>();

    public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLines { get; set; } = new List<ProductTemplateAttributeLine>();

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; set; } = new List<ProductTemplateAttributeValue>();

    public virtual ICollection<StockChangeProductQty> StockChangeProductQties { get; set; } = new List<StockChangeProductQty>();

    public virtual ICollection<StockRulesReport> StockRulesReports { get; set; } = new List<StockRulesReport>();

    public virtual UomUom Uom { get; set; } = null!;

    public virtual UomUom UomPo { get; set; } = null!;

    public virtual Website? Website { get; set; }

    public virtual ProductRibbon? WebsiteRibbon { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccountTag> AccountAccountTags { get; set; } = new List<AccountAccountTag>();

    public virtual ICollection<ProductProduct> Dests { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductTemplate> Dests1 { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> DestsNavigation { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductAttribute> ProductAttributes { get; set; } = new List<ProductAttribute>();

    public virtual ICollection<ProductLabelLayout> ProductLabelLayouts { get; set; } = new List<ProductLabelLayout>();

    public virtual ICollection<ProductPublicCategory> ProductPublicCategories { get; set; } = new List<ProductPublicCategory>();

    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();

    public virtual ICollection<StockRoute> Routes { get; set; } = new List<StockRoute>();

    public virtual ICollection<ProductTemplate> Srcs { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> SrcsNavigation { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<AccountTax> Taxes { get; set; } = new List<AccountTax>();

    public virtual ICollection<AccountTax> TaxesNavigation { get; set; } = new List<AccountTax>();
}
