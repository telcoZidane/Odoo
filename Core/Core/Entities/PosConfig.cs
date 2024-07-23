using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Point of Sale Configuration
/// </summary>
public partial class PosConfig
{
    public int Id { get; set; }

    /// <summary>
    /// Operation Type
    /// </summary>
    public int PickingTypeId { get; set; }

    /// <summary>
    /// Point of Sale Journal
    /// </summary>
    public int? JournalId { get; set; }

    /// <summary>
    /// Invoice Journal
    /// </summary>
    public int? InvoiceJournalId { get; set; }

    /// <summary>
    /// Initial Category
    /// </summary>
    public int? IfaceStartCategId { get; set; }

    /// <summary>
    /// Order IDs Sequence
    /// </summary>
    public int? SequenceId { get; set; }

    /// <summary>
    /// Order Line IDs Sequence
    /// </summary>
    public int? SequenceLineId { get; set; }

    /// <summary>
    /// Default Pricelist
    /// </summary>
    public int PricelistId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Point of Sale Manager Group
    /// </summary>
    public int? GroupPosManagerId { get; set; }

    /// <summary>
    /// Point of Sale User Group
    /// </summary>
    public int? GroupPosUserId { get; set; }

    /// <summary>
    /// Tip Product
    /// </summary>
    public int? TipProductId { get; set; }

    /// <summary>
    /// Default Fiscal Position
    /// </summary>
    public int? DefaultFiscalPositionId { get; set; }

