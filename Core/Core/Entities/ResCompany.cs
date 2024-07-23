using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ResCompany
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int PartnerId { get; set; }

    public int CurrencyId { get; set; }

    public int? Sequence { get; set; }

    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Parent Company
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Paper format
    /// </summary>
    public int? PaperformatId { get; set; }

    /// <summary>
    /// Document Template
    /// </summary>
    public int? ExternalReportLayoutId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Mobile
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// State of the onboarding company step
    /// </summary>
    public string? BaseOnboardingCompanyState { get; set; }

    /// <summary>
    /// Font
    /// </summary>
    public string? Font { get; set; }

    /// <summary>
    /// Primary Color
    /// </summary>
    public string? PrimaryColor { get; set; }

    /// <summary>
    /// Secondary Color
    /// </summary>
    public string? SecondaryColor { get; set; }

    /// <summary>
    /// Layout Background
    /// </summary>
    public string LayoutBackground { get; set; } = null!;

    /// <summary>
    /// Report Footer
    /// </summary>
    public string? ReportFooter { get; set; }

    /// <summary>
    /// Company Tagline
    /// </summary>
    public string? ReportHeader { get; set; }

    /// <summary>
    /// Company Details
    /// </summary>
    public string? CompanyDetails { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Logo Web
    /// </summary>
    public byte[]? LogoWeb { get; set; }

    /// <summary>
    /// Default Working Hours
    /// </summary>
    public int? ResourceCalendarId { get; set; }

    /// <summary>
    /// Company database ID
    /// </summary>
    public int? PartnerGid { get; set; }

    /// <summary>
    /// Enrich Done
    /// </summary>
    public bool? IapEnrichAutoDone { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public bool? SnailmailColor { get; set; }

    /// <summary>
    /// Add a Cover Page
    /// </summary>
    public bool? SnailmailCover { get; set; }

    /// <summary>
    /// Both sides
    /// </summary>
    public bool? SnailmailDuplex { get; set; }

    /// <summary>
    /// State of the onboarding payment provider step
    /// </summary>
    public string? PaymentProviderOnboardingState { get; set; }

    /// <summary>
    /// Selected onboarding payment method
    /// </summary>
    public string? PaymentOnboardingPaymentMethod { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Fiscalyear Last Day
    /// </summary>
    public int FiscalyearLastDay { get; set; }

    /// <summary>
    /// Inter-Banks Transfer Account
    /// </summary>
    public int? TransferAccountId { get; set; }

    /// <summary>
    /// Chart Template
    /// </summary>
    public int? ChartTemplateId { get; set; }

    /// <summary>
    /// Cash Difference Income Account
    /// </summary>
    public int? DefaultCashDifferenceIncomeAccountId { get; set; }

    /// <summary>
    /// Cash Difference Expense Account
    /// </summary>
    public int? DefaultCashDifferenceExpenseAccountId { get; set; }

    /// <summary>
    /// Journal Suspense Account
    /// </summary>
    public int? AccountJournalSuspenseAccountId { get; set; }

    /// <summary>
    /// Journal Outstanding Receipts Account
    /// </summary>
    public int? AccountJournalPaymentDebitAccountId { get; set; }

    /// <summary>
    /// Journal Outstanding Payments Account
    /// </summary>
    public int? AccountJournalPaymentCreditAccountId { get; set; }

    /// <summary>
    /// Cash Discount Write-Off Gain Account
    /// </summary>
    public int? AccountJournalEarlyPayDiscountGainAccountId { get; set; }

    /// <summary>
    /// Cash Discount Write-Off Loss Account
    /// </summary>
    public int? AccountJournalEarlyPayDiscountLossAccountId { get; set; }

    /// <summary>
    /// Default Sale Tax
    /// </summary>
    public int? AccountSaleTaxId { get; set; }

    /// <summary>
    /// Default Purchase Tax
    /// </summary>
    public int? AccountPurchaseTaxId { get; set; }

    /// <summary>
    /// Exchange Gain or Loss Journal
    /// </summary>
    public int? CurrencyExchangeJournalId { get; set; }

    /// <summary>
    /// Gain Exchange Rate Account
    /// </summary>
    public int? IncomeCurrencyExchangeAccountId { get; set; }

    /// <summary>
    /// Loss Exchange Rate Account
    /// </summary>
    public int? ExpenseCurrencyExchangeAccountId { get; set; }

    /// <summary>
    /// Input Account for Stock Valuation
    /// </summary>
    public int? PropertyStockAccountInputCategId { get; set; }

    /// <summary>
    /// Output Account for Stock Valuation
    /// </summary>
    public int? PropertyStockAccountOutputCategId { get; set; }

    /// <summary>
    /// Account Template for Stock Valuation
    /// </summary>
    public int? PropertyStockValuationAccountId { get; set; }

    /// <summary>
    /// Default incoterm
    /// </summary>
    public int? IncotermId { get; set; }

    /// <summary>
    /// Opening Journal Entry
    /// </summary>
    public int? AccountOpeningMoveId { get; set; }

    /// <summary>
    /// Default PoS Receivable Account
    /// </summary>
    public int? AccountDefaultPosReceivableAccountId { get; set; }

    /// <summary>
    /// Expense Accrual Account
    /// </summary>
    public int? ExpenseAccrualAccountId { get; set; }

    /// <summary>
    /// Revenue Accrual Account
    /// </summary>
    public int? RevenueAccrualAccountId { get; set; }

    /// <summary>
    /// Automatic Entry Default Journal
    /// </summary>
    public int? AutomaticEntryDefaultJournalId { get; set; }

    /// <summary>
    /// Fiscal Country
    /// </summary>
    public int? AccountFiscalCountryId { get; set; }

    /// <summary>
    /// Cash Basis Journal
    /// </summary>
    public int? TaxCashBasisJournalId { get; set; }

    /// <summary>
    /// Base Tax Received Account
    /// </summary>
    public int? AccountCashBasisBaseAccountId { get; set; }

    /// <summary>
    /// Fiscalyear Last Month
    /// </summary>
    public string FiscalyearLastMonth { get; set; } = null!;

    /// <summary>
    /// Prefix of the bank accounts
    /// </summary>
    public string? BankAccountCodePrefix { get; set; }

    /// <summary>
    /// Prefix of the cash accounts
    /// </summary>
    public string? CashAccountCodePrefix { get; set; }

    /// <summary>
    /// Cash Discount Tax Reduction
    /// </summary>
    public string? EarlyPayDiscountComputation { get; set; }

    /// <summary>
    /// Prefix of the transfer accounts
    /// </summary>
    public string? TransferAccountCodePrefix { get; set; }

    /// <summary>
    /// Tax Calculation Rounding Method
    /// </summary>
    public string? TaxCalculationRoundingMethod { get; set; }

    /// <summary>
    /// State of the onboarding bank data step
    /// </summary>
    public string? AccountSetupBankDataState { get; set; }

    /// <summary>
    /// State of the onboarding fiscal year step
    /// </summary>
    public string? AccountSetupFyDataState { get; set; }

    /// <summary>
    /// State of the onboarding charts of account step
    /// </summary>
    public string? AccountSetupCoaState { get; set; }

    /// <summary>
    /// State of the onboarding Taxes step
    /// </summary>
    public string? AccountSetupTaxesState { get; set; }

    /// <summary>
    /// State of the onboarding invoice layout step
    /// </summary>
    public string? AccountOnboardingInvoiceLayoutState { get; set; }

    /// <summary>
    /// State of the onboarding sale tax step
    /// </summary>
    public string? AccountOnboardingSaleTaxState { get; set; }

    /// <summary>
    /// State of the account invoice onboarding panel
    /// </summary>
    public string? AccountInvoiceOnboardingState { get; set; }

    /// <summary>
    /// State of the account dashboard onboarding panel
    /// </summary>
    public string? AccountDashboardOnboardingState { get; set; }

    /// <summary>
    /// Terms &amp; Conditions format
    /// </summary>
    public string? TermsType { get; set; }

    /// <summary>
    /// State of the onboarding bill step
    /// </summary>
    public string? AccountSetupBillState { get; set; }

    /// <summary>
    /// Quick encoding
    /// </summary>
    public string? QuickEditMode { get; set; }

    /// <summary>
    /// Journals Entries Lock Date
    /// </summary>
    public DateOnly? PeriodLockDate { get; set; }

    /// <summary>
    /// All Users Lock Date
    /// </summary>
    public DateOnly? FiscalyearLockDate { get; set; }

    /// <summary>
    /// Tax Return Lock Date
    /// </summary>
    public DateOnly? TaxLockDate { get; set; }

    /// <summary>
    /// Opening Entry
    /// </summary>
    public DateOnly AccountOpeningDate { get; set; }

    /// <summary>
    /// Default Terms and Conditions
    /// </summary>
    public string? InvoiceTerms { get; set; }

    /// <summary>
    /// Default Terms and Conditions as a Web page
    /// </summary>
    public string? InvoiceTermsHtml { get; set; }

    /// <summary>
    /// Expects a Chart of Accounts
    /// </summary>
    public bool? ExpectsChartOfAccounts { get; set; }

    /// <summary>
    /// Use anglo-saxon accounting
    /// </summary>
    public bool? AngloSaxonAccounting { get; set; }

    /// <summary>
    /// Display QR-code on invoices
    /// </summary>
    public bool? QrCode { get; set; }

    /// <summary>
    /// Email by default
    /// </summary>
    public bool? InvoiceIsEmail { get; set; }

    /// <summary>
    /// Print by default
    /// </summary>
    public bool? InvoiceIsPrint { get; set; }

    /// <summary>
    /// Sales Credit Limit
    /// </summary>
    public bool? AccountUseCreditLimit { get; set; }

    /// <summary>
    /// Account Onboarding Create Invoice State Flag
    /// </summary>
    public bool? AccountOnboardingCreateInvoiceStateFlag { get; set; }

    /// <summary>
    /// Use Cash Basis
    /// </summary>
    public bool? TaxExigibility { get; set; }

    /// <summary>
    /// Storno accounting
    /// </summary>
    public bool? AccountStorno { get; set; }

    /// <summary>
    /// Send by Post
    /// </summary>
    public bool? InvoiceIsSnailmail { get; set; }

    /// <summary>
    /// Default Quotation Validity (Days)
    /// </summary>
    public int? QuotationValidityDays { get; set; }

    /// <summary>
    /// State of the sale onboarding panel
    /// </summary>
    public string? SaleQuotationOnboardingState { get; set; }

    /// <summary>
    /// State of the onboarding confirmation order step
    /// </summary>
    public string? SaleOnboardingOrderConfirmationState { get; set; }

    /// <summary>
    /// State of the onboarding sample quotation step
    /// </summary>
    public string? SaleOnboardingSampleQuotationState { get; set; }

    /// <summary>
    /// Sale onboarding selected payment method
    /// </summary>
    public string? SaleOnboardingPaymentMethod { get; set; }

    /// <summary>
    /// Online Signature
    /// </summary>
    public bool? PortalConfirmationSign { get; set; }

    /// <summary>
    /// Online Payment
    /// </summary>
    public bool? PortalConfirmationPay { get; set; }

    /// <summary>
    /// Default Sale Template
    /// </summary>
    public int? SaleOrderTemplateId { get; set; }

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
    /// # emails to send
    /// </summary>
    public int? HrPresenceControlEmailAmount { get; set; }

    /// <summary>
    /// Valid IP addresses
    /// </summary>
    public string? HrPresenceControlIpList { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Nomenclature
    /// </summary>
    public int? NomenclatureId { get; set; }

    /// <summary>
    /// Internal Transit Location
    /// </summary>
    public int? InternalTransitLocationId { get; set; }

    /// <summary>
    /// Email Template confirmation picking
    /// </summary>
    public int? StockMailConfirmationTemplateId { get; set; }

    /// <summary>
    /// Day of the month
    /// </summary>
    public int? AnnualInventoryDay { get; set; }

    /// <summary>
    /// Annual Inventory Month
    /// </summary>
    public string? AnnualInventoryMonth { get; set; }

    /// <summary>
    /// Email Confirmation picking
    /// </summary>
    public bool? StockMoveEmailValidation { get; set; }

    /// <summary>
    /// SMS Template
    /// </summary>
    public int? StockSmsConfirmationTemplateId { get; set; }

    /// <summary>
    /// SMS Confirmation
    /// </summary>
    public bool? StockMoveSmsValidation { get; set; }

    /// <summary>
    /// Has Received Warning Stock Sms
    /// </summary>
    public bool? HasReceivedWarningStockSms { get; set; }

    /// <summary>
    /// Sales Safety Days
    /// </summary>
    public double SecurityLead { get; set; }

    /// <summary>
    /// Purchase Order Modification
    /// </summary>
    public string? PoLock { get; set; }

    /// <summary>
    /// Levels of Approvals
    /// </summary>
    public string? PoDoubleValidation { get; set; }

    /// <summary>
    /// Double validation amount
    /// </summary>
    public decimal? PoDoubleValidationAmount { get; set; }

    /// <summary>
    /// Purchase Lead Time
    /// </summary>
    public double PoLead { get; set; }

    /// <summary>
    /// Days to Purchase
    /// </summary>
    public double? DaysToPurchase { get; set; }

    /// <summary>
    /// Update quantities in stock
    /// </summary>
    public string? PointOfSaleUpdateStockQuantities { get; set; }

    /// <summary>
    /// Use QR code on ticket
    /// </summary>
    public bool? PointOfSaleUseTicketQrCode { get; set; }

    /// <summary>
    /// Manufacturing Lead Time
    /// </summary>
    public double ManufacturingLead { get; set; }

    /// <summary>
    /// State of the website sale onboarding payment provider step
    /// </summary>
    public string? WebsiteSaleOnboardingPaymentProviderState { get; set; }

    /// <summary>
    /// Default Expense Journal
    /// </summary>
    public int? ExpenseJournalId { get; set; }

    /// <summary>
    /// Default Company Expense Journal
    /// </summary>
    public int? CompanyExpenseJournalId { get; set; }

    /// <summary>
    /// Tolerance Time In Favor Of Company
    /// </summary>
    public int? OvertimeCompanyThreshold { get; set; }

    /// <summary>
    /// Tolerance Time In Favor Of Employee
    /// </summary>
    public int? OvertimeEmployeeThreshold { get; set; }

    /// <summary>
    /// Attendance Kiosk Delay
    /// </summary>
    public int? AttendanceKioskDelay { get; set; }

    /// <summary>
    /// Attendance Mode
    /// </summary>
    public string? AttendanceKioskMode { get; set; }

    /// <summary>
    /// Barcode Source
    /// </summary>
    public string? AttendanceBarcodeSource { get; set; }

    /// <summary>
    /// Extra Hours Starting Date
    /// </summary>
    public DateOnly? OvertimeStartDate { get; set; }

    /// <summary>
    /// Count Extra Hours
    /// </summary>
    public bool? HrAttendanceOvertime { get; set; }

    /// <summary>
    /// Lunch Notify Message
    /// </summary>
    public string? LunchNotifyMessage { get; set; }

    /// <summary>
    /// Lunch Minimum Threshold
    /// </summary>
    public double? LunchMinimumThreshold { get; set; }

    public virtual ICollection<AccountAccount> AccountAccounts { get; set; } = new List<AccountAccount>();

    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizards { get; set; } = new List<AccountAccruedOrdersWizard>();

    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; set; } = new List<AccountAnalyticAccount>();

    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; set; } = new List<AccountAnalyticDistributionModel>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountAnalyticPlan> AccountAnalyticPlans { get; set; } = new List<AccountAnalyticPlan>();

    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizards { get; set; } = new List<AccountAutomaticEntryWizard>();

    public virtual ICollection<AccountBankStatement> AccountBankStatements { get; set; } = new List<AccountBankStatement>();

    public virtual AccountAccount? AccountCashBasisBaseAccount { get; set; }

    public virtual AccountAccount? AccountDefaultPosReceivableAccount { get; set; }

    public virtual ICollection<AccountFinancialYearOp> AccountFinancialYearOps { get; set; } = new List<AccountFinancialYearOp>();

    public virtual ResCountry? AccountFiscalCountry { get; set; }

    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccounts { get; set; } = new List<AccountFiscalPositionAccount>();

    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxes { get; set; } = new List<AccountFiscalPositionTax>();

    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; set; } = new List<AccountFiscalPosition>();

    public virtual ICollection<AccountGroup> AccountGroups { get; set; } = new List<AccountGroup>();

    public virtual AccountAccount? AccountJournalEarlyPayDiscountGainAccount { get; set; }

    public virtual AccountAccount? AccountJournalEarlyPayDiscountLossAccount { get; set; }

    public virtual ICollection<AccountJournalGroup> AccountJournalGroups { get; set; } = new List<AccountJournalGroup>();

    public virtual AccountAccount? AccountJournalPaymentCreditAccount { get; set; }

    public virtual AccountAccount? AccountJournalPaymentDebitAccount { get; set; }

    public virtual AccountAccount? AccountJournalSuspenseAccount { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMoveReversal> AccountMoveReversals { get; set; } = new List<AccountMoveReversal>();

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual AccountMove? AccountOpeningMove { get; set; }

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; set; } = new List<AccountPartialReconcile>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPaymentTerm> AccountPaymentTerms { get; set; } = new List<AccountPaymentTerm>();

    public virtual AccountTax? AccountPurchaseTax { get; set; }

    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; set; } = new List<AccountReconcileModelLine>();

    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; set; } = new List<AccountReconcileModel>();

    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; set; } = new List<AccountReportExternalValue>();

    public virtual AccountTax? AccountSaleTax { get; set; }

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLines { get; set; } = new List<AccountTaxRepartitionLine>();

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();

    public virtual AccountJournal? AutomaticEntryDefaultJournal { get; set; }

    public virtual ICollection<BaseDocumentLayout> BaseDocumentLayouts { get; set; } = new List<BaseDocumentLayout>();

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual AccountJournal? CompanyExpenseJournal { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ICollection<CrmTeam> CrmTeams { get; set; } = new List<CrmTeam>();

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual AccountJournal? CurrencyExchangeJournal { get; set; }

    public virtual ICollection<DataRecycleRecord> DataRecycleRecords { get; set; } = new List<DataRecycleRecord>();

    public virtual AccountAccount? DefaultCashDifferenceExpenseAccount { get; set; }

    public virtual AccountAccount? DefaultCashDifferenceIncomeAccount { get; set; }

    public virtual ICollection<DigestDigest> DigestDigests { get; set; } = new List<DigestDigest>();

    public virtual ICollection<EventEvent> EventEvents { get; set; } = new List<EventEvent>();

    public virtual ICollection<EventLeadRule> EventLeadRules { get; set; } = new List<EventLeadRule>();

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual AccountAccount? ExpenseAccrualAccount { get; set; }

    public virtual AccountAccount? ExpenseCurrencyExchangeAccount { get; set; }

    public virtual AccountJournal? ExpenseJournal { get; set; }

    public virtual IrUiView? ExternalReportLayout { get; set; }

    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; set; } = new List<FleetVehicleLogContract>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; set; } = new List<FleetVehicleLogService>();

    public virtual ICollection<FleetVehicle> FleetVehicles { get; set; } = new List<FleetVehicle>();

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrContract> HrContracts { get; set; } = new List<HrContract>();

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; set; } = new List<HrExpenseSplit>();

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationEmployeeCompanies { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationModeCompanies { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaveEmployeeCompanies { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrLeave> HrLeaveModeCompanies { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDays { get; set; } = new List<HrLeaveStressDay>();

    public virtual ICollection<HrLeaveType> HrLeaveTypes { get; set; } = new List<HrLeaveType>();

    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypes { get; set; } = new List<HrPlanActivityType>();

    public virtual ICollection<HrPlan> HrPlans { get; set; } = new List<HrPlan>();

    public virtual ICollection<HrWorkLocation> HrWorkLocations { get; set; } = new List<HrWorkLocation>();

    public virtual AccountAccount? IncomeCurrencyExchangeAccount { get; set; }

    public virtual AccountIncoterm? Incoterm { get; set; }

    public virtual StockLocation? InternalTransitLocation { get; set; }

    public virtual ICollection<ResCompany> InverseParent { get; set; } = new List<ResCompany>();

    public virtual ICollection<IrAttachment> IrAttachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<IrDefault> IrDefaults { get; set; } = new List<IrDefault>();

    public virtual ICollection<IrProperty> IrProperties { get; set; } = new List<IrProperty>();

    public virtual ICollection<IrSequence> IrSequences { get; set; } = new List<IrSequence>();

    public virtual ICollection<LunchLocation> LunchLocations { get; set; } = new List<LunchLocation>();

    public virtual ICollection<LunchOrder> LunchOrders { get; set; } = new List<LunchOrder>();

    public virtual ICollection<LunchProductCategory> LunchProductCategories { get; set; } = new List<LunchProductCategory>();

    public virtual ICollection<LunchProduct> LunchProducts { get; set; } = new List<LunchProduct>();

    public virtual ICollection<LunchSupplier> LunchSuppliers { get; set; } = new List<LunchSupplier>();

    public virtual ICollection<LunchTopping> LunchToppings { get; set; } = new List<LunchTopping>();

    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategories { get; set; } = new List<MaintenanceEquipmentCategory>();

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; set; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();

    public virtual ICollection<MaintenanceTeam> MaintenanceTeams { get; set; } = new List<MaintenanceTeam>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; set; } = new List<MrpBomByproduct>();

    public virtual ICollection<MrpBomLine> MrpBomLines { get; set; } = new List<MrpBomLine>();

    public virtual ICollection<MrpBom> MrpBoms { get; set; } = new List<MrpBom>();

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; set; } = new List<MrpUnbuild>();

    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; set; } = new List<MrpWorkcenterProductivity>();

    public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; set; } = new List<MrpWorkcenter>();

    public virtual BarcodeNomenclature? Nomenclature { get; set; }

    public virtual ICollection<NoteNote> NoteNotes { get; set; } = new List<NoteNote>();

    public virtual ReportPaperformat? Paperformat { get; set; }

    public virtual ResCompany? Parent { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ICollection<PaymentProvider> PaymentProviders { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<PaymentToken> PaymentTokens { get; set; } = new List<PaymentToken>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosOrderLine> PosOrderLines { get; set; } = new List<PosOrderLine>();

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<PosPaymentMethod> PosPaymentMethods { get; set; } = new List<PosPaymentMethod>();

    public virtual ICollection<PosPayment> PosPayments { get; set; } = new List<PosPayment>();

    public virtual ICollection<ProductPackaging> ProductPackagings { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelist> ProductPricelists { get; set; } = new List<ProductPricelist>();

    public virtual ICollection<ProductReplenish> ProductReplenishes { get; set; } = new List<ProductReplenish>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProjectProject> ProjectProjects { get; set; } = new List<ProjectProject>();

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual AccountAccount? PropertyStockAccountInputCateg { get; set; }

    public virtual AccountAccount? PropertyStockAccountOutputCateg { get; set; }

    public virtual AccountAccount? PropertyStockValuationAccount { get; set; }

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<RepairFee> RepairFees { get; set; } = new List<RepairFee>();

    public virtual ICollection<RepairLine> RepairLines { get; set; } = new List<RepairLine>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResCurrencyRate> ResCurrencyRates { get; set; } = new List<ResCurrencyRate>();

    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ICollection<ResourceCalendar> ResourceCalendars { get; set; } = new List<ResourceCalendar>();

    public virtual ICollection<ResourceResource> ResourceResources { get; set; } = new List<ResourceResource>();

    public virtual AccountAccount? RevenueAccrualAccount { get; set; }

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; set; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; set; } = new List<SaleOrderTemplateLine>();

    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; set; } = new List<SaleOrderTemplateOption>();

    public virtual ICollection<SaleOrderTemplate> SaleOrderTemplates { get; set; } = new List<SaleOrderTemplate>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; set; } = new List<SnailmailLetter>();

    public virtual ICollection<StockLocation> StockLocations { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockLot> StockLots { get; set; } = new List<StockLot>();

    public virtual MailTemplate? StockMailConfirmationTemplate { get; set; }

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; set; } = new List<StockPackageLevel>();

    public virtual ICollection<StockPackageType> StockPackageTypes { get; set; } = new List<StockPackageType>();

    public virtual ICollection<StockPickingType> StockPickingTypes { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockPutawayRule> StockPutawayRules { get; set; } = new List<StockPutawayRule>();

    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockRoute> StockRoutes { get; set; } = new List<StockRoute>();

    public virtual ICollection<StockRule> StockRules { get; set; } = new List<StockRule>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual SmsTemplate? StockSmsConfirmationTemplate { get; set; }

    public virtual ICollection<StockStorageCategory> StockStorageCategories { get; set; } = new List<StockStorageCategory>();

    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; set; } = new List<StockValuationLayerRevaluation>();

    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; set; } = new List<StockValuationLayer>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehouses { get; set; } = new List<StockWarehouse>();

    public virtual AccountJournal? TaxCashBasisJournal { get; set; }

    public virtual AccountAccount? TransferAccount { get; set; }

    public virtual ICollection<UtmCampaign> UtmCampaigns { get; set; } = new List<UtmCampaign>();

    public virtual Website? Website { get; set; }

    public virtual ICollection<Website> Websites { get; set; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IapAccount> IapAccounts { get; set; } = new List<IapAccount>();

    public virtual ICollection<ResUser> Users { get; set; } = new List<ResUser>();
}
