using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Variant
/// </summary>
public partial class ProductProduct
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int ProductTmplId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Internal Reference
    /// </summary>
    public string? DefaultCode { get; set; }

    /// <summary>
    /// Barcode
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// Combination Indices
    /// </summary>
    public string? CombinationIndices { get; set; }

    /// <summary>
    /// Volume
    /// </summary>
    public decimal? Volume { get; set; }

    /// <summary>
    /// Weight
    /// </summary>
    public decimal? Weight { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Can Variant Image 1024 be zoomed
    /// </summary>
    public bool? CanImageVariant1024BeZoomed { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Custom Unit of Measure
    /// </summary>
    public int? BaseUnitId { get; set; }

    /// <summary>
    /// Base Unit Count
    /// </summary>
    public double BaseUnitCount { get; set; }

    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; set; } = new List<AccountAnalyticDistributionModel>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual WebsiteBaseUnit? BaseUnit { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<EventEventConfigurator> EventEventConfigurators { get; set; } = new List<EventEventConfigurator>();

    public virtual ICollection<EventEventTicket> EventEventTickets { get; set; } = new List<EventEventTicket>();

    public virtual ICollection<EventTypeTicket> EventTypeTickets { get; set; } = new List<EventTypeTicket>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; set; } = new List<HrExpenseSplit>();

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; set; } = new List<MrpBomByproduct>();

    public virtual ICollection<MrpBomLine> MrpBomLines { get; set; } = new List<MrpBomLine>();

    public virtual ICollection<MrpBom> MrpBoms { get; set; } = new List<MrpBom>();

    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLines { get; set; } = new List<MrpConsumptionWarningLine>();

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; set; } = new List<MrpUnbuild>();

    public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacities { get; set; } = new List<MrpWorkcenterCapacity>();

    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; set; } = new List<MrpWorkorder>();

    public virtual ICollection<PosConfig> PosConfigDownPaymentProducts { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosConfig> PosConfigTipProducts { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosOrderLine> PosOrderLines { get; set; } = new List<PosOrderLine>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductPackaging> ProductPackagings { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductReplenish> ProductReplenishes { get; set; } = new List<ProductReplenish>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; set; } = new List<ProductSupplierinfo>();

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<RepairFee> RepairFees { get; set; } = new List<RepairFee>();

    public virtual ICollection<RepairLine> RepairLines { get; set; } = new List<RepairLine>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingDepositDefaultProducts { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingPosTipProducts { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; set; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; set; } = new List<SaleOrderOption>();

    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; set; } = new List<SaleOrderTemplateLine>();

    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; set; } = new List<SaleOrderTemplateOption>();

    public virtual ICollection<StockChangeProductQty> StockChangeProductQties { get; set; } = new List<StockChangeProductQty>();

    public virtual ICollection<StockLot> StockLots { get; set; } = new List<StockLot>();

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPutawayRule> StockPutawayRules { get; set; } = new List<StockPutawayRule>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; set; } = new List<StockReplenishmentOption>();

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; set; } = new List<StockReturnPickingLine>();

    public virtual ICollection<StockRulesReport> StockRulesReports { get; set; } = new List<StockRulesReport>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacities { get; set; } = new List<StockStorageCategoryCapacity>();

    public virtual ICollection<StockTrackLine> StockTrackLines { get; set; } = new List<StockTrackLine>();

    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; set; } = new List<StockValuationLayerRevaluation>();

    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; set; } = new List<StockValuationLayer>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairs { get; set; } = new List<StockWarnInsufficientQtyRepair>();

    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScraps { get; set; } = new List<StockWarnInsufficientQtyScrap>();

    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuilds { get; set; } = new List<StockWarnInsufficientQtyUnbuild>();

    public virtual ICollection<WebsiteTrack> WebsiteTracks { get; set; } = new List<WebsiteTrack>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductLabelLayout> ProductLabelLayouts { get; set; } = new List<ProductLabelLayout>();

    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; set; } = new List<ProductTemplateAttributeValue>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<ProductTemplate> Srcs { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<StockTrackConfirmation> StockTrackConfirmations { get; set; } = new List<StockTrackConfirmation>();
}