    /// <summary>
    /// Cash rounding
    /// </summary>
    public int? RoundingMethod { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Spefic route for products delivered later.
    /// </summary>
    public int? RouteId { get; set; }

    /// <summary>
    /// Limited Products Amount
    /// </summary>
    public int? LimitedProductsAmount { get; set; }

    /// <summary>
    /// Limited Partners Amount
    /// </summary>
    public int? LimitedPartnersAmount { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Point of Sale
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Tax Display
    /// </summary>
    public string IfaceTaxIncluded { get; set; } = null!;

    /// <summary>
    /// IP Address
    /// </summary>
    public string? ProxyIp { get; set; }

    /// <summary>
    /// Uuid
    /// </summary>
    public string? Uuid { get; set; }

    /// <summary>
    /// Shipping Policy
    /// </summary>
    public string PickingPolicy { get; set; } = null!;

    /// <summary>
    /// Receipt Header
    /// </summary>
    public string? ReceiptHeader { get; set; }

    /// <summary>
    /// Receipt Footer
    /// </summary>
    public string? ReceiptFooter { get; set; }

    /// <summary>
    /// Cashdrawer
    /// </summary>
    public bool? IfaceCashdrawer { get; set; }

    /// <summary>
    /// Electronic Scale
    /// </summary>
    public bool? IfaceElectronicScale { get; set; }

    /// <summary>
    /// Customer Facing Display
    /// </summary>
    public bool? IfaceCustomerFacingDisplayViaProxy { get; set; }

    /// <summary>
    /// Local Customer Facing Display
    /// </summary>
    public bool? IfaceCustomerFacingDisplayLocal { get; set; }

    /// <summary>
    /// Print via Proxy
    /// </summary>
    public bool? IfacePrintViaProxy { get; set; }

    /// <summary>
    /// Scan via Proxy
    /// </summary>
    public bool? IfaceScanViaProxy { get; set; }

    /// <summary>
    /// Large Scrollbars
    /// </summary>
    public bool? IfaceBigScrollbars { get; set; }

    /// <summary>
    /// Automatic Receipt Printing
    /// </summary>
    public bool? IfacePrintAuto { get; set; }

    /// <summary>
    /// Skip Preview Screen
    /// </summary>
    public bool? IfacePrintSkipScreen { get; set; }

    /// <summary>
    /// Restrict Price Modifications to Managers
    /// </summary>
    public bool? RestrictPriceControl { get; set; }

    /// <summary>
    /// Margins &amp; Costs
    /// </summary>
    public bool? IsMarginsCostsAccessibleToEveryUser { get; set; }

    /// <summary>
    /// Set Maximum Difference
    /// </summary>
    public bool? SetMaximumDifference { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Product tips
    /// </summary>
    public bool? IfaceTipproduct { get; set; }

    /// <summary>
    /// Use a pricelist.
    /// </summary>
    public bool? UsePricelist { get; set; }

    /// <summary>
    /// Tax Regime Selection value
    /// </summary>
    public bool? TaxRegimeSelection { get; set; }

    /// <summary>
    /// Start Category
    /// </summary>
    public bool? StartCategory { get; set; }

    /// <summary>
    /// Restrict Categories
    /// </summary>
    public bool? LimitCategories { get; set; }

    /// <summary>
    /// Is a Bar/Restaurant
    /// </summary>
    public bool? ModulePosRestaurant { get; set; }

    /// <summary>
    /// Global Discounts
    /// </summary>
    public bool? ModulePosDiscount { get; set; }

    /// <summary>
    /// Integrated Card Payments
    /// </summary>
    public bool? ModulePosMercury { get; set; }

    /// <summary>
    /// PosBox
    /// </summary>
    public bool? IsPosbox { get; set; }

    /// <summary>
    /// Custom Header &amp; Footer
    /// </summary>
    public bool? IsHeaderOrFooter { get; set; }

    /// <summary>
    /// Module Pos Hr
    /// </summary>
    public bool? ModulePosHr { get; set; }

    /// <summary>
    /// Other Devices
    /// </summary>
    public bool? OtherDevices { get; set; }

    /// <summary>
    /// Cash Rounding
    /// </summary>
    public bool? CashRounding { get; set; }

    /// <summary>
    /// Only apply rounding on cash
    /// </summary>
    public bool? OnlyRoundCashMethod { get; set; }

    /// <summary>
    /// Line Discounts
    /// </summary>
    public bool? ManualDiscount { get; set; }

    /// <summary>
    /// Ship Later
    /// </summary>
    public bool? ShipLater { get; set; }

    /// <summary>
    /// Limited Product Loading
    /// </summary>
    public bool? LimitedProductsLoading { get; set; }

    /// <summary>
    /// Product Load Background
    /// </summary>
    public bool? ProductLoadBackground { get; set; }

    /// <summary>
    /// Limited Partners Loading
    /// </summary>
    public bool? LimitedPartnersLoading { get; set; }

    /// <summary>
    /// Partner Load Background
    /// </summary>
    public bool? PartnerLoadBackground { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Amount Authorized Difference
    /// </summary>
    public double? AmountAuthorizedDiff { get; set; }

    /// <summary>
    /// Epson Printer IP
    /// </summary>
    public string? EpsonPrinterIp { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? CrmTeamId { get; set; }

    /// <summary>
    /// Down Payment Product
    /// </summary>
    public int? DownPaymentProductId { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? CrmTeam { get; set; }

    public virtual AccountFiscalPosition? DefaultFiscalPosition { get; set; }

    public virtual ProductProduct? DownPaymentProduct { get; set; }

    public virtual ResGroup? GroupPosManager { get; set; }

    public virtual ResGroup? GroupPosUser { get; set; }

    public virtual PosCategory? IfaceStartCateg { get; set; }

    public virtual AccountJournal? InvoiceJournal { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual StockPickingType PickingType { get; set; } = null!;

    public virtual ICollection<PosMakePayment> PosMakePayments { get; set; } = new List<PosMakePayment>();

    public virtual ICollection<PosSession> PosSessions { get; set; } = new List<PosSession>();

    public virtual ProductPricelist Pricelist { get; set; } = null!;

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();

    public virtual AccountCashRounding? RoundingMethodNavigation { get; set; }

    public virtual StockRoute? Route { get; set; }

    public virtual IrSequence? Sequence { get; set; }

    public virtual IrSequence? SequenceLine { get; set; }

    public virtual ProductProduct? TipProduct { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; set; } = new List<AccountFiscalPosition>();

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<PosBill> PosBills { get; set; } = new List<PosBill>();

    public virtual ICollection<PosCategory> PosCategories { get; set; } = new List<PosCategory>();

    public virtual ICollection<PosDetailsWizard> PosDetailsWizards { get; set; } = new List<PosDetailsWizard>();

    public virtual ICollection<PosPaymentMethod> PosPaymentMethods { get; set; } = new List<PosPaymentMethod>();

    public virtual ICollection<ProductPricelist> ProductPricelists { get; set; } = new List<ProductPricelist>();
}
