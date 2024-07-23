using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ResUser
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int PartnerId { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public string Login { get; set; } = null!;

    public string? Password { get; set; }

    /// <summary>
    /// Home Action
    /// </summary>
    public int? ActionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Email Signature
    /// </summary>
    public string? Signature { get; set; }

    /// <summary>
    /// Share User
    /// </summary>
    public bool? Share { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Totp Secret
    /// </summary>
    public string? TotpSecret { get; set; }

    /// <summary>
    /// Notification
    /// </summary>
    public string NotificationType { get; set; } = null!;

    /// <summary>
    /// OdooBot Status
    /// </summary>
    public string? OdoobotState { get; set; }

    /// <summary>
    /// Odoobot Failed
    /// </summary>
    public bool? OdoobotFailed { get; set; }

    /// <summary>
    /// User Sales Team
    /// </summary>
    public int? SaleTeamId { get; set; }

    /// <summary>
    /// Karma
    /// </summary>
    public int? Karma { get; set; }

    /// <summary>
    /// Rank
    /// </summary>
    public int? RankId { get; set; }

    /// <summary>
    /// Next Rank
    /// </summary>
    public int? NextRankId { get; set; }

    /// <summary>
    /// Won in Opportunities Target
    /// </summary>
    public int? TargetSalesWon { get; set; }

    /// <summary>
    /// Activities Done Target
    /// </summary>
    public int? TargetSalesDone { get; set; }

    /// <summary>
    /// Invoiced in Sales Orders Target
    /// </summary>
    public int? TargetSalesInvoiced { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Livechat Username
    /// </summary>
    public string? LivechatUsername { get; set; }

    /// <summary>
    /// Last Lunch Location
    /// </summary>
    public int? LastLunchLocationId { get; set; }

    public virtual ICollection<AccountAccount> AccountAccountCreateUs { get; set; } = new List<AccountAccount>();

    public virtual ICollection<AccountAccountTag> AccountAccountTagCreateUs { get; set; } = new List<AccountAccountTag>();

    public virtual ICollection<AccountAccountTag> AccountAccountTagWriteUs { get; set; } = new List<AccountAccountTag>();

    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplateCreateUs { get; set; } = new List<AccountAccountTemplate>();

    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplateWriteUs { get; set; } = new List<AccountAccountTemplate>();

    public virtual ICollection<AccountAccount> AccountAccountWriteUs { get; set; } = new List<AccountAccount>();

    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizardCreateUs { get; set; } = new List<AccountAccruedOrdersWizard>();

    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizardWriteUs { get; set; } = new List<AccountAccruedOrdersWizard>();

    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountCreateUs { get; set; } = new List<AccountAnalyticAccount>();

    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountWriteUs { get; set; } = new List<AccountAnalyticAccount>();

    public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilityCreateUs { get; set; } = new List<AccountAnalyticApplicability>();

    public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilityWriteUs { get; set; } = new List<AccountAnalyticApplicability>();

    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModelCreateUs { get; set; } = new List<AccountAnalyticDistributionModel>();

    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModelWriteUs { get; set; } = new List<AccountAnalyticDistributionModel>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLineCreateUs { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLineUsers { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLineWriteUs { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountAnalyticPlan> AccountAnalyticPlanCreateUs { get; set; } = new List<AccountAnalyticPlan>();

    public virtual ICollection<AccountAnalyticPlan> AccountAnalyticPlanWriteUs { get; set; } = new List<AccountAnalyticPlan>();

    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizardCreateUs { get; set; } = new List<AccountAutomaticEntryWizard>();

    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizardWriteUs { get; set; } = new List<AccountAutomaticEntryWizard>();

    public virtual ICollection<AccountBankStatement> AccountBankStatementCreateUs { get; set; } = new List<AccountBankStatement>();

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineCreateUs { get; set; } = new List<AccountBankStatementLine>();

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineWriteUs { get; set; } = new List<AccountBankStatementLine>();

    public virtual ICollection<AccountBankStatement> AccountBankStatementWriteUs { get; set; } = new List<AccountBankStatement>();

    public virtual ICollection<AccountCashRounding> AccountCashRoundingCreateUs { get; set; } = new List<AccountCashRounding>();

    public virtual ICollection<AccountCashRounding> AccountCashRoundingWriteUs { get; set; } = new List<AccountCashRounding>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateCreateUs { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateWriteUs { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountEdiDocument> AccountEdiDocumentCreateUs { get; set; } = new List<AccountEdiDocument>();

    public virtual ICollection<AccountEdiDocument> AccountEdiDocumentWriteUs { get; set; } = new List<AccountEdiDocument>();

    public virtual ICollection<AccountEdiFormat> AccountEdiFormatCreateUs { get; set; } = new List<AccountEdiFormat>();

    public virtual ICollection<AccountEdiFormat> AccountEdiFormatWriteUs { get; set; } = new List<AccountEdiFormat>();

    public virtual ICollection<AccountFinancialYearOp> AccountFinancialYearOpCreateUs { get; set; } = new List<AccountFinancialYearOp>();

    public virtual ICollection<AccountFinancialYearOp> AccountFinancialYearOpWriteUs { get; set; } = new List<AccountFinancialYearOp>();

    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountCreateUs { get; set; } = new List<AccountFiscalPositionAccount>();

    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateCreateUs { get; set; } = new List<AccountFiscalPositionAccountTemplate>();

    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateWriteUs { get; set; } = new List<AccountFiscalPositionAccountTemplate>();

    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountWriteUs { get; set; } = new List<AccountFiscalPositionAccount>();

    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositionCreateUs { get; set; } = new List<AccountFiscalPosition>();

    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxCreateUs { get; set; } = new List<AccountFiscalPositionTax>();

    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateCreateUs { get; set; } = new List<AccountFiscalPositionTaxTemplate>();

    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplateWriteUs { get; set; } = new List<AccountFiscalPositionTaxTemplate>();

    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxWriteUs { get; set; } = new List<AccountFiscalPositionTax>();

    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplateCreateUs { get; set; } = new List<AccountFiscalPositionTemplate>();

    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplateWriteUs { get; set; } = new List<AccountFiscalPositionTemplate>();

    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositionWriteUs { get; set; } = new List<AccountFiscalPosition>();

    public virtual ICollection<AccountFullReconcile> AccountFullReconcileCreateUs { get; set; } = new List<AccountFullReconcile>();

    public virtual ICollection<AccountFullReconcile> AccountFullReconcileWriteUs { get; set; } = new List<AccountFullReconcile>();

    public virtual ICollection<AccountGroup> AccountGroupCreateUs { get; set; } = new List<AccountGroup>();

    public virtual ICollection<AccountGroupTemplate> AccountGroupTemplateCreateUs { get; set; } = new List<AccountGroupTemplate>();

    public virtual ICollection<AccountGroupTemplate> AccountGroupTemplateWriteUs { get; set; } = new List<AccountGroupTemplate>();

    public virtual ICollection<AccountGroup> AccountGroupWriteUs { get; set; } = new List<AccountGroup>();

    public virtual ICollection<AccountIncoterm> AccountIncotermCreateUs { get; set; } = new List<AccountIncoterm>();

    public virtual ICollection<AccountIncoterm> AccountIncotermWriteUs { get; set; } = new List<AccountIncoterm>();

    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSendCreateUs { get; set; } = new List<AccountInvoiceSend>();

    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSendWriteUs { get; set; } = new List<AccountInvoiceSend>();

    public virtual ICollection<AccountJournal> AccountJournalCreateUs { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountJournalGroup> AccountJournalGroupCreateUs { get; set; } = new List<AccountJournalGroup>();

    public virtual ICollection<AccountJournalGroup> AccountJournalGroupWriteUs { get; set; } = new List<AccountJournalGroup>();

    public virtual ICollection<AccountJournal> AccountJournalSaleActivityUsers { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountJournal> AccountJournalWriteUs { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountMove> AccountMoveCreateUs { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountMove> AccountMoveInvoiceUsers { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountMoveLine> AccountMoveLineCreateUs { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMoveLine> AccountMoveLineWriteUs { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMoveReversal> AccountMoveReversalCreateUs { get; set; } = new List<AccountMoveReversal>();

    public virtual ICollection<AccountMoveReversal> AccountMoveReversalWriteUs { get; set; } = new List<AccountMoveReversal>();

    public virtual ICollection<AccountMove> AccountMoveWriteUs { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileCreateUs { get; set; } = new List<AccountPartialReconcile>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileWriteUs { get; set; } = new List<AccountPartialReconcile>();

    public virtual ICollection<AccountPayment> AccountPaymentCreateUs { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountPaymentMethod> AccountPaymentMethodCreateUs { get; set; } = new List<AccountPaymentMethod>();

    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLineCreateUs { get; set; } = new List<AccountPaymentMethodLine>();

    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLineWriteUs { get; set; } = new List<AccountPaymentMethodLine>();

    public virtual ICollection<AccountPaymentMethod> AccountPaymentMethodWriteUs { get; set; } = new List<AccountPaymentMethod>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterCreateUs { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterWriteUs { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPaymentTerm> AccountPaymentTermCreateUs { get; set; } = new List<AccountPaymentTerm>();

    public virtual ICollection<AccountPaymentTermLine> AccountPaymentTermLineCreateUs { get; set; } = new List<AccountPaymentTermLine>();

    public virtual ICollection<AccountPaymentTermLine> AccountPaymentTermLineWriteUs { get; set; } = new List<AccountPaymentTermLine>();

    public virtual ICollection<AccountPaymentTerm> AccountPaymentTermWriteUs { get; set; } = new List<AccountPaymentTerm>();

    public virtual ICollection<AccountPayment> AccountPaymentWriteUs { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountReconcileModel> AccountReconcileModelCreateUs { get; set; } = new List<AccountReconcileModel>();

    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLineCreateUs { get; set; } = new List<AccountReconcileModelLine>();

    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplateCreateUs { get; set; } = new List<AccountReconcileModelLineTemplate>();

    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplateWriteUs { get; set; } = new List<AccountReconcileModelLineTemplate>();

    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLineWriteUs { get; set; } = new List<AccountReconcileModelLine>();

    public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappingCreateUs { get; set; } = new List<AccountReconcileModelPartnerMapping>();

    public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappingWriteUs { get; set; } = new List<AccountReconcileModelPartnerMapping>();

    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplateCreateUs { get; set; } = new List<AccountReconcileModelTemplate>();

    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplateWriteUs { get; set; } = new List<AccountReconcileModelTemplate>();

    public virtual ICollection<AccountReconcileModel> AccountReconcileModelWriteUs { get; set; } = new List<AccountReconcileModel>();

    public virtual ICollection<AccountReportColumn> AccountReportColumnCreateUs { get; set; } = new List<AccountReportColumn>();

    public virtual ICollection<AccountReportColumn> AccountReportColumnWriteUs { get; set; } = new List<AccountReportColumn>();

    public virtual ICollection<AccountReport> AccountReportCreateUs { get; set; } = new List<AccountReport>();

    public virtual ICollection<AccountReportExpression> AccountReportExpressionCreateUs { get; set; } = new List<AccountReportExpression>();

    public virtual ICollection<AccountReportExpression> AccountReportExpressionWriteUs { get; set; } = new List<AccountReportExpression>();

    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValueCreateUs { get; set; } = new List<AccountReportExternalValue>();

    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValueWriteUs { get; set; } = new List<AccountReportExternalValue>();

    public virtual ICollection<AccountReportLine> AccountReportLineCreateUs { get; set; } = new List<AccountReportLine>();

    public virtual ICollection<AccountReportLine> AccountReportLineWriteUs { get; set; } = new List<AccountReportLine>();

    public virtual ICollection<AccountReport> AccountReportWriteUs { get; set; } = new List<AccountReport>();

    public virtual ICollection<AccountResequenceWizard> AccountResequenceWizardCreateUs { get; set; } = new List<AccountResequenceWizard>();

    public virtual ICollection<AccountResequenceWizard> AccountResequenceWizardWriteUs { get; set; } = new List<AccountResequenceWizard>();

    public virtual ICollection<AccountSetupBankManualConfig> AccountSetupBankManualConfigCreateUs { get; set; } = new List<AccountSetupBankManualConfig>();

    public virtual ICollection<AccountSetupBankManualConfig> AccountSetupBankManualConfigWriteUs { get; set; } = new List<AccountSetupBankManualConfig>();

    public virtual ICollection<AccountTax> AccountTaxCreateUs { get; set; } = new List<AccountTax>();

    public virtual ICollection<AccountTaxGroup> AccountTaxGroupCreateUs { get; set; } = new List<AccountTaxGroup>();

    public virtual ICollection<AccountTaxGroup> AccountTaxGroupWriteUs { get; set; } = new List<AccountTaxGroup>();

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineCreateUs { get; set; } = new List<AccountTaxRepartitionLine>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateCreateUs { get; set; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplateWriteUs { get; set; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineWriteUs { get; set; } = new List<AccountTaxRepartitionLine>();

    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplateCreateUs { get; set; } = new List<AccountTaxTemplate>();

    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplateWriteUs { get; set; } = new List<AccountTaxTemplate>();

    public virtual ICollection<AccountTax> AccountTaxWriteUs { get; set; } = new List<AccountTax>();

    public virtual ICollection<AccountTourUploadBill> AccountTourUploadBillCreateUs { get; set; } = new List<AccountTourUploadBill>();

    public virtual ICollection<AccountTourUploadBillEmailConfirm> AccountTourUploadBillEmailConfirmCreateUs { get; set; } = new List<AccountTourUploadBillEmailConfirm>();

    public virtual ICollection<AccountTourUploadBillEmailConfirm> AccountTourUploadBillEmailConfirmWriteUs { get; set; } = new List<AccountTourUploadBillEmailConfirm>();

    public virtual ICollection<AccountTourUploadBill> AccountTourUploadBillWriteUs { get; set; } = new List<AccountTourUploadBill>();

    public virtual ICollection<AccountUnreconcile> AccountUnreconcileCreateUs { get; set; } = new List<AccountUnreconcile>();

    public virtual ICollection<AccountUnreconcile> AccountUnreconcileWriteUs { get; set; } = new List<AccountUnreconcile>();

    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasonCreateUs { get; set; } = new List<ApplicantGetRefuseReason>();

    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasonWriteUs { get; set; } = new List<ApplicantGetRefuseReason>();

    public virtual ICollection<ApplicantSendMail> ApplicantSendMailCreateUs { get; set; } = new List<ApplicantSendMail>();

    public virtual ICollection<ApplicantSendMail> ApplicantSendMailWriteUs { get; set; } = new List<ApplicantSendMail>();

    public virtual ICollection<AuthTotpDevice> AuthTotpDevices { get; set; } = new List<AuthTotpDevice>();

    public virtual ICollection<AuthTotpWizard> AuthTotpWizardCreateUs { get; set; } = new List<AuthTotpWizard>();

    public virtual ICollection<AuthTotpWizard> AuthTotpWizardUsers { get; set; } = new List<AuthTotpWizard>();

    public virtual ICollection<AuthTotpWizard> AuthTotpWizardWriteUs { get; set; } = new List<AuthTotpWizard>();

    public virtual ICollection<BarcodeNomenclature> BarcodeNomenclatureCreateUs { get; set; } = new List<BarcodeNomenclature>();

    public virtual ICollection<BarcodeNomenclature> BarcodeNomenclatureWriteUs { get; set; } = new List<BarcodeNomenclature>();

    public virtual ICollection<BarcodeRule> BarcodeRuleCreateUs { get; set; } = new List<BarcodeRule>();

    public virtual ICollection<BarcodeRule> BarcodeRuleWriteUs { get; set; } = new List<BarcodeRule>();

    public virtual ICollection<BaseDocumentLayout> BaseDocumentLayoutCreateUs { get; set; } = new List<BaseDocumentLayout>();

    public virtual ICollection<BaseDocumentLayout> BaseDocumentLayoutWriteUs { get; set; } = new List<BaseDocumentLayout>();

    public virtual ICollection<BaseEnableProfilingWizard> BaseEnableProfilingWizardCreateUs { get; set; } = new List<BaseEnableProfilingWizard>();

    public virtual ICollection<BaseEnableProfilingWizard> BaseEnableProfilingWizardWriteUs { get; set; } = new List<BaseEnableProfilingWizard>();

    public virtual ICollection<BaseImportImport> BaseImportImportCreateUs { get; set; } = new List<BaseImportImport>();

    public virtual ICollection<BaseImportImport> BaseImportImportWriteUs { get; set; } = new List<BaseImportImport>();

    public virtual ICollection<BaseImportMapping> BaseImportMappingCreateUs { get; set; } = new List<BaseImportMapping>();

    public virtual ICollection<BaseImportMapping> BaseImportMappingWriteUs { get; set; } = new List<BaseImportMapping>();

    public virtual ICollection<BaseImportTestsModelsChar> BaseImportTestsModelsCharCreateUs { get; set; } = new List<BaseImportTestsModelsChar>();

    public virtual ICollection<BaseImportTestsModelsCharNoreadonly> BaseImportTestsModelsCharNoreadonlyCreateUs { get; set; } = new List<BaseImportTestsModelsCharNoreadonly>();

    public virtual ICollection<BaseImportTestsModelsCharNoreadonly> BaseImportTestsModelsCharNoreadonlyWriteUs { get; set; } = new List<BaseImportTestsModelsCharNoreadonly>();

    public virtual ICollection<BaseImportTestsModelsCharReadonly> BaseImportTestsModelsCharReadonlyCreateUs { get; set; } = new List<BaseImportTestsModelsCharReadonly>();

    public virtual ICollection<BaseImportTestsModelsCharReadonly> BaseImportTestsModelsCharReadonlyWriteUs { get; set; } = new List<BaseImportTestsModelsCharReadonly>();

    public virtual ICollection<BaseImportTestsModelsCharRequired> BaseImportTestsModelsCharRequiredCreateUs { get; set; } = new List<BaseImportTestsModelsCharRequired>();

    public virtual ICollection<BaseImportTestsModelsCharRequired> BaseImportTestsModelsCharRequiredWriteUs { get; set; } = new List<BaseImportTestsModelsCharRequired>();

    public virtual ICollection<BaseImportTestsModelsCharState> BaseImportTestsModelsCharStateCreateUs { get; set; } = new List<BaseImportTestsModelsCharState>();

    public virtual ICollection<BaseImportTestsModelsCharState> BaseImportTestsModelsCharStateWriteUs { get; set; } = new List<BaseImportTestsModelsCharState>();

    public virtual ICollection<BaseImportTestsModelsCharStillreadonly> BaseImportTestsModelsCharStillreadonlyCreateUs { get; set; } = new List<BaseImportTestsModelsCharStillreadonly>();

    public virtual ICollection<BaseImportTestsModelsCharStillreadonly> BaseImportTestsModelsCharStillreadonlyWriteUs { get; set; } = new List<BaseImportTestsModelsCharStillreadonly>();

    public virtual ICollection<BaseImportTestsModelsChar> BaseImportTestsModelsCharWriteUs { get; set; } = new List<BaseImportTestsModelsChar>();

    public virtual ICollection<BaseImportTestsModelsComplex> BaseImportTestsModelsComplexCreateUs { get; set; } = new List<BaseImportTestsModelsComplex>();

    public virtual ICollection<BaseImportTestsModelsComplex> BaseImportTestsModelsComplexWriteUs { get; set; } = new List<BaseImportTestsModelsComplex>();

    public virtual ICollection<BaseImportTestsModelsFloat> BaseImportTestsModelsFloatCreateUs { get; set; } = new List<BaseImportTestsModelsFloat>();

    public virtual ICollection<BaseImportTestsModelsFloat> BaseImportTestsModelsFloatWriteUs { get; set; } = new List<BaseImportTestsModelsFloat>();

    public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2oCreateUs { get; set; } = new List<BaseImportTestsModelsM2o>();

    public virtual ICollection<BaseImportTestsModelsM2oRelated> BaseImportTestsModelsM2oRelatedCreateUs { get; set; } = new List<BaseImportTestsModelsM2oRelated>();

    public virtual ICollection<BaseImportTestsModelsM2oRelated> BaseImportTestsModelsM2oRelatedWriteUs { get; set; } = new List<BaseImportTestsModelsM2oRelated>();

    public virtual ICollection<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequiredCreateUs { get; set; } = new List<BaseImportTestsModelsM2oRequired>();

    public virtual ICollection<BaseImportTestsModelsM2oRequiredRelated> BaseImportTestsModelsM2oRequiredRelatedCreateUs { get; set; } = new List<BaseImportTestsModelsM2oRequiredRelated>();

    public virtual ICollection<BaseImportTestsModelsM2oRequiredRelated> BaseImportTestsModelsM2oRequiredRelatedWriteUs { get; set; } = new List<BaseImportTestsModelsM2oRequiredRelated>();

    public virtual ICollection<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequiredWriteUs { get; set; } = new List<BaseImportTestsModelsM2oRequired>();

    public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2oWriteUs { get; set; } = new List<BaseImportTestsModelsM2o>();

    public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildCreateUs { get; set; } = new List<BaseImportTestsModelsO2mChild>();

    public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildWriteUs { get; set; } = new List<BaseImportTestsModelsO2mChild>();

    public virtual ICollection<BaseImportTestsModelsO2m> BaseImportTestsModelsO2mCreateUs { get; set; } = new List<BaseImportTestsModelsO2m>();

    public virtual ICollection<BaseImportTestsModelsO2m> BaseImportTestsModelsO2mWriteUs { get; set; } = new List<BaseImportTestsModelsO2m>();

    public virtual ICollection<BaseImportTestsModelsPreview> BaseImportTestsModelsPreviewCreateUs { get; set; } = new List<BaseImportTestsModelsPreview>();

    public virtual ICollection<BaseImportTestsModelsPreview> BaseImportTestsModelsPreviewWriteUs { get; set; } = new List<BaseImportTestsModelsPreview>();

    public virtual ICollection<BaseLanguageExport> BaseLanguageExportCreateUs { get; set; } = new List<BaseLanguageExport>();

    public virtual ICollection<BaseLanguageExport> BaseLanguageExportWriteUs { get; set; } = new List<BaseLanguageExport>();

    public virtual ICollection<BaseLanguageImport> BaseLanguageImportCreateUs { get; set; } = new List<BaseLanguageImport>();

    public virtual ICollection<BaseLanguageImport> BaseLanguageImportWriteUs { get; set; } = new List<BaseLanguageImport>();

    public virtual ICollection<BaseLanguageInstall> BaseLanguageInstallCreateUs { get; set; } = new List<BaseLanguageInstall>();

    public virtual ICollection<BaseLanguageInstall> BaseLanguageInstallWriteUs { get; set; } = new List<BaseLanguageInstall>();

    public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequestCreateUs { get; set; } = new List<BaseModuleInstallRequest>();

    public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequestUsers { get; set; } = new List<BaseModuleInstallRequest>();

    public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequestWriteUs { get; set; } = new List<BaseModuleInstallRequest>();

    public virtual ICollection<BaseModuleInstallReview> BaseModuleInstallReviewCreateUs { get; set; } = new List<BaseModuleInstallReview>();

    public virtual ICollection<BaseModuleInstallReview> BaseModuleInstallReviewWriteUs { get; set; } = new List<BaseModuleInstallReview>();

    public virtual ICollection<BaseModuleUninstall> BaseModuleUninstallCreateUs { get; set; } = new List<BaseModuleUninstall>();

    public virtual ICollection<BaseModuleUninstall> BaseModuleUninstallWriteUs { get; set; } = new List<BaseModuleUninstall>();

    public virtual ICollection<BaseModuleUpdate> BaseModuleUpdateCreateUs { get; set; } = new List<BaseModuleUpdate>();

    public virtual ICollection<BaseModuleUpdate> BaseModuleUpdateWriteUs { get; set; } = new List<BaseModuleUpdate>();

    public virtual ICollection<BaseModuleUpgrade> BaseModuleUpgradeCreateUs { get; set; } = new List<BaseModuleUpgrade>();

    public virtual ICollection<BaseModuleUpgrade> BaseModuleUpgradeWriteUs { get; set; } = new List<BaseModuleUpgrade>();

    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizardCreateUs { get; set; } = new List<BasePartnerMergeAutomaticWizard>();

    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizardWriteUs { get; set; } = new List<BasePartnerMergeAutomaticWizard>();

    public virtual ICollection<BasePartnerMergeLine> BasePartnerMergeLineCreateUs { get; set; } = new List<BasePartnerMergeLine>();

    public virtual ICollection<BasePartnerMergeLine> BasePartnerMergeLineWriteUs { get; set; } = new List<BasePartnerMergeLine>();

    public virtual ICollection<BusBu> BusBuCreateUs { get; set; } = new List<BusBu>();

    public virtual ICollection<BusBu> BusBuWriteUs { get; set; } = new List<BusBu>();

    public virtual BusPresence? BusPresence { get; set; }

    public virtual ICollection<CalendarAlarm> CalendarAlarmCreateUs { get; set; } = new List<CalendarAlarm>();

    public virtual ICollection<CalendarAlarm> CalendarAlarmWriteUs { get; set; } = new List<CalendarAlarm>();

    public virtual ICollection<CalendarAttendee> CalendarAttendeeCreateUs { get; set; } = new List<CalendarAttendee>();

    public virtual ICollection<CalendarAttendee> CalendarAttendeeWriteUs { get; set; } = new List<CalendarAttendee>();

    public virtual ICollection<CalendarEvent> CalendarEventCreateUs { get; set; } = new List<CalendarEvent>();

    public virtual ICollection<CalendarEventType> CalendarEventTypeCreateUs { get; set; } = new List<CalendarEventType>();

    public virtual ICollection<CalendarEventType> CalendarEventTypeWriteUs { get; set; } = new List<CalendarEventType>();

    public virtual ICollection<CalendarEvent> CalendarEventUsers { get; set; } = new List<CalendarEvent>();

    public virtual ICollection<CalendarEvent> CalendarEventWriteUs { get; set; } = new List<CalendarEvent>();

    public virtual ICollection<CalendarFilter> CalendarFilterCreateUs { get; set; } = new List<CalendarFilter>();

    public virtual ICollection<CalendarFilter> CalendarFilterUsers { get; set; } = new List<CalendarFilter>();

    public virtual ICollection<CalendarFilter> CalendarFilterWriteUs { get; set; } = new List<CalendarFilter>();

    public virtual ICollection<CalendarProviderConfig> CalendarProviderConfigCreateUs { get; set; } = new List<CalendarProviderConfig>();

    public virtual ICollection<CalendarProviderConfig> CalendarProviderConfigWriteUs { get; set; } = new List<CalendarProviderConfig>();

    public virtual ICollection<CalendarRecurrence> CalendarRecurrenceCreateUs { get; set; } = new List<CalendarRecurrence>();

    public virtual ICollection<CalendarRecurrence> CalendarRecurrenceWriteUs { get; set; } = new List<CalendarRecurrence>();

    public virtual ICollection<ChangePasswordOwn> ChangePasswordOwnCreateUs { get; set; } = new List<ChangePasswordOwn>();

    public virtual ICollection<ChangePasswordOwn> ChangePasswordOwnWriteUs { get; set; } = new List<ChangePasswordOwn>();

    public virtual ICollection<ChangePasswordUser> ChangePasswordUserCreateUs { get; set; } = new List<ChangePasswordUser>();

    public virtual ICollection<ChangePasswordUser> ChangePasswordUserUsers { get; set; } = new List<ChangePasswordUser>();

    public virtual ICollection<ChangePasswordUser> ChangePasswordUserWriteUs { get; set; } = new List<ChangePasswordUser>();

    public virtual ICollection<ChangePasswordWizard> ChangePasswordWizardCreateUs { get; set; } = new List<ChangePasswordWizard>();

    public virtual ICollection<ChangePasswordWizard> ChangePasswordWizardWriteUs { get; set; } = new List<ChangePasswordWizard>();

    public virtual ICollection<ChangeProductionQty> ChangeProductionQtyCreateUs { get; set; } = new List<ChangeProductionQty>();

    public virtual ICollection<ChangeProductionQty> ChangeProductionQtyWriteUs { get; set; } = new List<ChangeProductionQty>();

    public virtual ICollection<ChatbotMessage> ChatbotMessageCreateUs { get; set; } = new List<ChatbotMessage>();

    public virtual ICollection<ChatbotMessage> ChatbotMessageWriteUs { get; set; } = new List<ChatbotMessage>();

    public virtual ICollection<ChatbotScriptAnswer> ChatbotScriptAnswerCreateUs { get; set; } = new List<ChatbotScriptAnswer>();

    public virtual ICollection<ChatbotScriptAnswer> ChatbotScriptAnswerWriteUs { get; set; } = new List<ChatbotScriptAnswer>();

    public virtual ICollection<ChatbotScript> ChatbotScriptCreateUs { get; set; } = new List<ChatbotScript>();

    public virtual ICollection<ChatbotScriptStep> ChatbotScriptStepCreateUs { get; set; } = new List<ChatbotScriptStep>();

    public virtual ICollection<ChatbotScriptStep> ChatbotScriptStepWriteUs { get; set; } = new List<ChatbotScriptStep>();

    public virtual ICollection<ChatbotScript> ChatbotScriptWriteUs { get; set; } = new List<ChatbotScript>();

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ICollection<ConfirmStockSm> ConfirmStockSmCreateUs { get; set; } = new List<ConfirmStockSm>();

    public virtual ICollection<ConfirmStockSm> ConfirmStockSmWriteUs { get; set; } = new List<ConfirmStockSm>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmIapLeadHelper> CrmIapLeadHelperCreateUs { get; set; } = new List<CrmIapLeadHelper>();

    public virtual ICollection<CrmIapLeadHelper> CrmIapLeadHelperWriteUs { get; set; } = new List<CrmIapLeadHelper>();

    public virtual ICollection<CrmIapLeadIndustry> CrmIapLeadIndustryCreateUs { get; set; } = new List<CrmIapLeadIndustry>();

    public virtual ICollection<CrmIapLeadIndustry> CrmIapLeadIndustryWriteUs { get; set; } = new List<CrmIapLeadIndustry>();

    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestCreateUs { get; set; } = new List<CrmIapLeadMiningRequest>();

    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestUsers { get; set; } = new List<CrmIapLeadMiningRequest>();

    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestWriteUs { get; set; } = new List<CrmIapLeadMiningRequest>();

    public virtual ICollection<CrmIapLeadRole> CrmIapLeadRoleCreateUs { get; set; } = new List<CrmIapLeadRole>();

    public virtual ICollection<CrmIapLeadRole> CrmIapLeadRoleWriteUs { get; set; } = new List<CrmIapLeadRole>();

    public virtual ICollection<CrmIapLeadSeniority> CrmIapLeadSeniorityCreateUs { get; set; } = new List<CrmIapLeadSeniority>();

    public virtual ICollection<CrmIapLeadSeniority> CrmIapLeadSeniorityWriteUs { get; set; } = new List<CrmIapLeadSeniority>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnerCreateUs { get; set; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassCreateUs { get; set; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassUsers { get; set; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassWriteUs { get; set; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnerUsers { get; set; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnerWriteUs { get; set; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<CrmLead> CrmLeadCreateUs { get; set; } = new List<CrmLead>();

    public virtual ICollection<CrmLeadLost> CrmLeadLostCreateUs { get; set; } = new List<CrmLeadLost>();

    public virtual ICollection<CrmLeadLost> CrmLeadLostWriteUs { get; set; } = new List<CrmLeadLost>();

    public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdateCreateUs { get; set; } = new List<CrmLeadPlsUpdate>();

    public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdateWriteUs { get; set; } = new List<CrmLeadPlsUpdate>();

    public virtual ICollection<CrmLeadScoringFrequency> CrmLeadScoringFrequencyCreateUs { get; set; } = new List<CrmLeadScoringFrequency>();

    public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFieldCreateUs { get; set; } = new List<CrmLeadScoringFrequencyField>();

    public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFieldWriteUs { get; set; } = new List<CrmLeadScoringFrequencyField>();

    public virtual ICollection<CrmLeadScoringFrequency> CrmLeadScoringFrequencyWriteUs { get; set; } = new List<CrmLeadScoringFrequency>();

    public virtual ICollection<CrmLead> CrmLeadUsers { get; set; } = new List<CrmLead>();

    public virtual ICollection<CrmLead> CrmLeadWriteUs { get; set; } = new List<CrmLead>();

    public virtual ICollection<CrmLostReason> CrmLostReasonCreateUs { get; set; } = new List<CrmLostReason>();

    public virtual ICollection<CrmLostReason> CrmLostReasonWriteUs { get; set; } = new List<CrmLostReason>();

    public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunityCreateUs { get; set; } = new List<CrmMergeOpportunity>();

    public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunityUsers { get; set; } = new List<CrmMergeOpportunity>();

    public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunityWriteUs { get; set; } = new List<CrmMergeOpportunity>();

    public virtual ICollection<CrmQuotationPartner> CrmQuotationPartnerCreateUs { get; set; } = new List<CrmQuotationPartner>();

    public virtual ICollection<CrmQuotationPartner> CrmQuotationPartnerWriteUs { get; set; } = new List<CrmQuotationPartner>();

    public virtual ICollection<CrmRecurringPlan> CrmRecurringPlanCreateUs { get; set; } = new List<CrmRecurringPlan>();

    public virtual ICollection<CrmRecurringPlan> CrmRecurringPlanWriteUs { get; set; } = new List<CrmRecurringPlan>();

    public virtual ICollection<CrmStage> CrmStageCreateUs { get; set; } = new List<CrmStage>();

    public virtual ICollection<CrmStage> CrmStageWriteUs { get; set; } = new List<CrmStage>();

    public virtual ICollection<CrmTag> CrmTagCreateUs { get; set; } = new List<CrmTag>();

    public virtual ICollection<CrmTag> CrmTagWriteUs { get; set; } = new List<CrmTag>();

    public virtual ICollection<CrmTeam> CrmTeamCreateUs { get; set; } = new List<CrmTeam>();

    public virtual ICollection<CrmTeamMember> CrmTeamMemberCreateUs { get; set; } = new List<CrmTeamMember>();

    public virtual ICollection<CrmTeamMember> CrmTeamMemberUsers { get; set; } = new List<CrmTeamMember>();

    public virtual ICollection<CrmTeamMember> CrmTeamMemberWriteUs { get; set; } = new List<CrmTeamMember>();

    public virtual ICollection<CrmTeam> CrmTeamUsers { get; set; } = new List<CrmTeam>();

    public virtual ICollection<CrmTeam> CrmTeamWriteUs { get; set; } = new List<CrmTeam>();

    public virtual ICollection<DataRecycleModel> DataRecycleModelCreateUs { get; set; } = new List<DataRecycleModel>();

    public virtual ICollection<DataRecycleModel> DataRecycleModelWriteUs { get; set; } = new List<DataRecycleModel>();

    public virtual ICollection<DataRecycleRecord> DataRecycleRecordCreateUs { get; set; } = new List<DataRecycleRecord>();

    public virtual ICollection<DataRecycleRecord> DataRecycleRecordWriteUs { get; set; } = new List<DataRecycleRecord>();

    public virtual ICollection<DecimalPrecision> DecimalPrecisionCreateUs { get; set; } = new List<DecimalPrecision>();

    public virtual ICollection<DecimalPrecision> DecimalPrecisionWriteUs { get; set; } = new List<DecimalPrecision>();

    public virtual ICollection<DigestDigest> DigestDigestCreateUs { get; set; } = new List<DigestDigest>();

    public virtual ICollection<DigestDigest> DigestDigestWriteUs { get; set; } = new List<DigestDigest>();

    public virtual ICollection<DigestTip> DigestTipCreateUs { get; set; } = new List<DigestTip>();

    public virtual ICollection<DigestTip> DigestTipWriteUs { get; set; } = new List<DigestTip>();

    public virtual ICollection<EventEventConfigurator> EventEventConfiguratorCreateUs { get; set; } = new List<EventEventConfigurator>();

    public virtual ICollection<EventEventConfigurator> EventEventConfiguratorWriteUs { get; set; } = new List<EventEventConfigurator>();

    public virtual ICollection<EventEvent> EventEventCreateUs { get; set; } = new List<EventEvent>();

    public virtual ICollection<EventEventTicket> EventEventTicketCreateUs { get; set; } = new List<EventEventTicket>();

    public virtual ICollection<EventEventTicket> EventEventTicketWriteUs { get; set; } = new List<EventEventTicket>();

    public virtual ICollection<EventEvent> EventEventUsers { get; set; } = new List<EventEvent>();

    public virtual ICollection<EventEvent> EventEventWriteUs { get; set; } = new List<EventEvent>();

    public virtual ICollection<EventLeadRule> EventLeadRuleCreateUs { get; set; } = new List<EventLeadRule>();

    public virtual ICollection<EventLeadRule> EventLeadRuleLeadUsers { get; set; } = new List<EventLeadRule>();

    public virtual ICollection<EventLeadRule> EventLeadRuleWriteUs { get; set; } = new List<EventLeadRule>();

    public virtual ICollection<EventMail> EventMailCreateUs { get; set; } = new List<EventMail>();

    public virtual ICollection<EventMailRegistration> EventMailRegistrationCreateUs { get; set; } = new List<EventMailRegistration>();

    public virtual ICollection<EventMailRegistration> EventMailRegistrationWriteUs { get; set; } = new List<EventMailRegistration>();

    public virtual ICollection<EventMail> EventMailWriteUs { get; set; } = new List<EventMail>();

    public virtual ICollection<EventRegistration> EventRegistrationCreateUs { get; set; } = new List<EventRegistration>();

    public virtual ICollection<EventRegistration> EventRegistrationWriteUs { get; set; } = new List<EventRegistration>();

    public virtual ICollection<EventStage> EventStageCreateUs { get; set; } = new List<EventStage>();

    public virtual ICollection<EventStage> EventStageWriteUs { get; set; } = new List<EventStage>();

    public virtual ICollection<EventTagCategory> EventTagCategoryCreateUs { get; set; } = new List<EventTagCategory>();

    public virtual ICollection<EventTagCategory> EventTagCategoryWriteUs { get; set; } = new List<EventTagCategory>();

    public virtual ICollection<EventTag> EventTagCreateUs { get; set; } = new List<EventTag>();

    public virtual ICollection<EventTag> EventTagWriteUs { get; set; } = new List<EventTag>();

    public virtual ICollection<EventType> EventTypeCreateUs { get; set; } = new List<EventType>();

    public virtual ICollection<EventTypeMail> EventTypeMailCreateUs { get; set; } = new List<EventTypeMail>();

    public virtual ICollection<EventTypeMail> EventTypeMailWriteUs { get; set; } = new List<EventTypeMail>();

    public virtual ICollection<EventTypeTicket> EventTypeTicketCreateUs { get; set; } = new List<EventTypeTicket>();

    public virtual ICollection<EventTypeTicket> EventTypeTicketWriteUs { get; set; } = new List<EventTypeTicket>();

    public virtual ICollection<EventType> EventTypeWriteUs { get; set; } = new List<EventType>();

    public virtual ICollection<FetchmailServer> FetchmailServerCreateUs { get; set; } = new List<FetchmailServer>();

    public virtual ICollection<FetchmailServer> FetchmailServerWriteUs { get; set; } = new List<FetchmailServer>();

    public virtual ICollection<FleetServiceType> FleetServiceTypeCreateUs { get; set; } = new List<FleetServiceType>();

    public virtual ICollection<FleetServiceType> FleetServiceTypeWriteUs { get; set; } = new List<FleetServiceType>();

    public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogCreateUs { get; set; } = new List<FleetVehicleAssignationLog>();

    public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogWriteUs { get; set; } = new List<FleetVehicleAssignationLog>();

    public virtual ICollection<FleetVehicle> FleetVehicleCreateUs { get; set; } = new List<FleetVehicle>();

    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractCreateUs { get; set; } = new List<FleetVehicleLogContract>();

    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractUsers { get; set; } = new List<FleetVehicleLogContract>();

    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContractWriteUs { get; set; } = new List<FleetVehicleLogContract>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceCreateUs { get; set; } = new List<FleetVehicleLogService>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceManagers { get; set; } = new List<FleetVehicleLogService>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceWriteUs { get; set; } = new List<FleetVehicleLogService>();

    public virtual ICollection<FleetVehicle> FleetVehicleManagers { get; set; } = new List<FleetVehicle>();

    public virtual ICollection<FleetVehicleModelBrand> FleetVehicleModelBrandCreateUs { get; set; } = new List<FleetVehicleModelBrand>();

    public virtual ICollection<FleetVehicleModelBrand> FleetVehicleModelBrandWriteUs { get; set; } = new List<FleetVehicleModelBrand>();

    public virtual ICollection<FleetVehicleModelCategory> FleetVehicleModelCategoryCreateUs { get; set; } = new List<FleetVehicleModelCategory>();

    public virtual ICollection<FleetVehicleModelCategory> FleetVehicleModelCategoryWriteUs { get; set; } = new List<FleetVehicleModelCategory>();

    public virtual ICollection<FleetVehicleModel> FleetVehicleModelCreateUs { get; set; } = new List<FleetVehicleModel>();

    public virtual ICollection<FleetVehicleModel> FleetVehicleModelWriteUs { get; set; } = new List<FleetVehicleModel>();

    public virtual ICollection<FleetVehicleOdometer> FleetVehicleOdometerCreateUs { get; set; } = new List<FleetVehicleOdometer>();

    public virtual ICollection<FleetVehicleOdometer> FleetVehicleOdometerWriteUs { get; set; } = new List<FleetVehicleOdometer>();

    public virtual ICollection<FleetVehicleState> FleetVehicleStateCreateUs { get; set; } = new List<FleetVehicleState>();

    public virtual ICollection<FleetVehicleState> FleetVehicleStateWriteUs { get; set; } = new List<FleetVehicleState>();

    public virtual ICollection<FleetVehicleTag> FleetVehicleTagCreateUs { get; set; } = new List<FleetVehicleTag>();

    public virtual ICollection<FleetVehicleTag> FleetVehicleTagWriteUs { get; set; } = new List<FleetVehicleTag>();

    public virtual ICollection<FleetVehicle> FleetVehicleWriteUs { get; set; } = new List<FleetVehicle>();

    public virtual ICollection<GamificationBadge> GamificationBadgeCreateUs { get; set; } = new List<GamificationBadge>();

    public virtual ICollection<GamificationBadgeUser> GamificationBadgeUserCreateUs { get; set; } = new List<GamificationBadgeUser>();

    public virtual ICollection<GamificationBadgeUser> GamificationBadgeUserSenders { get; set; } = new List<GamificationBadgeUser>();

    public virtual ICollection<GamificationBadgeUser> GamificationBadgeUserUsers { get; set; } = new List<GamificationBadgeUser>();

    public virtual ICollection<GamificationBadgeUserWizard> GamificationBadgeUserWizardCreateUs { get; set; } = new List<GamificationBadgeUserWizard>();

    public virtual ICollection<GamificationBadgeUserWizard> GamificationBadgeUserWizardUsers { get; set; } = new List<GamificationBadgeUserWizard>();

    public virtual ICollection<GamificationBadgeUserWizard> GamificationBadgeUserWizardWriteUs { get; set; } = new List<GamificationBadgeUserWizard>();

    public virtual ICollection<GamificationBadgeUser> GamificationBadgeUserWriteUs { get; set; } = new List<GamificationBadgeUser>();

    public virtual ICollection<GamificationBadge> GamificationBadgeWriteUs { get; set; } = new List<GamificationBadge>();

    public virtual ICollection<GamificationChallenge> GamificationChallengeCreateUs { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<GamificationChallengeLine> GamificationChallengeLineCreateUs { get; set; } = new List<GamificationChallengeLine>();

    public virtual ICollection<GamificationChallengeLine> GamificationChallengeLineWriteUs { get; set; } = new List<GamificationChallengeLine>();

    public virtual ICollection<GamificationChallenge> GamificationChallengeManagers { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<GamificationChallenge> GamificationChallengeWriteUs { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<GamificationGoal> GamificationGoalCreateUs { get; set; } = new List<GamificationGoal>();

    public virtual ICollection<GamificationGoalDefinition> GamificationGoalDefinitionCreateUs { get; set; } = new List<GamificationGoalDefinition>();

    public virtual ICollection<GamificationGoalDefinition> GamificationGoalDefinitionWriteUs { get; set; } = new List<GamificationGoalDefinition>();

    public virtual ICollection<GamificationGoal> GamificationGoalUsers { get; set; } = new List<GamificationGoal>();

    public virtual ICollection<GamificationGoalWizard> GamificationGoalWizardCreateUs { get; set; } = new List<GamificationGoalWizard>();

    public virtual ICollection<GamificationGoalWizard> GamificationGoalWizardWriteUs { get; set; } = new List<GamificationGoalWizard>();

    public virtual ICollection<GamificationGoal> GamificationGoalWriteUs { get; set; } = new List<GamificationGoal>();

    public virtual ICollection<GamificationKarmaRank> GamificationKarmaRankCreateUs { get; set; } = new List<GamificationKarmaRank>();

    public virtual ICollection<GamificationKarmaRank> GamificationKarmaRankWriteUs { get; set; } = new List<GamificationKarmaRank>();

    public virtual ICollection<GamificationKarmaTracking> GamificationKarmaTrackingCreateUs { get; set; } = new List<GamificationKarmaTracking>();

    public virtual ICollection<GamificationKarmaTracking> GamificationKarmaTrackingUsers { get; set; } = new List<GamificationKarmaTracking>();

    public virtual ICollection<GamificationKarmaTracking> GamificationKarmaTrackingWriteUs { get; set; } = new List<GamificationKarmaTracking>();

    public virtual ICollection<HrApplicantCategory> HrApplicantCategoryCreateUs { get; set; } = new List<HrApplicantCategory>();

    public virtual ICollection<HrApplicantCategory> HrApplicantCategoryWriteUs { get; set; } = new List<HrApplicantCategory>();

    public virtual ICollection<HrApplicant> HrApplicantCreateUs { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrApplicantRefuseReason> HrApplicantRefuseReasonCreateUs { get; set; } = new List<HrApplicantRefuseReason>();

    public virtual ICollection<HrApplicantRefuseReason> HrApplicantRefuseReasonWriteUs { get; set; } = new List<HrApplicantRefuseReason>();

    public virtual ICollection<HrApplicantSkill> HrApplicantSkillCreateUs { get; set; } = new List<HrApplicantSkill>();

    public virtual ICollection<HrApplicantSkill> HrApplicantSkillWriteUs { get; set; } = new List<HrApplicantSkill>();

    public virtual ICollection<HrApplicant> HrApplicantUsers { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrApplicant> HrApplicantWriteUs { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrAttendance> HrAttendanceCreateUs { get; set; } = new List<HrAttendance>();

    public virtual ICollection<HrAttendanceOvertime> HrAttendanceOvertimeCreateUs { get; set; } = new List<HrAttendanceOvertime>();

    public virtual ICollection<HrAttendanceOvertime> HrAttendanceOvertimeWriteUs { get; set; } = new List<HrAttendanceOvertime>();

    public virtual ICollection<HrAttendance> HrAttendanceWriteUs { get; set; } = new List<HrAttendance>();

    public virtual ICollection<HrContract> HrContractCreateUs { get; set; } = new List<HrContract>();

    public virtual ICollection<HrContract> HrContractHrResponsibles { get; set; } = new List<HrContract>();

    public virtual ICollection<HrContractType> HrContractTypeCreateUs { get; set; } = new List<HrContractType>();

    public virtual ICollection<HrContractType> HrContractTypeWriteUs { get; set; } = new List<HrContractType>();

    public virtual ICollection<HrContract> HrContractWriteUs { get; set; } = new List<HrContract>();

    public virtual ICollection<HrDepartment> HrDepartmentCreateUs { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrDepartment> HrDepartmentWriteUs { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrDepartureReason> HrDepartureReasonCreateUs { get; set; } = new List<HrDepartureReason>();

    public virtual ICollection<HrDepartureReason> HrDepartureReasonWriteUs { get; set; } = new List<HrDepartureReason>();

    public virtual ICollection<HrDepartureWizard> HrDepartureWizardCreateUs { get; set; } = new List<HrDepartureWizard>();

    public virtual ICollection<HrDepartureWizard> HrDepartureWizardWriteUs { get; set; } = new List<HrDepartureWizard>();

    public virtual ICollection<HrEmployeeCategory> HrEmployeeCategoryCreateUs { get; set; } = new List<HrEmployeeCategory>();

    public virtual ICollection<HrEmployeeCategory> HrEmployeeCategoryWriteUs { get; set; } = new List<HrEmployeeCategory>();

    public virtual ICollection<HrEmployee> HrEmployeeCreateUs { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> HrEmployeeExpenseManagers { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> HrEmployeeLeaveManagers { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployeeSkill> HrEmployeeSkillCreateUs { get; set; } = new List<HrEmployeeSkill>();

    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogCreateUs { get; set; } = new List<HrEmployeeSkillLog>();

    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogWriteUs { get; set; } = new List<HrEmployeeSkillLog>();

    public virtual ICollection<HrEmployeeSkill> HrEmployeeSkillWriteUs { get; set; } = new List<HrEmployeeSkill>();

    public virtual ICollection<HrEmployee> HrEmployeeUsers { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> HrEmployeeWriteUs { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicateCreateUs { get; set; } = new List<HrExpenseApproveDuplicate>();

    public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicateWriteUs { get; set; } = new List<HrExpenseApproveDuplicate>();

    public virtual ICollection<HrExpense> HrExpenseCreateUs { get; set; } = new List<HrExpense>();

    public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizardCreateUs { get; set; } = new List<HrExpenseRefuseWizard>();

    public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizardWriteUs { get; set; } = new List<HrExpenseRefuseWizard>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheetCreateUs { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheetUsers { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheetWriteUs { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplitCreateUs { get; set; } = new List<HrExpenseSplit>();

    public virtual ICollection<HrExpenseSplitWizard> HrExpenseSplitWizardCreateUs { get; set; } = new List<HrExpenseSplitWizard>();

    public virtual ICollection<HrExpenseSplitWizard> HrExpenseSplitWizardWriteUs { get; set; } = new List<HrExpenseSplitWizard>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplitWriteUs { get; set; } = new List<HrExpenseSplit>();

    public virtual ICollection<HrExpense> HrExpenseWriteUs { get; set; } = new List<HrExpense>();

    public virtual ICollection<HrHolidaysCancelLeave> HrHolidaysCancelLeaveCreateUs { get; set; } = new List<HrHolidaysCancelLeave>();

    public virtual ICollection<HrHolidaysCancelLeave> HrHolidaysCancelLeaveWriteUs { get; set; } = new List<HrHolidaysCancelLeave>();

    public virtual ICollection<HrHolidaysSummaryEmployee> HrHolidaysSummaryEmployeeCreateUs { get; set; } = new List<HrHolidaysSummaryEmployee>();

    public virtual ICollection<HrHolidaysSummaryEmployee> HrHolidaysSummaryEmployeeWriteUs { get; set; } = new List<HrHolidaysSummaryEmployee>();

    public virtual ICollection<HrJob> HrJobCreateUs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrJob> HrJobHrResponsibles { get; set; } = new List<HrJob>();

    public virtual ICollection<HrJob> HrJobUsers { get; set; } = new List<HrJob>();

    public virtual ICollection<HrJob> HrJobWriteUs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevelCreateUs { get; set; } = new List<HrLeaveAccrualLevel>();

    public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevelWriteUs { get; set; } = new List<HrLeaveAccrualLevel>();

    public virtual ICollection<HrLeaveAccrualPlan> HrLeaveAccrualPlanCreateUs { get; set; } = new List<HrLeaveAccrualPlan>();

    public virtual ICollection<HrLeaveAccrualPlan> HrLeaveAccrualPlanWriteUs { get; set; } = new List<HrLeaveAccrualPlan>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationCreateUs { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationWriteUs { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaveCreateUs { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDayCreateUs { get; set; } = new List<HrLeaveStressDay>();

    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDayWriteUs { get; set; } = new List<HrLeaveStressDay>();

    public virtual ICollection<HrLeaveType> HrLeaveTypeCreateUs { get; set; } = new List<HrLeaveType>();

    public virtual ICollection<HrLeaveType> HrLeaveTypeResponsibles { get; set; } = new List<HrLeaveType>();

    public virtual ICollection<HrLeaveType> HrLeaveTypeWriteUs { get; set; } = new List<HrLeaveType>();

    public virtual ICollection<HrLeave> HrLeaveUsers { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrLeave> HrLeaveWriteUs { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypeCreateUs { get; set; } = new List<HrPayrollStructureType>();

    public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypeWriteUs { get; set; } = new List<HrPayrollStructureType>();

    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypeCreateUs { get; set; } = new List<HrPlanActivityType>();

    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypeResponsibleNavigations { get; set; } = new List<HrPlanActivityType>();

    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypeWriteUs { get; set; } = new List<HrPlanActivityType>();

    public virtual ICollection<HrPlan> HrPlanCreateUs { get; set; } = new List<HrPlan>();

    public virtual ICollection<HrPlanWizard> HrPlanWizardCreateUs { get; set; } = new List<HrPlanWizard>();

    public virtual ICollection<HrPlanWizard> HrPlanWizardWriteUs { get; set; } = new List<HrPlanWizard>();

    public virtual ICollection<HrPlan> HrPlanWriteUs { get; set; } = new List<HrPlan>();

    public virtual ICollection<HrRecruitmentDegree> HrRecruitmentDegreeCreateUs { get; set; } = new List<HrRecruitmentDegree>();

    public virtual ICollection<HrRecruitmentDegree> HrRecruitmentDegreeWriteUs { get; set; } = new List<HrRecruitmentDegree>();

    public virtual ICollection<HrRecruitmentSource> HrRecruitmentSourceCreateUs { get; set; } = new List<HrRecruitmentSource>();

    public virtual ICollection<HrRecruitmentSource> HrRecruitmentSourceWriteUs { get; set; } = new List<HrRecruitmentSource>();

    public virtual ICollection<HrRecruitmentStage> HrRecruitmentStageCreateUs { get; set; } = new List<HrRecruitmentStage>();

    public virtual ICollection<HrRecruitmentStage> HrRecruitmentStageWriteUs { get; set; } = new List<HrRecruitmentStage>();

    public virtual ICollection<HrResumeLine> HrResumeLineCreateUs { get; set; } = new List<HrResumeLine>();

    public virtual ICollection<HrResumeLineType> HrResumeLineTypeCreateUs { get; set; } = new List<HrResumeLineType>();

    public virtual ICollection<HrResumeLineType> HrResumeLineTypeWriteUs { get; set; } = new List<HrResumeLineType>();

    public virtual ICollection<HrResumeLine> HrResumeLineWriteUs { get; set; } = new List<HrResumeLine>();

    public virtual ICollection<HrSkill> HrSkillCreateUs { get; set; } = new List<HrSkill>();

    public virtual ICollection<HrSkillLevel> HrSkillLevelCreateUs { get; set; } = new List<HrSkillLevel>();

    public virtual ICollection<HrSkillLevel> HrSkillLevelWriteUs { get; set; } = new List<HrSkillLevel>();

    public virtual ICollection<HrSkillType> HrSkillTypeCreateUs { get; set; } = new List<HrSkillType>();

    public virtual ICollection<HrSkillType> HrSkillTypeWriteUs { get; set; } = new List<HrSkillType>();

    public virtual ICollection<HrSkill> HrSkillWriteUs { get; set; } = new List<HrSkill>();

    public virtual ICollection<HrWorkLocation> HrWorkLocationCreateUs { get; set; } = new List<HrWorkLocation>();

    public virtual ICollection<HrWorkLocation> HrWorkLocationWriteUs { get; set; } = new List<HrWorkLocation>();

    public virtual ICollection<IapAccount> IapAccountCreateUs { get; set; } = new List<IapAccount>();

    public virtual ICollection<IapAccount> IapAccountWriteUs { get; set; } = new List<IapAccount>();

    public virtual ICollection<ImLivechatChannel> ImLivechatChannelCreateUs { get; set; } = new List<ImLivechatChannel>();

    public virtual ICollection<ImLivechatChannelRule> ImLivechatChannelRuleCreateUs { get; set; } = new List<ImLivechatChannelRule>();

    public virtual ICollection<ImLivechatChannelRule> ImLivechatChannelRuleWriteUs { get; set; } = new List<ImLivechatChannelRule>();

    public virtual ICollection<ImLivechatChannel> ImLivechatChannelWriteUs { get; set; } = new List<ImLivechatChannel>();

    public virtual ICollection<ResUser> InverseCreateU { get; set; } = new List<ResUser>();

    public virtual ICollection<ResUser> InverseWriteU { get; set; } = new List<ResUser>();

    public virtual ICollection<IrActClient> IrActClientCreateUs { get; set; } = new List<IrActClient>();

    public virtual ICollection<IrActClient> IrActClientWriteUs { get; set; } = new List<IrActClient>();

    public virtual ICollection<IrActReportXml> IrActReportXmlCreateUs { get; set; } = new List<IrActReportXml>();

    public virtual ICollection<IrActReportXml> IrActReportXmlWriteUs { get; set; } = new List<IrActReportXml>();

    public virtual ICollection<IrActServer> IrActServerActivityUsers { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerCreateUs { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerWriteUs { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActUrl> IrActUrlCreateUs { get; set; } = new List<IrActUrl>();

    public virtual ICollection<IrActUrl> IrActUrlWriteUs { get; set; } = new List<IrActUrl>();

    public virtual ICollection<IrActWindow> IrActWindowCreateUs { get; set; } = new List<IrActWindow>();

    public virtual ICollection<IrActWindowView> IrActWindowViewCreateUs { get; set; } = new List<IrActWindowView>();

    public virtual ICollection<IrActWindowView> IrActWindowViewWriteUs { get; set; } = new List<IrActWindowView>();

    public virtual ICollection<IrActWindow> IrActWindowWriteUs { get; set; } = new List<IrActWindow>();

    public virtual ICollection<IrAction> IrActionCreateUs { get; set; } = new List<IrAction>();

    public virtual ICollection<IrAction> IrActionWriteUs { get; set; } = new List<IrAction>();

    public virtual ICollection<IrActionsTodo> IrActionsTodoCreateUs { get; set; } = new List<IrActionsTodo>();

    public virtual ICollection<IrActionsTodo> IrActionsTodoWriteUs { get; set; } = new List<IrActionsTodo>();

    public virtual ICollection<IrAsset> IrAssetCreateUs { get; set; } = new List<IrAsset>();

    public virtual ICollection<IrAsset> IrAssetWriteUs { get; set; } = new List<IrAsset>();

    public virtual ICollection<IrAttachment> IrAttachmentCreateUs { get; set; } = new List<IrAttachment>();

    public virtual ICollection<IrAttachment> IrAttachmentWriteUs { get; set; } = new List<IrAttachment>();

    public virtual ICollection<IrConfigParameter> IrConfigParameterCreateUs { get; set; } = new List<IrConfigParameter>();

    public virtual ICollection<IrConfigParameter> IrConfigParameterWriteUs { get; set; } = new List<IrConfigParameter>();

    public virtual ICollection<IrCron> IrCronCreateUs { get; set; } = new List<IrCron>();

    public virtual ICollection<IrCronTrigger> IrCronTriggerCreateUs { get; set; } = new List<IrCronTrigger>();

    public virtual ICollection<IrCronTrigger> IrCronTriggerWriteUs { get; set; } = new List<IrCronTrigger>();

    public virtual ICollection<IrCron> IrCronUsers { get; set; } = new List<IrCron>();

    public virtual ICollection<IrCron> IrCronWriteUs { get; set; } = new List<IrCron>();

    public virtual ICollection<IrDefault> IrDefaultCreateUs { get; set; } = new List<IrDefault>();

    public virtual ICollection<IrDefault> IrDefaultUsers { get; set; } = new List<IrDefault>();

    public virtual ICollection<IrDefault> IrDefaultWriteUs { get; set; } = new List<IrDefault>();

    public virtual ICollection<IrDemo> IrDemoCreateUs { get; set; } = new List<IrDemo>();

    public virtual ICollection<IrDemoFailure> IrDemoFailureCreateUs { get; set; } = new List<IrDemoFailure>();

    public virtual ICollection<IrDemoFailureWizard> IrDemoFailureWizardCreateUs { get; set; } = new List<IrDemoFailureWizard>();

    public virtual ICollection<IrDemoFailureWizard> IrDemoFailureWizardWriteUs { get; set; } = new List<IrDemoFailureWizard>();

    public virtual ICollection<IrDemoFailure> IrDemoFailureWriteUs { get; set; } = new List<IrDemoFailure>();

    public virtual ICollection<IrDemo> IrDemoWriteUs { get; set; } = new List<IrDemo>();

    public virtual ICollection<IrExport> IrExportCreateUs { get; set; } = new List<IrExport>();

    public virtual ICollection<IrExport> IrExportWriteUs { get; set; } = new List<IrExport>();

    public virtual ICollection<IrExportsLine> IrExportsLineCreateUs { get; set; } = new List<IrExportsLine>();

    public virtual ICollection<IrExportsLine> IrExportsLineWriteUs { get; set; } = new List<IrExportsLine>();

    public virtual ICollection<IrFilter> IrFilterCreateUs { get; set; } = new List<IrFilter>();

    public virtual ICollection<IrFilter> IrFilterUsers { get; set; } = new List<IrFilter>();

    public virtual ICollection<IrFilter> IrFilterWriteUs { get; set; } = new List<IrFilter>();

    public virtual ICollection<IrMailServer> IrMailServerCreateUs { get; set; } = new List<IrMailServer>();

    public virtual ICollection<IrMailServer> IrMailServerWriteUs { get; set; } = new List<IrMailServer>();

    public virtual ICollection<IrModelAccess> IrModelAccessCreateUs { get; set; } = new List<IrModelAccess>();

    public virtual ICollection<IrModelAccess> IrModelAccessWriteUs { get; set; } = new List<IrModelAccess>();

    public virtual ICollection<IrModelConstraint> IrModelConstraintCreateUs { get; set; } = new List<IrModelConstraint>();

    public virtual ICollection<IrModelConstraint> IrModelConstraintWriteUs { get; set; } = new List<IrModelConstraint>();

    public virtual ICollection<IrModel> IrModelCreateUs { get; set; } = new List<IrModel>();

    public virtual ICollection<IrModelDatum> IrModelDatumCreateUs { get; set; } = new List<IrModelDatum>();

    public virtual ICollection<IrModelDatum> IrModelDatumWriteUs { get; set; } = new List<IrModelDatum>();

    public virtual ICollection<IrModelField> IrModelFieldCreateUs { get; set; } = new List<IrModelField>();

    public virtual ICollection<IrModelField> IrModelFieldWriteUs { get; set; } = new List<IrModelField>();

    public virtual ICollection<IrModelFieldsSelection> IrModelFieldsSelectionCreateUs { get; set; } = new List<IrModelFieldsSelection>();

    public virtual ICollection<IrModelFieldsSelection> IrModelFieldsSelectionWriteUs { get; set; } = new List<IrModelFieldsSelection>();

    public virtual ICollection<IrModelRelation> IrModelRelationCreateUs { get; set; } = new List<IrModelRelation>();

    public virtual ICollection<IrModelRelation> IrModelRelationWriteUs { get; set; } = new List<IrModelRelation>();

    public virtual ICollection<IrModel> IrModelWriteUs { get; set; } = new List<IrModel>();

    public virtual ICollection<IrModuleCategory> IrModuleCategoryCreateUs { get; set; } = new List<IrModuleCategory>();

    public virtual ICollection<IrModuleCategory> IrModuleCategoryWriteUs { get; set; } = new List<IrModuleCategory>();

    public virtual ICollection<IrModuleModule> IrModuleModuleCreateUs { get; set; } = new List<IrModuleModule>();

    public virtual ICollection<IrModuleModuleExclusion> IrModuleModuleExclusionCreateUs { get; set; } = new List<IrModuleModuleExclusion>();

    public virtual ICollection<IrModuleModuleExclusion> IrModuleModuleExclusionWriteUs { get; set; } = new List<IrModuleModuleExclusion>();

    public virtual ICollection<IrModuleModule> IrModuleModuleWriteUs { get; set; } = new List<IrModuleModule>();

    public virtual ICollection<IrProperty> IrPropertyCreateUs { get; set; } = new List<IrProperty>();

    public virtual ICollection<IrProperty> IrPropertyWriteUs { get; set; } = new List<IrProperty>();

    public virtual ICollection<IrRule> IrRuleCreateUs { get; set; } = new List<IrRule>();

    public virtual ICollection<IrRule> IrRuleWriteUs { get; set; } = new List<IrRule>();

    public virtual ICollection<IrSequence> IrSequenceCreateUs { get; set; } = new List<IrSequence>();

    public virtual ICollection<IrSequenceDateRange> IrSequenceDateRangeCreateUs { get; set; } = new List<IrSequenceDateRange>();

    public virtual ICollection<IrSequenceDateRange> IrSequenceDateRangeWriteUs { get; set; } = new List<IrSequenceDateRange>();

    public virtual ICollection<IrSequence> IrSequenceWriteUs { get; set; } = new List<IrSequence>();

    public virtual ICollection<IrServerObjectLine> IrServerObjectLineCreateUs { get; set; } = new List<IrServerObjectLine>();

    public virtual ICollection<IrServerObjectLine> IrServerObjectLineWriteUs { get; set; } = new List<IrServerObjectLine>();

    public virtual ICollection<IrUiMenu> IrUiMenuCreateUs { get; set; } = new List<IrUiMenu>();

    public virtual ICollection<IrUiMenu> IrUiMenuWriteUs { get; set; } = new List<IrUiMenu>();

    public virtual ICollection<IrUiView> IrUiViewCreateUs { get; set; } = new List<IrUiView>();

    public virtual ICollection<IrUiViewCustom> IrUiViewCustomCreateUs { get; set; } = new List<IrUiViewCustom>();

    public virtual ICollection<IrUiViewCustom> IrUiViewCustomUsers { get; set; } = new List<IrUiViewCustom>();

    public virtual ICollection<IrUiViewCustom> IrUiViewCustomWriteUs { get; set; } = new List<IrUiViewCustom>();

    public virtual ICollection<IrUiView> IrUiViewWriteUs { get; set; } = new List<IrUiView>();

    public virtual LunchLocation? LastLunchLocation { get; set; }

    public virtual ICollection<LinkTrackerClick> LinkTrackerClickCreateUs { get; set; } = new List<LinkTrackerClick>();

    public virtual ICollection<LinkTrackerClick> LinkTrackerClickWriteUs { get; set; } = new List<LinkTrackerClick>();

    public virtual ICollection<LinkTrackerCode> LinkTrackerCodeCreateUs { get; set; } = new List<LinkTrackerCode>();

    public virtual ICollection<LinkTrackerCode> LinkTrackerCodeWriteUs { get; set; } = new List<LinkTrackerCode>();

    public virtual ICollection<LinkTracker> LinkTrackerCreateUs { get; set; } = new List<LinkTracker>();

    public virtual ICollection<LinkTracker> LinkTrackerWriteUs { get; set; } = new List<LinkTracker>();

    public virtual ICollection<LotLabelLayout> LotLabelLayoutCreateUs { get; set; } = new List<LotLabelLayout>();

    public virtual ICollection<LotLabelLayout> LotLabelLayoutWriteUs { get; set; } = new List<LotLabelLayout>();

    public virtual ICollection<LunchAlert> LunchAlertCreateUs { get; set; } = new List<LunchAlert>();

    public virtual ICollection<LunchAlert> LunchAlertWriteUs { get; set; } = new List<LunchAlert>();

    public virtual ICollection<LunchCashmove> LunchCashmoveCreateUs { get; set; } = new List<LunchCashmove>();

    public virtual ICollection<LunchCashmove> LunchCashmoveUsers { get; set; } = new List<LunchCashmove>();

    public virtual ICollection<LunchCashmove> LunchCashmoveWriteUs { get; set; } = new List<LunchCashmove>();

    public virtual ICollection<LunchLocation> LunchLocationCreateUs { get; set; } = new List<LunchLocation>();

    public virtual ICollection<LunchLocation> LunchLocationWriteUs { get; set; } = new List<LunchLocation>();

    public virtual ICollection<LunchOrder> LunchOrderCreateUs { get; set; } = new List<LunchOrder>();

    public virtual ICollection<LunchOrder> LunchOrderUsers { get; set; } = new List<LunchOrder>();

    public virtual ICollection<LunchOrder> LunchOrderWriteUs { get; set; } = new List<LunchOrder>();

    public virtual ICollection<LunchProductCategory> LunchProductCategoryCreateUs { get; set; } = new List<LunchProductCategory>();

    public virtual ICollection<LunchProductCategory> LunchProductCategoryWriteUs { get; set; } = new List<LunchProductCategory>();

    public virtual ICollection<LunchProduct> LunchProductCreateUs { get; set; } = new List<LunchProduct>();

    public virtual ICollection<LunchProduct> LunchProductWriteUs { get; set; } = new List<LunchProduct>();

    public virtual ICollection<LunchSupplier> LunchSupplierCreateUs { get; set; } = new List<LunchSupplier>();

    public virtual ICollection<LunchSupplier> LunchSupplierResponsibles { get; set; } = new List<LunchSupplier>();

    public virtual ICollection<LunchSupplier> LunchSupplierWriteUs { get; set; } = new List<LunchSupplier>();

    public virtual ICollection<LunchTopping> LunchToppingCreateUs { get; set; } = new List<LunchTopping>();

    public virtual ICollection<LunchTopping> LunchToppingWriteUs { get; set; } = new List<LunchTopping>();

    public virtual ICollection<MailActivity> MailActivityCreateUs { get; set; } = new List<MailActivity>();

    public virtual ICollection<MailActivityType> MailActivityTypeCreateUs { get; set; } = new List<MailActivityType>();

    public virtual ICollection<MailActivityType> MailActivityTypeDefaultUsers { get; set; } = new List<MailActivityType>();

    public virtual ICollection<MailActivityType> MailActivityTypeWriteUs { get; set; } = new List<MailActivityType>();

    public virtual ICollection<MailActivity> MailActivityUsers { get; set; } = new List<MailActivity>();

    public virtual ICollection<MailActivity> MailActivityWriteUs { get; set; } = new List<MailActivity>();

    public virtual ICollection<MailAlias> MailAliasAliasUsers { get; set; } = new List<MailAlias>();

    public virtual ICollection<MailAlias> MailAliasCreateUs { get; set; } = new List<MailAlias>();

    public virtual ICollection<MailAlias> MailAliasWriteUs { get; set; } = new List<MailAlias>();

    public virtual ICollection<MailBlacklist> MailBlacklistCreateUs { get; set; } = new List<MailBlacklist>();

    public virtual ICollection<MailBlacklistRemove> MailBlacklistRemoveCreateUs { get; set; } = new List<MailBlacklistRemove>();

    public virtual ICollection<MailBlacklistRemove> MailBlacklistRemoveWriteUs { get; set; } = new List<MailBlacklistRemove>();

    public virtual ICollection<MailBlacklist> MailBlacklistWriteUs { get; set; } = new List<MailBlacklist>();

    public virtual ICollection<MailChannel> MailChannelCreateUs { get; set; } = new List<MailChannel>();

    public virtual ICollection<MailChannelMember> MailChannelMemberCreateUs { get; set; } = new List<MailChannelMember>();

    public virtual ICollection<MailChannelMember> MailChannelMemberWriteUs { get; set; } = new List<MailChannelMember>();

    public virtual ICollection<MailChannelRtcSession> MailChannelRtcSessionCreateUs { get; set; } = new List<MailChannelRtcSession>();

    public virtual ICollection<MailChannelRtcSession> MailChannelRtcSessionWriteUs { get; set; } = new List<MailChannelRtcSession>();

    public virtual ICollection<MailChannel> MailChannelWriteUs { get; set; } = new List<MailChannel>();

    public virtual ICollection<MailComposeMessage> MailComposeMessageCreateUs { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailComposeMessage> MailComposeMessageWriteUs { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailGatewayAllowed> MailGatewayAllowedCreateUs { get; set; } = new List<MailGatewayAllowed>();

    public virtual ICollection<MailGatewayAllowed> MailGatewayAllowedWriteUs { get; set; } = new List<MailGatewayAllowed>();

    public virtual ICollection<MailGuest> MailGuestCreateUs { get; set; } = new List<MailGuest>();

    public virtual ICollection<MailGuest> MailGuestWriteUs { get; set; } = new List<MailGuest>();

    public virtual ICollection<MailIceServer> MailIceServerCreateUs { get; set; } = new List<MailIceServer>();

    public virtual ICollection<MailIceServer> MailIceServerWriteUs { get; set; } = new List<MailIceServer>();

    public virtual ICollection<MailLinkPreview> MailLinkPreviewCreateUs { get; set; } = new List<MailLinkPreview>();

    public virtual ICollection<MailLinkPreview> MailLinkPreviewWriteUs { get; set; } = new List<MailLinkPreview>();

    public virtual ICollection<MailMail> MailMailCreateUs { get; set; } = new List<MailMail>();

    public virtual ICollection<MailMail> MailMailWriteUs { get; set; } = new List<MailMail>();

    public virtual ICollection<MailMessage> MailMessageCreateUs { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailMessageSchedule> MailMessageScheduleCreateUs { get; set; } = new List<MailMessageSchedule>();

    public virtual ICollection<MailMessageSchedule> MailMessageScheduleWriteUs { get; set; } = new List<MailMessageSchedule>();

    public virtual ICollection<MailMessageSubtype> MailMessageSubtypeCreateUs { get; set; } = new List<MailMessageSubtype>();

    public virtual ICollection<MailMessageSubtype> MailMessageSubtypeWriteUs { get; set; } = new List<MailMessageSubtype>();

    public virtual ICollection<MailMessage> MailMessageWriteUs { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailResendMessage> MailResendMessageCreateUs { get; set; } = new List<MailResendMessage>();

    public virtual ICollection<MailResendMessage> MailResendMessageWriteUs { get; set; } = new List<MailResendMessage>();

    public virtual ICollection<MailResendPartner> MailResendPartnerCreateUs { get; set; } = new List<MailResendPartner>();

    public virtual ICollection<MailResendPartner> MailResendPartnerWriteUs { get; set; } = new List<MailResendPartner>();

    public virtual ICollection<MailShortcode> MailShortcodeCreateUs { get; set; } = new List<MailShortcode>();

    public virtual ICollection<MailShortcode> MailShortcodeWriteUs { get; set; } = new List<MailShortcode>();

    public virtual ICollection<MailTemplate> MailTemplateCreateUs { get; set; } = new List<MailTemplate>();

    public virtual ICollection<MailTemplatePreview> MailTemplatePreviewCreateUs { get; set; } = new List<MailTemplatePreview>();

    public virtual ICollection<MailTemplatePreview> MailTemplatePreviewWriteUs { get; set; } = new List<MailTemplatePreview>();

    public virtual ICollection<MailTemplateReset> MailTemplateResetCreateUs { get; set; } = new List<MailTemplateReset>();

    public virtual ICollection<MailTemplateReset> MailTemplateResetWriteUs { get; set; } = new List<MailTemplateReset>();

    public virtual ICollection<MailTemplate> MailTemplateWriteUs { get; set; } = new List<MailTemplate>();

    public virtual ICollection<MailTrackingValue> MailTrackingValueCreateUs { get; set; } = new List<MailTrackingValue>();

    public virtual ICollection<MailTrackingValue> MailTrackingValueWriteUs { get; set; } = new List<MailTrackingValue>();

    public virtual ICollection<MailWizardInvite> MailWizardInviteCreateUs { get; set; } = new List<MailWizardInvite>();

    public virtual ICollection<MailWizardInvite> MailWizardInviteWriteUs { get; set; } = new List<MailWizardInvite>();

    public virtual ICollection<MailingContact> MailingContactCreateUs { get; set; } = new List<MailingContact>();

    public virtual ICollection<MailingContactImport> MailingContactImportCreateUs { get; set; } = new List<MailingContactImport>();

    public virtual ICollection<MailingContactImport> MailingContactImportWriteUs { get; set; } = new List<MailingContactImport>();

    public virtual ICollection<MailingContactListRel> MailingContactListRelCreateUs { get; set; } = new List<MailingContactListRel>();

    public virtual ICollection<MailingContactListRel> MailingContactListRelWriteUs { get; set; } = new List<MailingContactListRel>();

    public virtual ICollection<MailingContactToList> MailingContactToListCreateUs { get; set; } = new List<MailingContactToList>();

    public virtual ICollection<MailingContactToList> MailingContactToListWriteUs { get; set; } = new List<MailingContactToList>();

    public virtual ICollection<MailingContact> MailingContactWriteUs { get; set; } = new List<MailingContact>();

    public virtual ICollection<MailingFilter> MailingFilterCreateUs { get; set; } = new List<MailingFilter>();

    public virtual ICollection<MailingFilter> MailingFilterWriteUs { get; set; } = new List<MailingFilter>();

    public virtual ICollection<MailingList> MailingListCreateUs { get; set; } = new List<MailingList>();

    public virtual ICollection<MailingListMerge> MailingListMergeCreateUs { get; set; } = new List<MailingListMerge>();

    public virtual ICollection<MailingListMerge> MailingListMergeWriteUs { get; set; } = new List<MailingListMerge>();

    public virtual ICollection<MailingList> MailingListWriteUs { get; set; } = new List<MailingList>();

    public virtual ICollection<MailingMailing> MailingMailingCreateUs { get; set; } = new List<MailingMailing>();

    public virtual ICollection<MailingMailingScheduleDate> MailingMailingScheduleDateCreateUs { get; set; } = new List<MailingMailingScheduleDate>();

    public virtual ICollection<MailingMailingScheduleDate> MailingMailingScheduleDateWriteUs { get; set; } = new List<MailingMailingScheduleDate>();

    public virtual ICollection<MailingMailingTest> MailingMailingTestCreateUs { get; set; } = new List<MailingMailingTest>();

    public virtual ICollection<MailingMailingTest> MailingMailingTestWriteUs { get; set; } = new List<MailingMailingTest>();

    public virtual ICollection<MailingMailing> MailingMailingUsers { get; set; } = new List<MailingMailing>();

    public virtual ICollection<MailingMailing> MailingMailingWriteUs { get; set; } = new List<MailingMailing>();

    public virtual ICollection<MailingSmsTest> MailingSmsTestCreateUs { get; set; } = new List<MailingSmsTest>();

    public virtual ICollection<MailingSmsTest> MailingSmsTestWriteUs { get; set; } = new List<MailingSmsTest>();

    public virtual ICollection<MailingTrace> MailingTraceCreateUs { get; set; } = new List<MailingTrace>();

    public virtual ICollection<MailingTrace> MailingTraceWriteUs { get; set; } = new List<MailingTrace>();

    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategoryCreateUs { get; set; } = new List<MaintenanceEquipmentCategory>();

    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategoryTechnicianUsers { get; set; } = new List<MaintenanceEquipmentCategory>();

    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategoryWriteUs { get; set; } = new List<MaintenanceEquipmentCategory>();

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentCreateUs { get; set; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentOwnerUsers { get; set; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentTechnicianUsers { get; set; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipmentWriteUs { get; set; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequestCreateUs { get; set; } = new List<MaintenanceRequest>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequestOwnerUsers { get; set; } = new List<MaintenanceRequest>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequestUsers { get; set; } = new List<MaintenanceRequest>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequestWriteUs { get; set; } = new List<MaintenanceRequest>();

    public virtual ICollection<MaintenanceStage> MaintenanceStageCreateUs { get; set; } = new List<MaintenanceStage>();

    public virtual ICollection<MaintenanceStage> MaintenanceStageWriteUs { get; set; } = new List<MaintenanceStage>();

    public virtual ICollection<MaintenanceTeam> MaintenanceTeamCreateUs { get; set; } = new List<MaintenanceTeam>();

    public virtual ICollection<MaintenanceTeam> MaintenanceTeamWriteUs { get; set; } = new List<MaintenanceTeam>();

    public virtual ICollection<MrpBomByproduct> MrpBomByproductCreateUs { get; set; } = new List<MrpBomByproduct>();

    public virtual ICollection<MrpBomByproduct> MrpBomByproductWriteUs { get; set; } = new List<MrpBomByproduct>();

    public virtual ICollection<MrpBom> MrpBomCreateUs { get; set; } = new List<MrpBom>();

    public virtual ICollection<MrpBomLine> MrpBomLineCreateUs { get; set; } = new List<MrpBomLine>();

    public virtual ICollection<MrpBomLine> MrpBomLineWriteUs { get; set; } = new List<MrpBomLine>();

    public virtual ICollection<MrpBom> MrpBomWriteUs { get; set; } = new List<MrpBom>();

    public virtual ICollection<MrpConsumptionWarning> MrpConsumptionWarningCreateUs { get; set; } = new List<MrpConsumptionWarning>();

    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLineCreateUs { get; set; } = new List<MrpConsumptionWarningLine>();

    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLineWriteUs { get; set; } = new List<MrpConsumptionWarningLine>();

    public virtual ICollection<MrpConsumptionWarning> MrpConsumptionWarningWriteUs { get; set; } = new List<MrpConsumptionWarning>();

    public virtual ICollection<MrpDocument> MrpDocumentCreateUs { get; set; } = new List<MrpDocument>();

    public virtual ICollection<MrpDocument> MrpDocumentWriteUs { get; set; } = new List<MrpDocument>();

    public virtual ICollection<MrpImmediateProduction> MrpImmediateProductionCreateUs { get; set; } = new List<MrpImmediateProduction>();

    public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLineCreateUs { get; set; } = new List<MrpImmediateProductionLine>();

    public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLineWriteUs { get; set; } = new List<MrpImmediateProductionLine>();

    public virtual ICollection<MrpImmediateProduction> MrpImmediateProductionWriteUs { get; set; } = new List<MrpImmediateProduction>();

    public virtual ICollection<MrpProductionBackorder> MrpProductionBackorderCreateUs { get; set; } = new List<MrpProductionBackorder>();

    public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLineCreateUs { get; set; } = new List<MrpProductionBackorderLine>();

    public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLineWriteUs { get; set; } = new List<MrpProductionBackorderLine>();

    public virtual ICollection<MrpProductionBackorder> MrpProductionBackorderWriteUs { get; set; } = new List<MrpProductionBackorder>();

    public virtual ICollection<MrpProduction> MrpProductionCreateUs { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpProductionSplit> MrpProductionSplitCreateUs { get; set; } = new List<MrpProductionSplit>();

    public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLineCreateUs { get; set; } = new List<MrpProductionSplitLine>();

    public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLineUsers { get; set; } = new List<MrpProductionSplitLine>();

    public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLineWriteUs { get; set; } = new List<MrpProductionSplitLine>();

    public virtual ICollection<MrpProductionSplitMulti> MrpProductionSplitMultiCreateUs { get; set; } = new List<MrpProductionSplitMulti>();

    public virtual ICollection<MrpProductionSplitMulti> MrpProductionSplitMultiWriteUs { get; set; } = new List<MrpProductionSplitMulti>();

    public virtual ICollection<MrpProductionSplit> MrpProductionSplitWriteUs { get; set; } = new List<MrpProductionSplit>();

    public virtual ICollection<MrpProduction> MrpProductionUsers { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpProduction> MrpProductionWriteUs { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenterCreateUs { get; set; } = new List<MrpRoutingWorkcenter>();

    public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenterWriteUs { get; set; } = new List<MrpRoutingWorkcenter>();

    public virtual ICollection<MrpUnbuild> MrpUnbuildCreateUs { get; set; } = new List<MrpUnbuild>();

    public virtual ICollection<MrpUnbuild> MrpUnbuildWriteUs { get; set; } = new List<MrpUnbuild>();

    public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacityCreateUs { get; set; } = new List<MrpWorkcenterCapacity>();

    public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacityWriteUs { get; set; } = new List<MrpWorkcenterCapacity>();

    public virtual ICollection<MrpWorkcenter> MrpWorkcenterCreateUs { get; set; } = new List<MrpWorkcenter>();

    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivityCreateUs { get; set; } = new List<MrpWorkcenterProductivity>();

    public virtual ICollection<MrpWorkcenterProductivityLoss> MrpWorkcenterProductivityLossCreateUs { get; set; } = new List<MrpWorkcenterProductivityLoss>();

    public virtual ICollection<MrpWorkcenterProductivityLossType> MrpWorkcenterProductivityLossTypeCreateUs { get; set; } = new List<MrpWorkcenterProductivityLossType>();

    public virtual ICollection<MrpWorkcenterProductivityLossType> MrpWorkcenterProductivityLossTypeWriteUs { get; set; } = new List<MrpWorkcenterProductivityLossType>();

    public virtual ICollection<MrpWorkcenterProductivityLoss> MrpWorkcenterProductivityLossWriteUs { get; set; } = new List<MrpWorkcenterProductivityLoss>();

    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivityUsers { get; set; } = new List<MrpWorkcenterProductivity>();

    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivityWriteUs { get; set; } = new List<MrpWorkcenterProductivity>();

    public virtual ICollection<MrpWorkcenterTag> MrpWorkcenterTagCreateUs { get; set; } = new List<MrpWorkcenterTag>();

    public virtual ICollection<MrpWorkcenterTag> MrpWorkcenterTagWriteUs { get; set; } = new List<MrpWorkcenterTag>();

    public virtual ICollection<MrpWorkcenter> MrpWorkcenterWriteUs { get; set; } = new List<MrpWorkcenter>();

    public virtual ICollection<MrpWorkorder> MrpWorkorderCreateUs { get; set; } = new List<MrpWorkorder>();

    public virtual ICollection<MrpWorkorder> MrpWorkorderWriteUs { get; set; } = new List<MrpWorkorder>();

    public virtual GamificationKarmaRank? NextRank { get; set; }

    public virtual ICollection<NoteNote> NoteNoteCreateUs { get; set; } = new List<NoteNote>();

    public virtual ICollection<NoteNote> NoteNoteUsers { get; set; } = new List<NoteNote>();

    public virtual ICollection<NoteNote> NoteNoteWriteUs { get; set; } = new List<NoteNote>();

    public virtual ICollection<NoteStage> NoteStageCreateUs { get; set; } = new List<NoteStage>();

    public virtual ICollection<NoteStage> NoteStageUsers { get; set; } = new List<NoteStage>();

    public virtual ICollection<NoteStage> NoteStageWriteUs { get; set; } = new List<NoteStage>();

    public virtual ICollection<NoteTag> NoteTagCreateUs { get; set; } = new List<NoteTag>();

    public virtual ICollection<NoteTag> NoteTagWriteUs { get; set; } = new List<NoteTag>();

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ICollection<PaymentIcon> PaymentIconCreateUs { get; set; } = new List<PaymentIcon>();

    public virtual ICollection<PaymentIcon> PaymentIconWriteUs { get; set; } = new List<PaymentIcon>();

    public virtual ICollection<PaymentLinkWizard> PaymentLinkWizardCreateUs { get; set; } = new List<PaymentLinkWizard>();

    public virtual ICollection<PaymentLinkWizard> PaymentLinkWizardWriteUs { get; set; } = new List<PaymentLinkWizard>();

    public virtual ICollection<PaymentProvider> PaymentProviderCreateUs { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<PaymentProviderOnboardingWizard> PaymentProviderOnboardingWizardCreateUs { get; set; } = new List<PaymentProviderOnboardingWizard>();

    public virtual ICollection<PaymentProviderOnboardingWizard> PaymentProviderOnboardingWizardWriteUs { get; set; } = new List<PaymentProviderOnboardingWizard>();

    public virtual ICollection<PaymentProvider> PaymentProviderWriteUs { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<PaymentRefundWizard> PaymentRefundWizardCreateUs { get; set; } = new List<PaymentRefundWizard>();

    public virtual ICollection<PaymentRefundWizard> PaymentRefundWizardWriteUs { get; set; } = new List<PaymentRefundWizard>();

    public virtual ICollection<PaymentToken> PaymentTokenCreateUs { get; set; } = new List<PaymentToken>();

    public virtual ICollection<PaymentToken> PaymentTokenWriteUs { get; set; } = new List<PaymentToken>();

    public virtual ICollection<PaymentTransaction> PaymentTransactionCreateUs { get; set; } = new List<PaymentTransaction>();

    public virtual ICollection<PaymentTransaction> PaymentTransactionWriteUs { get; set; } = new List<PaymentTransaction>();

    public virtual ICollection<PhoneBlacklist> PhoneBlacklistCreateUs { get; set; } = new List<PhoneBlacklist>();

    public virtual ICollection<PhoneBlacklistRemove> PhoneBlacklistRemoveCreateUs { get; set; } = new List<PhoneBlacklistRemove>();

    public virtual ICollection<PhoneBlacklistRemove> PhoneBlacklistRemoveWriteUs { get; set; } = new List<PhoneBlacklistRemove>();

    public virtual ICollection<PhoneBlacklist> PhoneBlacklistWriteUs { get; set; } = new List<PhoneBlacklist>();

    public virtual ICollection<PickingLabelType> PickingLabelTypeCreateUs { get; set; } = new List<PickingLabelType>();

    public virtual ICollection<PickingLabelType> PickingLabelTypeWriteUs { get; set; } = new List<PickingLabelType>();

    public virtual ICollection<PortalShare> PortalShareCreateUs { get; set; } = new List<PortalShare>();

    public virtual ICollection<PortalShare> PortalShareWriteUs { get; set; } = new List<PortalShare>();

    public virtual ICollection<PortalWizard> PortalWizardCreateUs { get; set; } = new List<PortalWizard>();

    public virtual ICollection<PortalWizardUser> PortalWizardUserCreateUs { get; set; } = new List<PortalWizardUser>();

    public virtual ICollection<PortalWizardUser> PortalWizardUserWriteUs { get; set; } = new List<PortalWizardUser>();

    public virtual ICollection<PortalWizard> PortalWizardWriteUs { get; set; } = new List<PortalWizard>();

    public virtual ICollection<PosBill> PosBillCreateUs { get; set; } = new List<PosBill>();

    public virtual ICollection<PosBill> PosBillWriteUs { get; set; } = new List<PosBill>();

    public virtual ICollection<PosCategory> PosCategoryCreateUs { get; set; } = new List<PosCategory>();

    public virtual ICollection<PosCategory> PosCategoryWriteUs { get; set; } = new List<PosCategory>();

    public virtual ICollection<PosCloseSessionWizard> PosCloseSessionWizardCreateUs { get; set; } = new List<PosCloseSessionWizard>();

    public virtual ICollection<PosCloseSessionWizard> PosCloseSessionWizardWriteUs { get; set; } = new List<PosCloseSessionWizard>();

    public virtual ICollection<PosConfig> PosConfigCreateUs { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosConfig> PosConfigWriteUs { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosDetailsWizard> PosDetailsWizardCreateUs { get; set; } = new List<PosDetailsWizard>();

    public virtual ICollection<PosDetailsWizard> PosDetailsWizardWriteUs { get; set; } = new List<PosDetailsWizard>();

    public virtual ICollection<PosMakePayment> PosMakePaymentCreateUs { get; set; } = new List<PosMakePayment>();

    public virtual ICollection<PosMakePayment> PosMakePaymentWriteUs { get; set; } = new List<PosMakePayment>();

    public virtual ICollection<PosOrder> PosOrderCreateUs { get; set; } = new List<PosOrder>();

    public virtual ICollection<PosOrderLine> PosOrderLineCreateUs { get; set; } = new List<PosOrderLine>();

    public virtual ICollection<PosOrderLine> PosOrderLineWriteUs { get; set; } = new List<PosOrderLine>();

    public virtual ICollection<PosOrder> PosOrderUsers { get; set; } = new List<PosOrder>();

    public virtual ICollection<PosOrder> PosOrderWriteUs { get; set; } = new List<PosOrder>();

    public virtual ICollection<PosPackOperationLot> PosPackOperationLotCreateUs { get; set; } = new List<PosPackOperationLot>();

    public virtual ICollection<PosPackOperationLot> PosPackOperationLotWriteUs { get; set; } = new List<PosPackOperationLot>();

    public virtual ICollection<PosPayment> PosPaymentCreateUs { get; set; } = new List<PosPayment>();

    public virtual ICollection<PosPaymentMethod> PosPaymentMethodCreateUs { get; set; } = new List<PosPaymentMethod>();

    public virtual ICollection<PosPaymentMethod> PosPaymentMethodWriteUs { get; set; } = new List<PosPaymentMethod>();

    public virtual ICollection<PosPayment> PosPaymentWriteUs { get; set; } = new List<PosPayment>();

    public virtual ICollection<PosSessionCheckProductWizard> PosSessionCheckProductWizardCreateUs { get; set; } = new List<PosSessionCheckProductWizard>();

    public virtual ICollection<PosSessionCheckProductWizard> PosSessionCheckProductWizardWriteUs { get; set; } = new List<PosSessionCheckProductWizard>();

    public virtual ICollection<PosSession> PosSessionCreateUs { get; set; } = new List<PosSession>();

    public virtual ICollection<PosSession> PosSessionUsers { get; set; } = new List<PosSession>();

    public virtual ICollection<PosSession> PosSessionWriteUs { get; set; } = new List<PosSession>();

    public virtual ICollection<PrivacyLog> PrivacyLogCreateUs { get; set; } = new List<PrivacyLog>();

    public virtual ICollection<PrivacyLog> PrivacyLogUsers { get; set; } = new List<PrivacyLog>();

    public virtual ICollection<PrivacyLog> PrivacyLogWriteUs { get; set; } = new List<PrivacyLog>();

    public virtual ICollection<PrivacyLookupWizard> PrivacyLookupWizardCreateUs { get; set; } = new List<PrivacyLookupWizard>();

    public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLineCreateUs { get; set; } = new List<PrivacyLookupWizardLine>();

    public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLineWriteUs { get; set; } = new List<PrivacyLookupWizardLine>();

    public virtual ICollection<PrivacyLookupWizard> PrivacyLookupWizardWriteUs { get; set; } = new List<PrivacyLookupWizard>();

    public virtual ICollection<ProcurementGroup> ProcurementGroupCreateUs { get; set; } = new List<ProcurementGroup>();

    public virtual ICollection<ProcurementGroup> ProcurementGroupWriteUs { get; set; } = new List<ProcurementGroup>();

    public virtual ICollection<ProductAttribute> ProductAttributeCreateUs { get; set; } = new List<ProductAttribute>();

    public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValueCreateUs { get; set; } = new List<ProductAttributeCustomValue>();

    public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValueWriteUs { get; set; } = new List<ProductAttributeCustomValue>();

    public virtual ICollection<ProductAttributeValue> ProductAttributeValueCreateUs { get; set; } = new List<ProductAttributeValue>();

    public virtual ICollection<ProductAttributeValue> ProductAttributeValueWriteUs { get; set; } = new List<ProductAttributeValue>();

    public virtual ICollection<ProductAttribute> ProductAttributeWriteUs { get; set; } = new List<ProductAttribute>();

    public virtual ICollection<ProductCategory> ProductCategoryCreateUs { get; set; } = new List<ProductCategory>();

    public virtual ICollection<ProductCategory> ProductCategoryWriteUs { get; set; } = new List<ProductCategory>();

    public virtual ICollection<ProductImage> ProductImageCreateUs { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductImage> ProductImageWriteUs { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductLabelLayout> ProductLabelLayoutCreateUs { get; set; } = new List<ProductLabelLayout>();

    public virtual ICollection<ProductLabelLayout> ProductLabelLayoutWriteUs { get; set; } = new List<ProductLabelLayout>();

    public virtual ICollection<ProductPackaging> ProductPackagingCreateUs { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<ProductPackaging> ProductPackagingWriteUs { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<ProductPricelist> ProductPricelistCreateUs { get; set; } = new List<ProductPricelist>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItemCreateUs { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItemWriteUs { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelist> ProductPricelistWriteUs { get; set; } = new List<ProductPricelist>();

    public virtual ICollection<ProductProduct> ProductProductCreateUs { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductProduct> ProductProductWriteUs { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductPublicCategory> ProductPublicCategoryCreateUs { get; set; } = new List<ProductPublicCategory>();

    public virtual ICollection<ProductPublicCategory> ProductPublicCategoryWriteUs { get; set; } = new List<ProductPublicCategory>();

    public virtual ICollection<ProductRemoval> ProductRemovalCreateUs { get; set; } = new List<ProductRemoval>();

    public virtual ICollection<ProductRemoval> ProductRemovalWriteUs { get; set; } = new List<ProductRemoval>();

    public virtual ICollection<ProductReplenish> ProductReplenishCreateUs { get; set; } = new List<ProductReplenish>();

    public virtual ICollection<ProductReplenish> ProductReplenishWriteUs { get; set; } = new List<ProductReplenish>();

    public virtual ICollection<ProductRibbon> ProductRibbonCreateUs { get; set; } = new List<ProductRibbon>();

    public virtual ICollection<ProductRibbon> ProductRibbonWriteUs { get; set; } = new List<ProductRibbon>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfoCreateUs { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfoWriteUs { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<ProductTag> ProductTagCreateUs { get; set; } = new List<ProductTag>();

    public virtual ICollection<ProductTag> ProductTagWriteUs { get; set; } = new List<ProductTag>();

    public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusionCreateUs { get; set; } = new List<ProductTemplateAttributeExclusion>();

    public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusionWriteUs { get; set; } = new List<ProductTemplateAttributeExclusion>();

    public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLineCreateUs { get; set; } = new List<ProductTemplateAttributeLine>();

    public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLineWriteUs { get; set; } = new List<ProductTemplateAttributeLine>();

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValueCreateUs { get; set; } = new List<ProductTemplateAttributeValue>();

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValueWriteUs { get; set; } = new List<ProductTemplateAttributeValue>();

    public virtual ICollection<ProductTemplate> ProductTemplateCreateUs { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> ProductTemplateWriteUs { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProjectCollaborator> ProjectCollaboratorCreateUs { get; set; } = new List<ProjectCollaborator>();

    public virtual ICollection<ProjectCollaborator> ProjectCollaboratorWriteUs { get; set; } = new List<ProjectCollaborator>();

    public virtual ICollection<ProjectMilestone> ProjectMilestoneCreateUs { get; set; } = new List<ProjectMilestone>();

    public virtual ICollection<ProjectMilestone> ProjectMilestoneWriteUs { get; set; } = new List<ProjectMilestone>();

    public virtual ICollection<ProjectProject> ProjectProjectCreateUs { get; set; } = new List<ProjectProject>();

    public virtual ICollection<ProjectProjectStage> ProjectProjectStageCreateUs { get; set; } = new List<ProjectProjectStage>();

    public virtual ICollection<ProjectProjectStage> ProjectProjectStageWriteUs { get; set; } = new List<ProjectProjectStage>();

    public virtual ICollection<ProjectProject> ProjectProjectUsers { get; set; } = new List<ProjectProject>();

    public virtual ICollection<ProjectProject> ProjectProjectWriteUs { get; set; } = new List<ProjectProject>();

    public virtual ICollection<ProjectShareWizard> ProjectShareWizardCreateUs { get; set; } = new List<ProjectShareWizard>();

    public virtual ICollection<ProjectShareWizard> ProjectShareWizardWriteUs { get; set; } = new List<ProjectShareWizard>();

    public virtual ICollection<ProjectTag> ProjectTagCreateUs { get; set; } = new List<ProjectTag>();

    public virtual ICollection<ProjectTag> ProjectTagWriteUs { get; set; } = new List<ProjectTag>();

    public virtual ICollection<ProjectTask> ProjectTaskCreateUs { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTaskRecurrence> ProjectTaskRecurrenceCreateUs { get; set; } = new List<ProjectTaskRecurrence>();

    public virtual ICollection<ProjectTaskRecurrence> ProjectTaskRecurrenceWriteUs { get; set; } = new List<ProjectTaskRecurrence>();

    public virtual ICollection<ProjectTaskType> ProjectTaskTypeCreateUs { get; set; } = new List<ProjectTaskType>();

    public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizardCreateUs { get; set; } = new List<ProjectTaskTypeDeleteWizard>();

    public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizardWriteUs { get; set; } = new List<ProjectTaskTypeDeleteWizard>();

    public virtual ICollection<ProjectTaskType> ProjectTaskTypeUsers { get; set; } = new List<ProjectTaskType>();

    public virtual ICollection<ProjectTaskType> ProjectTaskTypeWriteUs { get; set; } = new List<ProjectTaskType>();

    public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRelCreateUs { get; set; } = new List<ProjectTaskUserRel>();

    public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRelUsers { get; set; } = new List<ProjectTaskUserRel>();

    public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRelWriteUs { get; set; } = new List<ProjectTaskUserRel>();

    public virtual ICollection<ProjectTask> ProjectTaskWriteUs { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectUpdate> ProjectUpdateCreateUs { get; set; } = new List<ProjectUpdate>();

    public virtual ICollection<ProjectUpdate> ProjectUpdateUsers { get; set; } = new List<ProjectUpdate>();

    public virtual ICollection<ProjectUpdate> ProjectUpdateWriteUs { get; set; } = new List<ProjectUpdate>();

    public virtual ICollection<PurchaseOrder> PurchaseOrderCreateUs { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLineCreateUs { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLineWriteUs { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<PurchaseOrder> PurchaseOrderUsers { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<PurchaseOrder> PurchaseOrderWriteUs { get; set; } = new List<PurchaseOrder>();

    public virtual GamificationKarmaRank? Rank { get; set; }

    public virtual ICollection<RatingRating> RatingRatingCreateUs { get; set; } = new List<RatingRating>();

    public virtual ICollection<RatingRating> RatingRatingWriteUs { get; set; } = new List<RatingRating>();

    public virtual ICollection<RegistrationEditor> RegistrationEditorCreateUs { get; set; } = new List<RegistrationEditor>();

    public virtual ICollection<RegistrationEditorLine> RegistrationEditorLineCreateUs { get; set; } = new List<RegistrationEditorLine>();

    public virtual ICollection<RegistrationEditorLine> RegistrationEditorLineWriteUs { get; set; } = new List<RegistrationEditorLine>();

    public virtual ICollection<RegistrationEditor> RegistrationEditorWriteUs { get; set; } = new List<RegistrationEditor>();

    public virtual ICollection<RepairFee> RepairFeeCreateUs { get; set; } = new List<RepairFee>();

    public virtual ICollection<RepairFee> RepairFeeWriteUs { get; set; } = new List<RepairFee>();

    public virtual ICollection<RepairLine> RepairLineCreateUs { get; set; } = new List<RepairLine>();

    public virtual ICollection<RepairLine> RepairLineWriteUs { get; set; } = new List<RepairLine>();

    public virtual ICollection<RepairOrder> RepairOrderCreateUs { get; set; } = new List<RepairOrder>();

    public virtual ICollection<RepairOrderMakeInvoice> RepairOrderMakeInvoiceCreateUs { get; set; } = new List<RepairOrderMakeInvoice>();

    public virtual ICollection<RepairOrderMakeInvoice> RepairOrderMakeInvoiceWriteUs { get; set; } = new List<RepairOrderMakeInvoice>();

    public virtual ICollection<RepairOrder> RepairOrderUsers { get; set; } = new List<RepairOrder>();

    public virtual ICollection<RepairOrder> RepairOrderWriteUs { get; set; } = new List<RepairOrder>();

    public virtual ICollection<RepairTag> RepairTagCreateUs { get; set; } = new List<RepairTag>();

    public virtual ICollection<RepairTag> RepairTagWriteUs { get; set; } = new List<RepairTag>();

    public virtual ICollection<ReportLayout> ReportLayoutCreateUs { get; set; } = new List<ReportLayout>();

    public virtual ICollection<ReportLayout> ReportLayoutWriteUs { get; set; } = new List<ReportLayout>();

    public virtual ICollection<ReportPaperformat> ReportPaperformatCreateUs { get; set; } = new List<ReportPaperformat>();

    public virtual ICollection<ReportPaperformat> ReportPaperformatWriteUs { get; set; } = new List<ReportPaperformat>();

    public virtual ICollection<ResBank> ResBankCreateUs { get; set; } = new List<ResBank>();

    public virtual ICollection<ResBank> ResBankWriteUs { get; set; } = new List<ResBank>();

    public virtual ICollection<ResCompany> ResCompanyCreateUs { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyWriteUs { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResConfig> ResConfigCreateUs { get; set; } = new List<ResConfig>();

    public virtual ICollection<ResConfigInstaller> ResConfigInstallerCreateUs { get; set; } = new List<ResConfigInstaller>();

    public virtual ICollection<ResConfigInstaller> ResConfigInstallerWriteUs { get; set; } = new List<ResConfigInstaller>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingAuthSignupTemplateUsers { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingCreateUs { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingWriteUs { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResConfig> ResConfigWriteUs { get; set; } = new List<ResConfig>();

    public virtual ICollection<ResCountry> ResCountryCreateUs { get; set; } = new List<ResCountry>();

    public virtual ICollection<ResCountryGroup> ResCountryGroupCreateUs { get; set; } = new List<ResCountryGroup>();

    public virtual ICollection<ResCountryGroup> ResCountryGroupWriteUs { get; set; } = new List<ResCountryGroup>();

    public virtual ICollection<ResCountryState> ResCountryStateCreateUs { get; set; } = new List<ResCountryState>();

    public virtual ICollection<ResCountryState> ResCountryStateWriteUs { get; set; } = new List<ResCountryState>();

    public virtual ICollection<ResCountry> ResCountryWriteUs { get; set; } = new List<ResCountry>();

    public virtual ICollection<ResCurrency> ResCurrencyCreateUs { get; set; } = new List<ResCurrency>();

    public virtual ICollection<ResCurrencyRate> ResCurrencyRateCreateUs { get; set; } = new List<ResCurrencyRate>();

    public virtual ICollection<ResCurrencyRate> ResCurrencyRateWriteUs { get; set; } = new List<ResCurrencyRate>();

    public virtual ICollection<ResCurrency> ResCurrencyWriteUs { get; set; } = new List<ResCurrency>();

    public virtual ICollection<ResGroup> ResGroupCreateUs { get; set; } = new List<ResGroup>();

    public virtual ICollection<ResGroup> ResGroupWriteUs { get; set; } = new List<ResGroup>();

    public virtual ICollection<ResLang> ResLangCreateUs { get; set; } = new List<ResLang>();

    public virtual ICollection<ResLang> ResLangWriteUs { get; set; } = new List<ResLang>();

    public virtual ICollection<ResPartnerAutocompleteSync> ResPartnerAutocompleteSyncCreateUs { get; set; } = new List<ResPartnerAutocompleteSync>();

    public virtual ICollection<ResPartnerAutocompleteSync> ResPartnerAutocompleteSyncWriteUs { get; set; } = new List<ResPartnerAutocompleteSync>();

    public virtual ICollection<ResPartnerBank> ResPartnerBankCreateUs { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResPartnerBank> ResPartnerBankWriteUs { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResPartnerCategory> ResPartnerCategoryCreateUs { get; set; } = new List<ResPartnerCategory>();

    public virtual ICollection<ResPartnerCategory> ResPartnerCategoryWriteUs { get; set; } = new List<ResPartnerCategory>();

    public virtual ICollection<ResPartner> ResPartnerCreateUs { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResPartnerIndustry> ResPartnerIndustryCreateUs { get; set; } = new List<ResPartnerIndustry>();

    public virtual ICollection<ResPartnerIndustry> ResPartnerIndustryWriteUs { get; set; } = new List<ResPartnerIndustry>();

    public virtual ICollection<ResPartnerTitle> ResPartnerTitleCreateUs { get; set; } = new List<ResPartnerTitle>();

    public virtual ICollection<ResPartnerTitle> ResPartnerTitleWriteUs { get; set; } = new List<ResPartnerTitle>();

    public virtual ICollection<ResPartner> ResPartnerUsers { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResPartner> ResPartnerWriteUs { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResUsersApikey> ResUsersApikeys { get; set; } = new List<ResUsersApikey>();

    public virtual ICollection<ResUsersApikeysDescription> ResUsersApikeysDescriptionCreateUs { get; set; } = new List<ResUsersApikeysDescription>();

    public virtual ICollection<ResUsersApikeysDescription> ResUsersApikeysDescriptionWriteUs { get; set; } = new List<ResUsersApikeysDescription>();

    public virtual ICollection<ResUsersDeletion> ResUsersDeletionCreateUs { get; set; } = new List<ResUsersDeletion>();

    public virtual ICollection<ResUsersDeletion> ResUsersDeletionUsers { get; set; } = new List<ResUsersDeletion>();

    public virtual ICollection<ResUsersDeletion> ResUsersDeletionWriteUs { get; set; } = new List<ResUsersDeletion>();

    public virtual ICollection<ResUsersIdentitycheck> ResUsersIdentitycheckCreateUs { get; set; } = new List<ResUsersIdentitycheck>();

    public virtual ICollection<ResUsersIdentitycheck> ResUsersIdentitycheckWriteUs { get; set; } = new List<ResUsersIdentitycheck>();

    public virtual ICollection<ResUsersLog> ResUsersLogCreateUs { get; set; } = new List<ResUsersLog>();

    public virtual ICollection<ResUsersLog> ResUsersLogWriteUs { get; set; } = new List<ResUsersLog>();

    public virtual ICollection<ResUsersSetting> ResUsersSettingCreateUs { get; set; } = new List<ResUsersSetting>();

    public virtual ResUsersSetting? ResUsersSettingUser { get; set; }

    public virtual ICollection<ResUsersSetting> ResUsersSettingWriteUs { get; set; } = new List<ResUsersSetting>();

    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumeCreateUs { get; set; } = new List<ResUsersSettingsVolume>();

    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumeWriteUs { get; set; } = new List<ResUsersSettingsVolume>();

    public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardCreateUs { get; set; } = new List<ResetViewArchWizard>();

    public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardWriteUs { get; set; } = new List<ResetViewArchWizard>();

    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendanceCreateUs { get; set; } = new List<ResourceCalendarAttendance>();

    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendanceWriteUs { get; set; } = new List<ResourceCalendarAttendance>();

    public virtual ICollection<ResourceCalendar> ResourceCalendarCreateUs { get; set; } = new List<ResourceCalendar>();

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeafCreateUs { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeafWriteUs { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ICollection<ResourceCalendar> ResourceCalendarWriteUs { get; set; } = new List<ResourceCalendar>();

    public virtual ICollection<ResourceResource> ResourceResourceCreateUs { get; set; } = new List<ResourceResource>();

    public virtual ICollection<ResourceResource> ResourceResourceUsers { get; set; } = new List<ResourceResource>();

    public virtual ICollection<ResourceResource> ResourceResourceWriteUs { get; set; } = new List<ResourceResource>();

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvCreateUs { get; set; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvWriteUs { get; set; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<SaleOrderCancel> SaleOrderCancelCreateUs { get; set; } = new List<SaleOrderCancel>();

    public virtual ICollection<SaleOrderCancel> SaleOrderCancelWriteUs { get; set; } = new List<SaleOrderCancel>();

    public virtual ICollection<SaleOrder> SaleOrderCreateUs { get; set; } = new List<SaleOrder>();

    public virtual ICollection<SaleOrderLine> SaleOrderLineCreateUs { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrderLine> SaleOrderLineSalesmen { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrderLine> SaleOrderLineWriteUs { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrderOption> SaleOrderOptionCreateUs { get; set; } = new List<SaleOrderOption>();

    public virtual ICollection<SaleOrderOption> SaleOrderOptionWriteUs { get; set; } = new List<SaleOrderOption>();

    public virtual ICollection<SaleOrderTemplate> SaleOrderTemplateCreateUs { get; set; } = new List<SaleOrderTemplate>();

    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLineCreateUs { get; set; } = new List<SaleOrderTemplateLine>();

    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLineWriteUs { get; set; } = new List<SaleOrderTemplateLine>();

    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptionCreateUs { get; set; } = new List<SaleOrderTemplateOption>();

    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptionWriteUs { get; set; } = new List<SaleOrderTemplateOption>();

    public virtual ICollection<SaleOrderTemplate> SaleOrderTemplateWriteUs { get; set; } = new List<SaleOrderTemplate>();

    public virtual ICollection<SaleOrder> SaleOrderUsers { get; set; } = new List<SaleOrder>();

    public virtual ICollection<SaleOrder> SaleOrderWriteUs { get; set; } = new List<SaleOrder>();

    public virtual ICollection<SalePaymentProviderOnboardingWizard> SalePaymentProviderOnboardingWizardCreateUs { get; set; } = new List<SalePaymentProviderOnboardingWizard>();

    public virtual ICollection<SalePaymentProviderOnboardingWizard> SalePaymentProviderOnboardingWizardWriteUs { get; set; } = new List<SalePaymentProviderOnboardingWizard>();

    public virtual CrmTeam? SaleTeam { get; set; }

    public virtual ICollection<SlideAnswer> SlideAnswerCreateUs { get; set; } = new List<SlideAnswer>();

    public virtual ICollection<SlideAnswer> SlideAnswerWriteUs { get; set; } = new List<SlideAnswer>();

    public virtual ICollection<SlideChannel> SlideChannelCreateUs { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SlideChannelInvite> SlideChannelInviteCreateUs { get; set; } = new List<SlideChannelInvite>();

    public virtual ICollection<SlideChannelInvite> SlideChannelInviteWriteUs { get; set; } = new List<SlideChannelInvite>();

    public virtual ICollection<SlideChannelPartner> SlideChannelPartnerCreateUs { get; set; } = new List<SlideChannelPartner>();

    public virtual ICollection<SlideChannelPartner> SlideChannelPartnerWriteUs { get; set; } = new List<SlideChannelPartner>();

    public virtual ICollection<SlideChannelTag> SlideChannelTagCreateUs { get; set; } = new List<SlideChannelTag>();

    public virtual ICollection<SlideChannelTagGroup> SlideChannelTagGroupCreateUs { get; set; } = new List<SlideChannelTagGroup>();

    public virtual ICollection<SlideChannelTagGroup> SlideChannelTagGroupWriteUs { get; set; } = new List<SlideChannelTagGroup>();

    public virtual ICollection<SlideChannelTag> SlideChannelTagWriteUs { get; set; } = new List<SlideChannelTag>();

    public virtual ICollection<SlideChannel> SlideChannelUsers { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SlideChannel> SlideChannelWriteUs { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SlideEmbed> SlideEmbedCreateUs { get; set; } = new List<SlideEmbed>();

    public virtual ICollection<SlideEmbed> SlideEmbedWriteUs { get; set; } = new List<SlideEmbed>();

    public virtual ICollection<SlideQuestion> SlideQuestionCreateUs { get; set; } = new List<SlideQuestion>();

    public virtual ICollection<SlideQuestion> SlideQuestionWriteUs { get; set; } = new List<SlideQuestion>();

    public virtual ICollection<SlideSlide> SlideSlideCreateUs { get; set; } = new List<SlideSlide>();

    public virtual ICollection<SlideSlidePartner> SlideSlidePartnerCreateUs { get; set; } = new List<SlideSlidePartner>();

    public virtual ICollection<SlideSlidePartner> SlideSlidePartnerWriteUs { get; set; } = new List<SlideSlidePartner>();

    public virtual ICollection<SlideSlideResource> SlideSlideResourceCreateUs { get; set; } = new List<SlideSlideResource>();

    public virtual ICollection<SlideSlideResource> SlideSlideResourceWriteUs { get; set; } = new List<SlideSlideResource>();

    public virtual ICollection<SlideSlide> SlideSlideUsers { get; set; } = new List<SlideSlide>();

    public virtual ICollection<SlideSlide> SlideSlideWriteUs { get; set; } = new List<SlideSlide>();

    public virtual ICollection<SlideTag> SlideTagCreateUs { get; set; } = new List<SlideTag>();

    public virtual ICollection<SlideTag> SlideTagWriteUs { get; set; } = new List<SlideTag>();

    public virtual ICollection<SmsComposer> SmsComposerCreateUs { get; set; } = new List<SmsComposer>();

    public virtual ICollection<SmsComposer> SmsComposerWriteUs { get; set; } = new List<SmsComposer>();

    public virtual ICollection<SmsResend> SmsResendCreateUs { get; set; } = new List<SmsResend>();

    public virtual ICollection<SmsResendRecipient> SmsResendRecipientCreateUs { get; set; } = new List<SmsResendRecipient>();

    public virtual ICollection<SmsResendRecipient> SmsResendRecipientWriteUs { get; set; } = new List<SmsResendRecipient>();

    public virtual ICollection<SmsResend> SmsResendWriteUs { get; set; } = new List<SmsResend>();

    public virtual ICollection<SmsSm> SmsSmCreateUs { get; set; } = new List<SmsSm>();

    public virtual ICollection<SmsSm> SmsSmWriteUs { get; set; } = new List<SmsSm>();

    public virtual ICollection<SmsTemplate> SmsTemplateCreateUs { get; set; } = new List<SmsTemplate>();

    public virtual ICollection<SmsTemplatePreview> SmsTemplatePreviewCreateUs { get; set; } = new List<SmsTemplatePreview>();

    public virtual ICollection<SmsTemplatePreview> SmsTemplatePreviewWriteUs { get; set; } = new List<SmsTemplatePreview>();

    public virtual ICollection<SmsTemplateReset> SmsTemplateResetCreateUs { get; set; } = new List<SmsTemplateReset>();

    public virtual ICollection<SmsTemplateReset> SmsTemplateResetWriteUs { get; set; } = new List<SmsTemplateReset>();

    public virtual ICollection<SmsTemplate> SmsTemplateWriteUs { get; set; } = new List<SmsTemplate>();

    public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoiceCreateUs { get; set; } = new List<SnailmailConfirmInvoice>();

    public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoiceWriteUs { get; set; } = new List<SnailmailConfirmInvoice>();

    public virtual ICollection<SnailmailLetter> SnailmailLetterCreateUs { get; set; } = new List<SnailmailLetter>();

    public virtual ICollection<SnailmailLetterFormatError> SnailmailLetterFormatErrorCreateUs { get; set; } = new List<SnailmailLetterFormatError>();

    public virtual ICollection<SnailmailLetterFormatError> SnailmailLetterFormatErrorWriteUs { get; set; } = new List<SnailmailLetterFormatError>();

    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFieldCreateUs { get; set; } = new List<SnailmailLetterMissingRequiredField>();

    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFieldWriteUs { get; set; } = new List<SnailmailLetterMissingRequiredField>();

    public virtual ICollection<SnailmailLetter> SnailmailLetterUsers { get; set; } = new List<SnailmailLetter>();

    public virtual ICollection<SnailmailLetter> SnailmailLetterWriteUs { get; set; } = new List<SnailmailLetter>();

    public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboardCreateUs { get; set; } = new List<SpreadsheetDashboard>();

    public virtual ICollection<SpreadsheetDashboardGroup> SpreadsheetDashboardGroupCreateUs { get; set; } = new List<SpreadsheetDashboardGroup>();

    public virtual ICollection<SpreadsheetDashboardGroup> SpreadsheetDashboardGroupWriteUs { get; set; } = new List<SpreadsheetDashboardGroup>();

    public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboardWriteUs { get; set; } = new List<SpreadsheetDashboard>();

    public virtual ICollection<StockAssignSerial> StockAssignSerialCreateUs { get; set; } = new List<StockAssignSerial>();

    public virtual ICollection<StockAssignSerial> StockAssignSerialWriteUs { get; set; } = new List<StockAssignSerial>();

    public virtual ICollection<StockBackorderConfirmation> StockBackorderConfirmationCreateUs { get; set; } = new List<StockBackorderConfirmation>();

    public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLineCreateUs { get; set; } = new List<StockBackorderConfirmationLine>();

    public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLineWriteUs { get; set; } = new List<StockBackorderConfirmationLine>();

    public virtual ICollection<StockBackorderConfirmation> StockBackorderConfirmationWriteUs { get; set; } = new List<StockBackorderConfirmation>();

    public virtual ICollection<StockChangeProductQty> StockChangeProductQtyCreateUs { get; set; } = new List<StockChangeProductQty>();

    public virtual ICollection<StockChangeProductQty> StockChangeProductQtyWriteUs { get; set; } = new List<StockChangeProductQty>();

    public virtual ICollection<StockImmediateTransfer> StockImmediateTransferCreateUs { get; set; } = new List<StockImmediateTransfer>();

    public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLineCreateUs { get; set; } = new List<StockImmediateTransferLine>();

    public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLineWriteUs { get; set; } = new List<StockImmediateTransferLine>();

    public virtual ICollection<StockImmediateTransfer> StockImmediateTransferWriteUs { get; set; } = new List<StockImmediateTransfer>();

    public virtual ICollection<StockInventoryAdjustmentName> StockInventoryAdjustmentNameCreateUs { get; set; } = new List<StockInventoryAdjustmentName>();

    public virtual ICollection<StockInventoryAdjustmentName> StockInventoryAdjustmentNameWriteUs { get; set; } = new List<StockInventoryAdjustmentName>();

    public virtual ICollection<StockInventoryConflict> StockInventoryConflictCreateUs { get; set; } = new List<StockInventoryConflict>();

    public virtual ICollection<StockInventoryConflict> StockInventoryConflictWriteUs { get; set; } = new List<StockInventoryConflict>();

    public virtual ICollection<StockInventoryWarning> StockInventoryWarningCreateUs { get; set; } = new List<StockInventoryWarning>();

    public virtual ICollection<StockInventoryWarning> StockInventoryWarningWriteUs { get; set; } = new List<StockInventoryWarning>();

    public virtual ICollection<StockLocation> StockLocationCreateUs { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockLocation> StockLocationWriteUs { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockLot> StockLotCreateUs { get; set; } = new List<StockLot>();

    public virtual ICollection<StockLot> StockLotWriteUs { get; set; } = new List<StockLot>();

    public virtual ICollection<StockMove> StockMoveCreateUs { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMoveLine> StockMoveLineCreateUs { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMoveLine> StockMoveLineWriteUs { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoveWriteUs { get; set; } = new List<StockMove>();

    public virtual ICollection<StockOrderpointSnooze> StockOrderpointSnoozeCreateUs { get; set; } = new List<StockOrderpointSnooze>();

    public virtual ICollection<StockOrderpointSnooze> StockOrderpointSnoozeWriteUs { get; set; } = new List<StockOrderpointSnooze>();

    public virtual ICollection<StockPackageDestination> StockPackageDestinationCreateUs { get; set; } = new List<StockPackageDestination>();

    public virtual ICollection<StockPackageDestination> StockPackageDestinationWriteUs { get; set; } = new List<StockPackageDestination>();

    public virtual ICollection<StockPackageLevel> StockPackageLevelCreateUs { get; set; } = new List<StockPackageLevel>();

    public virtual ICollection<StockPackageLevel> StockPackageLevelWriteUs { get; set; } = new List<StockPackageLevel>();

    public virtual ICollection<StockPackageType> StockPackageTypeCreateUs { get; set; } = new List<StockPackageType>();

    public virtual ICollection<StockPackageType> StockPackageTypeWriteUs { get; set; } = new List<StockPackageType>();

    public virtual ICollection<StockPicking> StockPickingCreateUs { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockPickingType> StockPickingTypeCreateUs { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockPickingType> StockPickingTypeWriteUs { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockPicking> StockPickingUsers { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockPicking> StockPickingWriteUs { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockPutawayRule> StockPutawayRuleCreateUs { get; set; } = new List<StockPutawayRule>();

    public virtual ICollection<StockPutawayRule> StockPutawayRuleWriteUs { get; set; } = new List<StockPutawayRule>();

    public virtual ICollection<StockQuant> StockQuantCreateUs { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockQuantPackage> StockQuantPackageCreateUs { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuantPackage> StockQuantPackageWriteUs { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuant> StockQuantUsers { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockQuant> StockQuantWriteUs { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockQuantityHistory> StockQuantityHistoryCreateUs { get; set; } = new List<StockQuantityHistory>();

    public virtual ICollection<StockQuantityHistory> StockQuantityHistoryWriteUs { get; set; } = new List<StockQuantityHistory>();

    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfoCreateUs { get; set; } = new List<StockReplenishmentInfo>();

    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfoWriteUs { get; set; } = new List<StockReplenishmentInfo>();

    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptionCreateUs { get; set; } = new List<StockReplenishmentOption>();

    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptionWriteUs { get; set; } = new List<StockReplenishmentOption>();

    public virtual ICollection<StockRequestCount> StockRequestCountCreateUs { get; set; } = new List<StockRequestCount>();

    public virtual ICollection<StockRequestCount> StockRequestCountUsers { get; set; } = new List<StockRequestCount>();

    public virtual ICollection<StockRequestCount> StockRequestCountWriteUs { get; set; } = new List<StockRequestCount>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingCreateUs { get; set; } = new List<StockReturnPicking>();

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLineCreateUs { get; set; } = new List<StockReturnPickingLine>();

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLineWriteUs { get; set; } = new List<StockReturnPickingLine>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingWriteUs { get; set; } = new List<StockReturnPicking>();

    public virtual ICollection<StockRoute> StockRouteCreateUs { get; set; } = new List<StockRoute>();

    public virtual ICollection<StockRoute> StockRouteWriteUs { get; set; } = new List<StockRoute>();

    public virtual ICollection<StockRule> StockRuleCreateUs { get; set; } = new List<StockRule>();

    public virtual ICollection<StockRule> StockRuleWriteUs { get; set; } = new List<StockRule>();

    public virtual ICollection<StockRulesReport> StockRulesReportCreateUs { get; set; } = new List<StockRulesReport>();

    public virtual ICollection<StockRulesReport> StockRulesReportWriteUs { get; set; } = new List<StockRulesReport>();

    public virtual ICollection<StockSchedulerCompute> StockSchedulerComputeCreateUs { get; set; } = new List<StockSchedulerCompute>();

    public virtual ICollection<StockSchedulerCompute> StockSchedulerComputeWriteUs { get; set; } = new List<StockSchedulerCompute>();

    public virtual ICollection<StockScrap> StockScrapCreateUs { get; set; } = new List<StockScrap>();

    public virtual ICollection<StockScrap> StockScrapWriteUs { get; set; } = new List<StockScrap>();

    public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacityCreateUs { get; set; } = new List<StockStorageCategoryCapacity>();

    public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacityWriteUs { get; set; } = new List<StockStorageCategoryCapacity>();

    public virtual ICollection<StockStorageCategory> StockStorageCategoryCreateUs { get; set; } = new List<StockStorageCategory>();

    public virtual ICollection<StockStorageCategory> StockStorageCategoryWriteUs { get; set; } = new List<StockStorageCategory>();

    public virtual ICollection<StockTraceabilityReport> StockTraceabilityReportCreateUs { get; set; } = new List<StockTraceabilityReport>();

    public virtual ICollection<StockTraceabilityReport> StockTraceabilityReportWriteUs { get; set; } = new List<StockTraceabilityReport>();

    public virtual ICollection<StockTrackConfirmation> StockTrackConfirmationCreateUs { get; set; } = new List<StockTrackConfirmation>();

    public virtual ICollection<StockTrackConfirmation> StockTrackConfirmationWriteUs { get; set; } = new List<StockTrackConfirmation>();

    public virtual ICollection<StockTrackLine> StockTrackLineCreateUs { get; set; } = new List<StockTrackLine>();

    public virtual ICollection<StockTrackLine> StockTrackLineWriteUs { get; set; } = new List<StockTrackLine>();

    public virtual ICollection<StockValuationLayer> StockValuationLayerCreateUs { get; set; } = new List<StockValuationLayer>();

    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluationCreateUs { get; set; } = new List<StockValuationLayerRevaluation>();

    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluationWriteUs { get; set; } = new List<StockValuationLayerRevaluation>();

    public virtual ICollection<StockValuationLayer> StockValuationLayerWriteUs { get; set; } = new List<StockValuationLayer>();

    public virtual ICollection<StockWarehouse> StockWarehouseCreateUs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpointCreateUs { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpointWriteUs { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehouseWriteUs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairCreateUs { get; set; } = new List<StockWarnInsufficientQtyRepair>();

    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairWriteUs { get; set; } = new List<StockWarnInsufficientQtyRepair>();

    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScrapCreateUs { get; set; } = new List<StockWarnInsufficientQtyScrap>();

    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScrapWriteUs { get; set; } = new List<StockWarnInsufficientQtyScrap>();

    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuildCreateUs { get; set; } = new List<StockWarnInsufficientQtyUnbuild>();

    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuildWriteUs { get; set; } = new List<StockWarnInsufficientQtyUnbuild>();

    public virtual ICollection<SurveyInvite> SurveyInviteCreateUs { get; set; } = new List<SurveyInvite>();

    public virtual ICollection<SurveyInvite> SurveyInviteWriteUs { get; set; } = new List<SurveyInvite>();

    public virtual ICollection<SurveyQuestionAnswer> SurveyQuestionAnswerCreateUs { get; set; } = new List<SurveyQuestionAnswer>();

    public virtual ICollection<SurveyQuestionAnswer> SurveyQuestionAnswerWriteUs { get; set; } = new List<SurveyQuestionAnswer>();

    public virtual ICollection<SurveyQuestion> SurveyQuestionCreateUs { get; set; } = new List<SurveyQuestion>();

    public virtual ICollection<SurveyQuestion> SurveyQuestionWriteUs { get; set; } = new List<SurveyQuestion>();

    public virtual ICollection<SurveySurvey> SurveySurveyCreateUs { get; set; } = new List<SurveySurvey>();

    public virtual ICollection<SurveySurvey> SurveySurveyUsers { get; set; } = new List<SurveySurvey>();

    public virtual ICollection<SurveySurvey> SurveySurveyWriteUs { get; set; } = new List<SurveySurvey>();

    public virtual ICollection<SurveyUserInput> SurveyUserInputCreateUs { get; set; } = new List<SurveyUserInput>();

    public virtual ICollection<SurveyUserInputLine> SurveyUserInputLineCreateUs { get; set; } = new List<SurveyUserInputLine>();

    public virtual ICollection<SurveyUserInputLine> SurveyUserInputLineWriteUs { get; set; } = new List<SurveyUserInputLine>();

    public virtual ICollection<SurveyUserInput> SurveyUserInputWriteUs { get; set; } = new List<SurveyUserInput>();

    public virtual ICollection<ThemeIrAsset> ThemeIrAssetCreateUs { get; set; } = new List<ThemeIrAsset>();

    public virtual ICollection<ThemeIrAsset> ThemeIrAssetWriteUs { get; set; } = new List<ThemeIrAsset>();

    public virtual ICollection<ThemeIrAttachment> ThemeIrAttachmentCreateUs { get; set; } = new List<ThemeIrAttachment>();

    public virtual ICollection<ThemeIrAttachment> ThemeIrAttachmentWriteUs { get; set; } = new List<ThemeIrAttachment>();

    public virtual ICollection<ThemeIrUiView> ThemeIrUiViewCreateUs { get; set; } = new List<ThemeIrUiView>();

    public virtual ICollection<ThemeIrUiView> ThemeIrUiViewWriteUs { get; set; } = new List<ThemeIrUiView>();

    public virtual ICollection<ThemeWebsiteMenu> ThemeWebsiteMenuCreateUs { get; set; } = new List<ThemeWebsiteMenu>();

    public virtual ICollection<ThemeWebsiteMenu> ThemeWebsiteMenuWriteUs { get; set; } = new List<ThemeWebsiteMenu>();

    public virtual ICollection<ThemeWebsitePage> ThemeWebsitePageCreateUs { get; set; } = new List<ThemeWebsitePage>();

    public virtual ICollection<ThemeWebsitePage> ThemeWebsitePageWriteUs { get; set; } = new List<ThemeWebsitePage>();

    public virtual ICollection<UomCategory> UomCategoryCreateUs { get; set; } = new List<UomCategory>();

    public virtual ICollection<UomCategory> UomCategoryWriteUs { get; set; } = new List<UomCategory>();

    public virtual ICollection<UomUom> UomUomCreateUs { get; set; } = new List<UomUom>();

    public virtual ICollection<UomUom> UomUomWriteUs { get; set; } = new List<UomUom>();

    public virtual ICollection<UtmCampaign> UtmCampaignCreateUs { get; set; } = new List<UtmCampaign>();

    public virtual ICollection<UtmCampaign> UtmCampaignUsers { get; set; } = new List<UtmCampaign>();

    public virtual ICollection<UtmCampaign> UtmCampaignWriteUs { get; set; } = new List<UtmCampaign>();

    public virtual ICollection<UtmMedium> UtmMediumCreateUs { get; set; } = new List<UtmMedium>();

    public virtual ICollection<UtmMedium> UtmMediumWriteUs { get; set; } = new List<UtmMedium>();

    public virtual ICollection<UtmSource> UtmSourceCreateUs { get; set; } = new List<UtmSource>();

    public virtual ICollection<UtmSource> UtmSourceWriteUs { get; set; } = new List<UtmSource>();

    public virtual ICollection<UtmStage> UtmStageCreateUs { get; set; } = new List<UtmStage>();

    public virtual ICollection<UtmStage> UtmStageWriteUs { get; set; } = new List<UtmStage>();

    public virtual ICollection<UtmTag> UtmTagCreateUs { get; set; } = new List<UtmTag>();

    public virtual ICollection<UtmTag> UtmTagWriteUs { get; set; } = new List<UtmTag>();

    public virtual ICollection<ValidateAccountMove> ValidateAccountMoveCreateUs { get; set; } = new List<ValidateAccountMove>();

    public virtual ICollection<ValidateAccountMove> ValidateAccountMoveWriteUs { get; set; } = new List<ValidateAccountMove>();

    public virtual ICollection<WebEditorConverterTest> WebEditorConverterTestCreateUs { get; set; } = new List<WebEditorConverterTest>();

    public virtual ICollection<WebEditorConverterTestSub> WebEditorConverterTestSubCreateUs { get; set; } = new List<WebEditorConverterTestSub>();

    public virtual ICollection<WebEditorConverterTestSub> WebEditorConverterTestSubWriteUs { get; set; } = new List<WebEditorConverterTestSub>();

    public virtual ICollection<WebEditorConverterTest> WebEditorConverterTestWriteUs { get; set; } = new List<WebEditorConverterTest>();

    public virtual ICollection<WebTourTour> WebTourTours { get; set; } = new List<WebTourTour>();

    public virtual Website? Website { get; set; }

    public virtual ICollection<WebsiteBaseUnit> WebsiteBaseUnitCreateUs { get; set; } = new List<WebsiteBaseUnit>();

    public virtual ICollection<WebsiteBaseUnit> WebsiteBaseUnitWriteUs { get; set; } = new List<WebsiteBaseUnit>();

    public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatureCreateUs { get; set; } = new List<WebsiteConfiguratorFeature>();

    public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatureWriteUs { get; set; } = new List<WebsiteConfiguratorFeature>();

    public virtual ICollection<Website> WebsiteCreateUs { get; set; } = new List<Website>();

    public virtual ICollection<Website> WebsiteCrmDefaultUsers { get; set; } = new List<Website>();

    public virtual ICollection<WebsiteEventMenu> WebsiteEventMenuCreateUs { get; set; } = new List<WebsiteEventMenu>();

    public virtual ICollection<WebsiteEventMenu> WebsiteEventMenuWriteUs { get; set; } = new List<WebsiteEventMenu>();

    public virtual ICollection<WebsiteMenu> WebsiteMenuCreateUs { get; set; } = new List<WebsiteMenu>();

    public virtual ICollection<WebsiteMenu> WebsiteMenuWriteUs { get; set; } = new List<WebsiteMenu>();

    public virtual ICollection<WebsitePage> WebsitePageCreateUs { get; set; } = new List<WebsitePage>();

    public virtual ICollection<WebsitePage> WebsitePageWriteUs { get; set; } = new List<WebsitePage>();

    public virtual ICollection<WebsiteRewrite> WebsiteRewriteCreateUs { get; set; } = new List<WebsiteRewrite>();

    public virtual ICollection<WebsiteRewrite> WebsiteRewriteWriteUs { get; set; } = new List<WebsiteRewrite>();

    public virtual ICollection<WebsiteRobot> WebsiteRobotCreateUs { get; set; } = new List<WebsiteRobot>();

    public virtual ICollection<WebsiteRobot> WebsiteRobotWriteUs { get; set; } = new List<WebsiteRobot>();

    public virtual ICollection<WebsiteRoute> WebsiteRouteCreateUs { get; set; } = new List<WebsiteRoute>();

    public virtual ICollection<WebsiteRoute> WebsiteRouteWriteUs { get; set; } = new List<WebsiteRoute>();

    public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFieldCreateUs { get; set; } = new List<WebsiteSaleExtraField>();

    public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFieldWriteUs { get; set; } = new List<WebsiteSaleExtraField>();

    public virtual ICollection<Website> WebsiteSalespeople { get; set; } = new List<Website>();

    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilterCreateUs { get; set; } = new List<WebsiteSnippetFilter>();

    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilterWriteUs { get; set; } = new List<WebsiteSnippetFilter>();

    public virtual ICollection<Website> WebsiteUsers { get; set; } = new List<Website>();

    public virtual ICollection<WebsiteVisitor> WebsiteVisitorCreateUs { get; set; } = new List<WebsiteVisitor>();

    public virtual ICollection<WebsiteVisitor> WebsiteVisitorWriteUs { get; set; } = new List<WebsiteVisitor>();

    public virtual ICollection<Website> WebsiteWriteUs { get; set; } = new List<Website>();

    public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreateCreateUs { get; set; } = new List<WizardIrModelMenuCreate>();

    public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreateWriteUs { get; set; } = new List<WizardIrModelMenuCreate>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ImLivechatChannel> Channels { get; set; } = new List<ImLivechatChannel>();

    public virtual ICollection<ResCompany> Cids { get; set; } = new List<ResCompany>();

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; set; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<DataRecycleModel> DataRecycleModels { get; set; } = new List<DataRecycleModel>();

    public virtual ICollection<DigestDigest> DigestDigests { get; set; } = new List<DigestDigest>();

    public virtual ICollection<DigestTip> DigestTips { get; set; } = new List<DigestTip>();

    public virtual ICollection<GamificationBadge> GamificationBadges { get; set; } = new List<GamificationBadge>();

    public virtual ICollection<GamificationChallenge> GamificationChallenges { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<GamificationChallenge> GamificationChallengesNavigation { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<ResGroup> Gids { get; set; } = new List<ResGroup>();

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrJob> HrJobsNavigation { get; set; } = new List<HrJob>();

    public virtual ICollection<HrJob> Jobs { get; set; } = new List<HrJob>();

    public virtual ICollection<MaintenanceTeam> MaintenanceTeams { get; set; } = new List<MaintenanceTeam>();

    public virtual ICollection<LunchProduct> Products { get; set; } = new List<LunchProduct>();

    public virtual ICollection<ProjectProject> Projects { get; set; } = new List<ProjectProject>();

    public virtual ICollection<CrmTeam> Teams { get; set; } = new List<CrmTeam>();
}
