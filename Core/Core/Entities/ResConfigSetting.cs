using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Config Settings
/// </summary>
public partial class ResConfigSetting
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Default Access Rights
    /// </summary>
    public bool? UserDefaultRights { get; set; }

    /// <summary>
    /// Custom Email Servers
    /// </summary>
    public bool? ExternalEmailServerDefault { get; set; }

    /// <summary>
    /// Allow users to import data from CSV/XLS/XLSX/ODS files
    /// </summary>
    public bool? ModuleBaseImport { get; set; }

    /// <summary>
    /// Allow the users to synchronize their calendar  with Google Calendar
    /// </summary>
    public bool? ModuleGoogleCalendar { get; set; }

    /// <summary>
    /// Allow the users to synchronize their calendar with Outlook Calendar
    /// </summary>
    public bool? ModuleMicrosoftCalendar { get; set; }

    /// <summary>
    /// Allow integration with the mail plugins
    /// </summary>
    public bool? ModuleMailPlugin { get; set; }

    /// <summary>
    /// Use external authentication providers (OAuth)
    /// </summary>
    public bool? ModuleAuthOauth { get; set; }

    /// <summary>
    /// LDAP Authentication
    /// </summary>
    public bool? ModuleAuthLdap { get; set; }

    /// <summary>
    /// Translate Your Website with Gengo
    /// </summary>
    public bool? ModuleBaseGengo { get; set; }

    /// <summary>
    /// Manage Inter Company
    /// </summary>
    public bool? ModuleAccountInterCompanyRules { get; set; }

    /// <summary>
    /// Asterisk (VoIP)
    /// </summary>
    public bool? ModuleVoip { get; set; }

    /// <summary>
    /// Unsplash Image Library
    /// </summary>
    public bool? ModuleWebUnsplash { get; set; }

    /// <summary>
    /// Partner Autocomplete
    /// </summary>
    public bool? ModulePartnerAutocomplete { get; set; }

    /// <summary>
    /// GeoLocalize
    /// </summary>
    public bool? ModuleBaseGeolocalize { get; set; }

    /// <summary>
    /// reCAPTCHA
    /// </summary>
    public bool? ModuleGoogleRecaptcha { get; set; }

    /// <summary>
    /// Multi-Currencies
    /// </summary>
    public bool? GroupMultiCurrency { get; set; }

    /// <summary>
    /// Show Effect
    /// </summary>
    public bool? ShowEffect { get; set; }

    /// <summary>
    /// Get product pictures using barcode
    /// </summary>
    public bool? ModuleProductImages { get; set; }

    /// <summary>
    /// Profiling enabled until
    /// </summary>
    public DateTime? ProfilingEnabledUntil { get; set; }

    /// <summary>
    /// Alias Domain
    /// </summary>
    public string? AliasDomain { get; set; }

    /// <summary>
    /// Twilio Account SID
    /// </summary>
    public string? TwilioAccountSid { get; set; }

    /// <summary>
    /// Twilio Account Auth Token
    /// </summary>
    public string? TwilioAccountToken { get; set; }

    /// <summary>
    /// Support Gmail Authentication
    /// </summary>
    public bool? ModuleGoogleGmail { get; set; }

    /// <summary>
    /// Support Outlook Authentication
    /// </summary>
    public bool? ModuleMicrosoftOutlook { get; set; }

    /// <summary>
    /// Restrict Template Rendering
    /// </summary>
    public bool? RestrictTemplateRendering { get; set; }

    /// <summary>
    /// Use Twilio ICE servers
    /// </summary>
    public bool? UseTwilioRtcServers { get; set; }

    /// <summary>
    /// Analytic Accounting
    /// </summary>
    public bool? GroupAnalyticAccounting { get; set; }

    /// <summary>
    /// Template user for new users created through signup
    /// </summary>
    public int? AuthSignupTemplateUserId { get; set; }

    /// <summary>
    /// Customer Account
    /// </summary>
    public string? AuthSignupUninvited { get; set; }

    /// <summary>
    /// Enable password reset from Login page
    /// </summary>
    public bool? AuthSignupResetPassword { get; set; }

    /// <summary>
    /// Gmail Client Id
    /// </summary>
    public string? GoogleGmailClientIdentifier { get; set; }

    /// <summary>
    /// Gmail Client Secret
    /// </summary>
    public string? GoogleGmailClientSecret { get; set; }

    /// <summary>
    /// Pricelists Method
    /// </summary>
    public string? ProductPricelistSetting { get; set; }

    /// <summary>
    /// Weight unit of measure
    /// </summary>
    public string? ProductWeightInLbs { get; set; }

    /// <summary>
    /// Volume unit of measure
    /// </summary>
    public string? ProductVolumeVolumeInCubicFeet { get; set; }

    /// <summary>
    /// Discounts
    /// </summary>
    public bool? GroupDiscountPerSoLine { get; set; }

    /// <summary>
    /// Units of Measure
    /// </summary>
    public bool? GroupUom { get; set; }

    /// <summary>
    /// Variants
    /// </summary>
    public bool? GroupProductVariant { get; set; }

    /// <summary>
    /// Sales Grid Entry
    /// </summary>
    public bool? ModuleSaleProductMatrix { get; set; }

    /// <summary>
    /// Promotions, Coupons, Gift Card &amp; Loyalty Program
    /// </summary>
    public bool? ModuleLoyalty { get; set; }

    /// <summary>
    /// Product Packagings
    /// </summary>
    public bool? GroupStockPackaging { get; set; }

    /// <summary>
    /// Pricelists
    /// </summary>
    public bool? GroupProductPricelist { get; set; }

    /// <summary>
    /// Advanced Pricelists
    /// </summary>
    public bool? GroupSalePricelist { get; set; }

    /// <summary>
    /// Access Key
    /// </summary>
    public string? UnsplashAccessKey { get; set; }

    /// <summary>
    /// Application ID
    /// </summary>
    public string? UnsplashAppId { get; set; }

    /// <summary>
    /// Digest Email
    /// </summary>
    public int? DigestId { get; set; }

    /// <summary>
    /// Digest Emails
    /// </summary>
    public bool? DigestEmails { get; set; }

    /// <summary>
    /// Template
    /// </summary>
    public int? ChartTemplateId { get; set; }

    /// <summary>
    /// Line Subtotals Tax Display
    /// </summary>
    public string ShowLineSubtotalsTaxSelection { get; set; } = null!;

    /// <summary>
    /// Accounting
    /// </summary>
    public bool? ModuleAccountAccountant { get; set; }

    /// <summary>
    /// Warnings in Invoices
    /// </summary>
    public bool? GroupWarningAccount { get; set; }

    /// <summary>
    /// Cash Rounding
    /// </summary>
    public bool? GroupCashRounding { get; set; }

    /// <summary>
    /// Show line subtotals without taxes (B2B)
    /// </summary>
    public bool? GroupShowLineSubtotalsTaxExcluded { get; set; }

    /// <summary>
    /// Show line subtotals with taxes (B2C)
    /// </summary>
    public bool? GroupShowLineSubtotalsTaxIncluded { get; set; }

    /// <summary>
    /// Sale Receipt
    /// </summary>
    public bool? GroupShowSaleReceipts { get; set; }

    /// <summary>
    /// Purchase Receipt
    /// </summary>
    public bool? GroupShowPurchaseReceipts { get; set; }

    /// <summary>
    /// Budget Management
    /// </summary>
    public bool? ModuleAccountBudget { get; set; }

    /// <summary>
    /// Invoice Online Payment
    /// </summary>
    public bool? ModuleAccountPayment { get; set; }

    /// <summary>
    /// Dynamic Reports
    /// </summary>
    public bool? ModuleAccountReports { get; set; }

    /// <summary>
    /// Allow check printing and deposits
    /// </summary>
    public bool? ModuleAccountCheckPrinting { get; set; }

    /// <summary>
    /// Use batch payments
    /// </summary>
    public bool? ModuleAccountBatchPayment { get; set; }

    /// <summary>
    /// SEPA Credit Transfer (SCT)
    /// </summary>
    public bool? ModuleAccountSepa { get; set; }

    /// <summary>
    /// Use SEPA Direct Debit
    /// </summary>
    public bool? ModuleAccountSepaDirectDebit { get; set; }

    /// <summary>
    /// Import .qif files
    /// </summary>
    public bool? ModuleAccountBankStatementImportQif { get; set; }

    /// <summary>
    /// Import in .ofx format
    /// </summary>
    public bool? ModuleAccountBankStatementImportOfx { get; set; }

    /// <summary>
    /// Import in .csv format
    /// </summary>
    public bool? ModuleAccountBankStatementImportCsv { get; set; }

    /// <summary>
    /// Import in CAMT.053 format
    /// </summary>
    public bool? ModuleAccountBankStatementImportCamt { get; set; }

    /// <summary>
    /// Automatic Currency Rates
    /// </summary>
    public bool? ModuleCurrencyRateLive { get; set; }

    /// <summary>
    /// Intrastat
    /// </summary>
    public bool? ModuleAccountIntrastat { get; set; }

    /// <summary>
    /// Allow Product Margin
    /// </summary>
    public bool? ModuleProductMargin { get; set; }

    /// <summary>
    /// EU Intra-community Distance Selling
    /// </summary>
    public bool? ModuleL10nEuOss { get; set; }

    /// <summary>
    /// Account TaxCloud
    /// </summary>
    public bool? ModuleAccountTaxcloud { get; set; }

    /// <summary>
    /// Document Digitization
    /// </summary>
    public bool? ModuleAccountInvoiceExtract { get; set; }

    /// <summary>
    /// Snailmail
    /// </summary>
    public bool? ModuleSnailmailAccount { get; set; }

    /// <summary>
    /// Default Terms &amp; Conditions
    /// </summary>
    public bool? UseInvoiceTerms { get; set; }

    /// <summary>
    /// Customer Addresses
    /// </summary>
    public bool? GroupSaleDeliveryAddress { get; set; }

    /// <summary>
    /// Pay Invoices Online
    /// </summary>
    public bool? PayInvoicesOnline { get; set; }

    /// <summary>
    /// Deposit Product
    /// </summary>
    public int? DepositDefaultProductId { get; set; }

    /// <summary>
    /// Invoice Email Template
    /// </summary>
    public int? InvoiceMailTemplateId { get; set; }

    /// <summary>
    /// Invoicing Policy
    /// </summary>
    public string? DefaultInvoicePolicy { get; set; }

    /// <summary>
    /// Lock Confirmed Sales
    /// </summary>
    public bool? GroupAutoDoneSetting { get; set; }

    /// <summary>
    /// Pro-Forma Invoice
    /// </summary>
    public bool? GroupProformaSales { get; set; }

    /// <summary>
    /// Sale Order Warnings
    /// </summary>
    public bool? GroupWarningSale { get; set; }

    /// <summary>
    /// Automatic Invoice
    /// </summary>
    public bool? AutomaticInvoice { get; set; }

    /// <summary>
    /// Default Quotation Validity
    /// </summary>
    public bool? UseQuotationValidityDays { get; set; }

    /// <summary>
    /// Delivery Methods
    /// </summary>
    public bool? ModuleDelivery { get; set; }

    /// <summary>
    /// bpost Connector
    /// </summary>
    public bool? ModuleDeliveryBpost { get; set; }

    /// <summary>
    /// DHL Express Connector
    /// </summary>
    public bool? ModuleDeliveryDhl { get; set; }

    /// <summary>
    /// Easypost Connector
    /// </summary>
    public bool? ModuleDeliveryEasypost { get; set; }

    /// <summary>
    /// Sendcloud Connector
    /// </summary>
    public bool? ModuleDeliverySendcloud { get; set; }

    /// <summary>
    /// FedEx Connector
    /// </summary>
    public bool? ModuleDeliveryFedex { get; set; }

    /// <summary>
    /// UPS Connector
    /// </summary>
    public bool? ModuleDeliveryUps { get; set; }

    /// <summary>
    /// USPS Connector
    /// </summary>
    public bool? ModuleDeliveryUsps { get; set; }

    /// <summary>
    /// Specific Email
    /// </summary>
    public bool? ModuleProductEmailTemplate { get; set; }

    /// <summary>
    /// Amazon Sync
    /// </summary>
    public bool? ModuleSaleAmazon { get; set; }

    /// <summary>
    /// Coupons &amp; Loyalty
    /// </summary>
    public bool? ModuleSaleLoyalty { get; set; }

    /// <summary>
    /// Margins
    /// </summary>
    public bool? ModuleSaleMargin { get; set; }

    /// <summary>
    /// Quotation Templates
    /// </summary>
    public bool? GroupSaleOrderTemplate { get; set; }

    /// <summary>
    /// Quotation Builder
    /// </summary>
    public bool? ModuleSaleQuotationBuilder { get; set; }

    /// <summary>
    /// Advanced Presence Control
    /// </summary>
    public bool? ModuleHrPresence { get; set; }

    /// <summary>
    /// Skills Management
    /// </summary>
    public bool? ModuleHrSkills { get; set; }

    /// <summary>
    /// Homeworking
    /// </summary>
    public bool? ModuleHrHomeworking { get; set; }

    /// <summary>
    /// Based on user status in system
    /// </summary>
    public bool? HrPresenceControlLogin { get; set; }

    /// <summary>
    /// Based on number of emails sent
    /// </summary>
    public bool? HrPresenceControlEmail { get; set; }

    /// <summary>
    /// Based on IP Address
    /// </summary>
    public bool? HrPresenceControlIp { get; set; }

    /// <summary>
    /// Based on attendances
    /// </summary>
    public bool? ModuleHrAttendance { get; set; }

    /// <summary>
    /// Employee Editing
    /// </summary>
    public bool? HrEmployeeSelfEdit { get; set; }

    /// <summary>
    /// Mail Server
    /// </summary>
    public int? MassMailingMailServerId { get; set; }

    /// <summary>
    /// Mailing Campaigns
    /// </summary>
    public bool? GroupMassMailingCampaign { get; set; }

    /// <summary>
    /// Dedicated Server
    /// </summary>
    public bool? MassMailingOutgoingMailServer { get; set; }

    /// <summary>
    /// Blacklist Option when Unsubscribing
    /// </summary>
    public bool? ShowBlacklistButtons { get; set; }

    /// <summary>
    /// 24H Stat Mailing Reports
    /// </summary>
    public bool? MassMailingReports { get; set; }

    /// <summary>
    /// Planning
    /// </summary>
    public bool? ModuleProjectForecast { get; set; }

    /// <summary>
    /// Task Logs
    /// </summary>
    public bool? ModuleHrTimesheet { get; set; }

    /// <summary>
    /// Sub-tasks
    /// </summary>
    public bool? GroupSubtaskProject { get; set; }

    /// <summary>
    /// Customer Ratings
    /// </summary>
    public bool? GroupProjectRating { get; set; }

    /// <summary>
    /// Project Stages
    /// </summary>
    public bool? GroupProjectStages { get; set; }

    /// <summary>
    /// Recurring Tasks
    /// </summary>
    public bool? GroupProjectRecurringTasks { get; set; }

    /// <summary>
    /// Task Dependencies
    /// </summary>
    public bool? GroupProjectTaskDependencies { get; set; }

    /// <summary>
    /// Milestones
    /// </summary>
    public bool? GroupProjectMilestone { get; set; }

    /// <summary>
    /// Repeat every
    /// </summary>
    public int? CrmAutoAssignmentIntervalNumber { get; set; }

    /// <summary>
    /// Auto Assignment Action
    /// </summary>
    public string? CrmAutoAssignmentAction { get; set; }

    /// <summary>
    /// Auto Assignment Interval Unit
    /// </summary>
    public string? CrmAutoAssignmentIntervalType { get; set; }

    /// <summary>
    /// Enrich lead automatically
    /// </summary>
    public string? LeadEnrichAuto { get; set; }

    /// <summary>
    /// Lead Scoring Starting Date in String
    /// </summary>
    public string? PredictiveLeadScoringStartDateStr { get; set; }

    /// <summary>
    /// Lead Scoring Frequency Fields in String
    /// </summary>
    public string? PredictiveLeadScoringFieldsStr { get; set; }

    /// <summary>
    /// Leads
    /// </summary>
    public bool? GroupUseLead { get; set; }

    /// <summary>
    /// Recurring Revenues
    /// </summary>
    public bool? GroupUseRecurringRevenues { get; set; }

    /// <summary>
    /// Multi Teams
    /// </summary>
    public bool? IsMembershipMulti { get; set; }

    /// <summary>
    /// Rule-Based Assignment
    /// </summary>
    public bool? CrmUseAutoAssignment { get; set; }

    /// <summary>
    /// Generate new leads based on their country, industries, size, etc.
    /// </summary>
    public bool? ModuleCrmIapMine { get; set; }

    /// <summary>
    /// Enrich your leads automatically with company data based on their email address.
    /// </summary>
    public bool? ModuleCrmIapEnrich { get; set; }

    /// <summary>
    /// Create Leads/Opportunities from your website&apos;s traffic
    /// </summary>
    public bool? ModuleWebsiteCrmIapReveal { get; set; }

    /// <summary>
    /// Create a lead mining request directly from the opportunity pipeline.
    /// </summary>
    public bool? LeadMiningInPipeline { get; set; }

    /// <summary>
    /// Auto Assignment Next Execution Date
    /// </summary>
    public DateTime? CrmAutoAssignmentRunDatetime { get; set; }

    /// <summary>
    /// Site Key
    /// </summary>
    public string? RecaptchaPublicKey { get; set; }

    /// <summary>
    /// Secret Key
    /// </summary>
    public string? RecaptchaPrivateKey { get; set; }

    /// <summary>
    /// Minimum score
    /// </summary>
    public double? RecaptchaMinScore { get; set; }

    /// <summary>
    /// website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Multi-website
    /// </summary>
    public bool? GroupMultiWebsite { get; set; }

    /// <summary>
    /// Module Website Livechat
    /// </summary>
    public bool? ModuleWebsiteLivechat { get; set; }

    /// <summary>
    /// Module Marketing Automation
    /// </summary>
    public bool? ModuleMarketingAutomation { get; set; }

    /// <summary>
    /// Paypal - Express Checkout
    /// </summary>
    public bool? ModulePaymentPaypal { get; set; }

    /// <summary>
    /// Expiration Dates
    /// </summary>
    public bool? ModuleProductExpiry { get; set; }

    /// <summary>
    /// Lots &amp; Serial Numbers
    /// </summary>
    public bool? GroupStockProductionLot { get; set; }

    /// <summary>
    /// Print GS1 Barcodes for Lots &amp; Serial Numbers
    /// </summary>
    public bool? GroupStockLotPrintGs1 { get; set; }

    /// <summary>
    /// Display Lots &amp; Serial Numbers on Delivery Slips
    /// </summary>
    public bool? GroupLotOnDeliverySlip { get; set; }

    /// <summary>
    /// Packages
    /// </summary>
    public bool? GroupStockTrackingLot { get; set; }

    /// <summary>
    /// Consignment
    /// </summary>
    public bool? GroupStockTrackingOwner { get; set; }

    /// <summary>
    /// Multi-Step Routes
    /// </summary>
    public bool? GroupStockAdvLocation { get; set; }

    /// <summary>
    /// Warnings for Stock
    /// </summary>
    public bool? GroupWarningStock { get; set; }

    /// <summary>
    /// Signature
    /// </summary>
    public bool? GroupStockSignDelivery { get; set; }

    /// <summary>
    /// Batch Transfers
    /// </summary>
    public bool? ModuleStockPickingBatch { get; set; }

    /// <summary>
    /// Wave Transfers
    /// </summary>
    public bool? GroupStockPickingWave { get; set; }

    /// <summary>
    /// Barcode Scanner
    /// </summary>
    public bool? ModuleStockBarcode { get; set; }

    /// <summary>
    /// SMS Confirmation
    /// </summary>
    public bool? ModuleStockSms { get; set; }

    /// <summary>
    /// Quality
    /// </summary>
    public bool? ModuleQualityControl { get; set; }

    /// <summary>
    /// Quality Worksheet
    /// </summary>
    public bool? ModuleQualityControlWorksheet { get; set; }

    /// <summary>
    /// Storage Locations
    /// </summary>
    public bool? GroupStockMultiLocations { get; set; }

    /// <summary>
    /// Storage Categories
    /// </summary>
    public bool? GroupStockStorageCategories { get; set; }

    /// <summary>
    /// Reception Report
    /// </summary>
    public bool? GroupStockReceptionReport { get; set; }

    /// <summary>
    /// Landed Costs
    /// </summary>
    public bool? ModuleStockLandedCosts { get; set; }

    /// <summary>
    /// Display Lots &amp; Serial Numbers on Invoices
    /// </summary>
    public bool? GroupLotOnInvoice { get; set; }

    /// <summary>
    /// Picking Policy
    /// </summary>
    public string DefaultPickingPolicy { get; set; } = null!;

    /// <summary>
    /// Incoterms
    /// </summary>
    public bool? GroupDisplayIncoterm { get; set; }

    /// <summary>
    /// Security Lead Time for Sales
    /// </summary>
    public bool? UseSecurityLead { get; set; }

    /// <summary>
    /// Online Posting
    /// </summary>
    public bool? ModuleWebsiteHrRecruitment { get; set; }

    /// <summary>
    /// Interview Forms
    /// </summary>
    public bool? ModuleHrRecruitmentSurvey { get; set; }

    /// <summary>
    /// Group Applicant Cv Display
    /// </summary>
    public bool? GroupApplicantCvDisplay { get; set; }

    /// <summary>
    /// Send CV to OCR to fill applications
    /// </summary>
    public bool? ModuleHrRecruitmentExtract { get; set; }

    /// <summary>
    /// Bill Control
    /// </summary>
    public string? DefaultPurchaseMethod { get; set; }

    /// <summary>
    /// Lock Confirmed Orders
    /// </summary>
    public bool? LockConfirmedPo { get; set; }

    /// <summary>
    /// Purchase Order Approval
    /// </summary>
    public bool? PoOrderApproval { get; set; }

    /// <summary>
    /// Purchase Warnings
    /// </summary>
    public bool? GroupWarningPurchase { get; set; }

    /// <summary>
    /// 3-way matching: purchases, receptions and bills
    /// </summary>
    public bool? ModuleAccount3wayMatch { get; set; }

    /// <summary>
    /// Purchase Agreements
    /// </summary>
    public bool? ModulePurchaseRequisition { get; set; }

    /// <summary>
    /// Purchase Grid Entry
    /// </summary>
    public bool? ModulePurchaseProductMatrix { get; set; }

    /// <summary>
    /// Security Lead Time for Purchase
    /// </summary>
    public bool? UsePoLead { get; set; }

    /// <summary>
    /// Receipt Reminder
    /// </summary>
    public bool? GroupSendReminder { get; set; }

    /// <summary>
    /// Dropshipping
    /// </summary>
    public bool? ModuleStockDropshipping { get; set; }

    /// <summary>
    /// Is the Sale Module Installed
    /// </summary>
    public bool? IsInstalledSale { get; set; }

    /// <summary>
    /// Point of Sale
    /// </summary>
    public int? PosConfigId { get; set; }

    /// <summary>
    /// Default Fiscal Position
    /// </summary>
    public int? PosDefaultFiscalPositionId { get; set; }

    /// <summary>
    /// Initial Category
    /// </summary>
    public int? PosIfaceStartCategId { get; set; }

    /// <summary>
    /// Default Pricelist
    /// </summary>
    public int? PosPricelistId { get; set; }

    /// <summary>
    /// Tip Product
    /// </summary>
    public int? PosTipProductId { get; set; }

    /// <summary>
    /// IP Address
    /// </summary>
    public string? PosProxyIp { get; set; }

    /// <summary>
    /// Receipt Footer
    /// </summary>
    public string? PosReceiptFooter { get; set; }

    /// <summary>
    /// Receipt Header
    /// </summary>
    public string? PosReceiptHeader { get; set; }

    /// <summary>
    /// Vantiv Payment Terminal
    /// </summary>
    public bool? ModulePosMercury { get; set; }

    /// <summary>
    /// Adyen Payment Terminal
    /// </summary>
    public bool? ModulePosAdyen { get; set; }

    /// <summary>
    /// Stripe Payment Terminal
    /// </summary>
    public bool? ModulePosStripe { get; set; }

    /// <summary>
    /// Six Payment Terminal
    /// </summary>
    public bool? ModulePosSix { get; set; }

    /// <summary>
    /// Cashdrawer
    /// </summary>
    public bool? PosIfaceCashdrawer { get; set; }

    /// <summary>
    /// Customer Facing Display
    /// </summary>
    public bool? PosIfaceCustomerFacingDisplayViaProxy { get; set; }

    /// <summary>
    /// Electronic Scale
    /// </summary>
    public bool? PosIfaceElectronicScale { get; set; }

    /// <summary>
    /// Print via Proxy
    /// </summary>
    public bool? PosIfacePrintViaProxy { get; set; }

    /// <summary>
    /// Scan via Proxy
    /// </summary>
    public bool? PosIfaceScanViaProxy { get; set; }

    /// <summary>
    /// Pos Epson Printer Ip
    /// </summary>
    public string? PosEpsonPrinterIp { get; set; }

    /// <summary>
    /// Default Manufacturing Lead Time
    /// </summary>
    public bool? UseManufacturingLead { get; set; }

    /// <summary>
    /// By-Products
    /// </summary>
    public bool? GroupMrpByproducts { get; set; }

    /// <summary>
    /// Master Production Schedule
    /// </summary>
    public bool? ModuleMrpMps { get; set; }

    /// <summary>
    /// Product Lifecycle Management (PLM)
    /// </summary>
    public bool? ModuleMrpPlm { get; set; }

    /// <summary>
    /// Work Orders
    /// </summary>
    public bool? ModuleMrpWorkorder { get; set; }

    /// <summary>
    /// Subcontracting
    /// </summary>
    public bool? ModuleMrpSubcontracting { get; set; }

    /// <summary>
    /// MRP Work Orders
    /// </summary>
    public bool? GroupMrpRoutings { get; set; }

    /// <summary>
    /// Unlock Manufacturing Orders
    /// </summary>
    public bool? GroupUnlockedByDefault { get; set; }

    /// <summary>
    /// Allocation Report for Manufacturing Orders
    /// </summary>
    public bool? GroupMrpReceptionReport { get; set; }

    /// <summary>
    /// Work Order Dependencies
    /// </summary>
    public bool? GroupMrpWorkorderDependencies { get; set; }

    /// <summary>
    /// Shipping Management
    /// </summary>
    public string? SaleDeliverySettings { get; set; }

    /// <summary>
    /// Module Website Sale Delivery
    /// </summary>
    public bool? ModuleWebsiteSaleDelivery { get; set; }

    /// <summary>
    /// Shipping Address
    /// </summary>
    public bool? GroupDeliveryInvoiceAddress { get; set; }

    /// <summary>
    /// Base Unit Price
    /// </summary>
    public bool? GroupShowUomPrice { get; set; }

    /// <summary>
    /// Comparison Price
    /// </summary>
    public bool? GroupProductPriceComparison { get; set; }

    /// <summary>
    /// Digital Content
    /// </summary>
    public bool? ModuleWebsiteSaleDigital { get; set; }

    /// <summary>
    /// Wishlists
    /// </summary>
    public bool? ModuleWebsiteSaleWishlist { get; set; }

    /// <summary>
    /// Product Comparison Tool
    /// </summary>
    public bool? ModuleWebsiteSaleComparison { get; set; }

    /// <summary>
    /// Address Autocomplete
    /// </summary>
    public bool? ModuleWebsiteSaleAutocomplete { get; set; }

    /// <summary>
    /// Invoicing
    /// </summary>
    public bool? ModuleAccount { get; set; }

    /// <summary>
    /// On Site Payments &amp; Picking
    /// </summary>
    public bool? ModuleWebsiteSalePicking { get; set; }

    /// <summary>
    /// Mondial Relay Connector
    /// </summary>
    public bool? ModuleDeliveryMondialrelay { get; set; }

    /// <summary>
    /// Extra Step During Checkout
    /// </summary>
    public bool? EnabledExtraCheckoutStep { get; set; }

    /// <summary>
    /// Buy Now
    /// </summary>
    public bool? EnabledBuyNowButton { get; set; }

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

    /// <summary>
    /// Default Alias Name for Expenses
    /// </summary>
    public string? ExpenseAliasPrefix { get; set; }

    /// <summary>
    /// Let your employees record expenses by email
    /// </summary>
    public bool? UseMailgateway { get; set; }

    /// <summary>
    /// Reimburse Expenses in Payslip
    /// </summary>
    public bool? ModuleHrPayrollExpense { get; set; }

    /// <summary>
    /// Send bills to OCR to generate expenses
    /// </summary>
    public bool? ModuleHrExpenseExtract { get; set; }

    /// <summary>
    /// Delay alert contract outdated
    /// </summary>
    public int? DelayAlertContract { get; set; }

    /// <summary>
    /// Sell on eCommerce
    /// </summary>
    public bool? ModuleWebsiteSaleSlides { get; set; }

    /// <summary>
    /// Forum
    /// </summary>
    public bool? ModuleWebsiteSlidesForum { get; set; }

    /// <summary>
    /// Certifications
    /// </summary>
    public bool? ModuleWebsiteSlidesSurvey { get; set; }

    /// <summary>
    /// Mailing
    /// </summary>
    public bool? ModuleMassMailingSlides { get; set; }

    /// <summary>
    /// Tickets
    /// </summary>
    public bool? ModuleEventSale { get; set; }

    /// <summary>
    /// Discussion Rooms
    /// </summary>
    public bool? ModuleWebsiteEventMeet { get; set; }

    /// <summary>
    /// Tracks and Agenda
    /// </summary>
    public bool? ModuleWebsiteEventTrack { get; set; }

    /// <summary>
    /// Live Mode
    /// </summary>
    public bool? ModuleWebsiteEventTrackLive { get; set; }

    /// <summary>
    /// Quiz on Tracks
    /// </summary>
    public bool? ModuleWebsiteEventTrackQuiz { get; set; }

    /// <summary>
    /// Advanced Sponsors
    /// </summary>
    public bool? ModuleWebsiteEventExhibitor { get; set; }

    /// <summary>
    /// Registration Survey
    /// </summary>
    public bool? ModuleWebsiteEventQuestions { get; set; }

    /// <summary>
    /// Barcode
    /// </summary>
    public bool? ModuleEventBarcode { get; set; }

    /// <summary>
    /// Online Ticketing
    /// </summary>
    public bool? ModuleWebsiteEventSale { get; set; }

    /// <summary>
    /// Booth Management
    /// </summary>
    public bool? ModuleEventBooth { get; set; }

    /// <summary>
    /// Tolerance Time In Favor Of Company
    /// </summary>
    public int? OvertimeCompanyThreshold { get; set; }

    /// <summary>
    /// Tolerance Time In Favor Of Employee
    /// </summary>
    public int? OvertimeEmployeeThreshold { get; set; }

    /// <summary>
    /// Extra Hours Starting Date
    /// </summary>
    public DateOnly? OvertimeStartDate { get; set; }

    /// <summary>
    /// Employee PIN
    /// </summary>
    public bool? GroupAttendanceUsePin { get; set; }

    /// <summary>
    /// Count Extra Hours
    /// </summary>
    public bool? HrAttendanceOvertime { get; set; }

    public virtual ResUser? AuthSignupTemplateUser { get; set; }

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? DepositDefaultProduct { get; set; }

    public virtual DigestDigest? Digest { get; set; }

    public virtual MailTemplate? InvoiceMailTemplate { get; set; }

    public virtual IrMailServer? MassMailingMailServer { get; set; }

    public virtual PosConfig? PosConfig { get; set; }

    public virtual AccountFiscalPosition? PosDefaultFiscalPosition { get; set; }

    public virtual PosCategory? PosIfaceStartCateg { get; set; }

    public virtual ProductPricelist? PosPricelist { get; set; }

    public virtual ProductProduct? PosTipProduct { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; set; } = new List<AccountFiscalPosition>();

    public virtual ICollection<PosCategory> PosCategories { get; set; } = new List<PosCategory>();

    public virtual ICollection<ProductPricelist> ProductPricelists { get; set; } = new List<ProductPricelist>();
}
