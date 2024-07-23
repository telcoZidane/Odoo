using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Core.Utility.EnumOdoo
{
    public static class EnumExtensions
    {
        public static string Value(this Enum value)
        {
            var enumMemberAttribute = value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(EnumMemberAttribute), false)
                .Cast<EnumMemberAttribute>()
                .FirstOrDefault();

            return enumMemberAttribute?.Value;
        }
    }
    public class EnumOdoo
    {

        public enum EnumsOdoo
        {
            [EnumMember(Value = "account.account")]
            AccountAccount,
            [EnumMember(Value = "account.account.tag")]
            AccountAccountTag,
            [EnumMember(Value = "account.account.template")]
            AccountAccountTemplate,
            [EnumMember(Value = "account.accrued.orders.wizard")]
            AccountAccruedOrdersWizard,
            [EnumMember(Value = "account.analytic.account")]
            AccountAnalyticAccount,
            [EnumMember(Value = "account.analytic.applicability")]
            AccountAnalyticApplicability,
            [EnumMember(Value = "account.analytic.distribution.model")]
            AccountAnalyticDistributionModel,
            [EnumMember(Value = "account.analytic.line")]
            AccountAnalyticLine,
            [EnumMember(Value = "account.analytic.plan")]
            AccountAnalyticPlan,
            [EnumMember(Value = "account.automatic.entry.wizard")]
            AccountAutomaticEntryWizard,
            [EnumMember(Value = "account.bank.statement")]
            AccountBankStatement,
            [EnumMember(Value = "account.bank.statement.line")]
            AccountBankStatementLine,
            [EnumMember(Value = "account.cash.rounding")]
            AccountCashRounding,
            [EnumMember(Value = "account.chart.template")]
            AccountChartTemplate,
            [EnumMember(Value = "account.edi.document")]
            AccountEdiDocument,
            [EnumMember(Value = "account.edi.format")]
            AccountEdiFormat,
            [EnumMember(Value = "account.financial.year.op")]
            AccountFinancialYearOp,
            [EnumMember(Value = "account.fiscal.position")]
            AccountFiscalPosition,
            [EnumMember(Value = "account.fiscal.position.account")]
            AccountFiscalPositionAccount,
            [EnumMember(Value = "account.fiscal.position.account.template")]
            AccountFiscalPositionAccountTemplate,
            [EnumMember(Value = "account.fiscal.position.tax")]
            AccountFiscalPositionTax,
            [EnumMember(Value = "account.fiscal.position.tax.template")]
            AccountFiscalPositionTaxTemplate,
            [EnumMember(Value = "account.fiscal.position.template")]
            AccountFiscalPositionTemplate,
            [EnumMember(Value = "account.full.reconcile")]
            AccountFullReconcile,
            [EnumMember(Value = "account.group")]
            AccountGroup,
            [EnumMember(Value = "account.group.template")]
            AccountGroupTemplate,
            [EnumMember(Value = "account.incoterm")]
            AccountIncoterm,
            [EnumMember(Value = "account.invoice.send")]
            AccountInvoiceSend,
            [EnumMember(Value = "account.journal")]
            AccountJournal,
            [EnumMember(Value = "account.journal.group")]
            AccountJournalGroup,
            [EnumMember(Value = "account.move")]
            AccountMove,
            [EnumMember(Value = "account.move.line")]
            AccountMoveLine,
            [EnumMember(Value = "account.move.reversal")]
            AccountMoveReversal,
            [EnumMember(Value = "account.partial.reconcile")]
            AccountPartialReconcile,
            [EnumMember(Value = "account.payment")]
            AccountPayment,
            [EnumMember(Value = "account.payment.method")]
            AccountPaymentMethod,
            [EnumMember(Value = "account.payment.method.line")]
            AccountPaymentMethodLine,
            [EnumMember(Value = "account.payment.register")]
            AccountPaymentRegister,
            [EnumMember(Value = "account.payment.term")]
            AccountPaymentTerm,
            [EnumMember(Value = "account.payment.term.line")]
            AccountPaymentTermLine,
            [EnumMember(Value = "account.reconcile.model")]
            AccountReconcileModel,
            [EnumMember(Value = "account.reconcile.model.line")]
            AccountReconcileModelLine,
            [EnumMember(Value = "account.reconcile.model.line.template")]
            AccountReconcileModelLineTemplate,
            [EnumMember(Value = "account.reconcile.model.partner.mapping")]
            AccountReconcileModelPartnerMapping,
            [EnumMember(Value = "account.reconcile.model.template")]
            AccountReconcileModelTemplate,
            [EnumMember(Value = "account.report")]
            AccountReport,
            [EnumMember(Value = "account.report.column")]
            AccountReportColumn,
            [EnumMember(Value = "account.report.expression")]
            AccountReportExpression,
            [EnumMember(Value = "account.report.external.value")]
            AccountReportExternalValue,
            [EnumMember(Value = "account.report.line")]
            AccountReportLine,
            [EnumMember(Value = "account.resequence.wizard")]
            AccountResequenceWizard,
            [EnumMember(Value = "account.root")]
            AccountRoot,
            [EnumMember(Value = "account.setup.bank.manual.config")]
            AccountSetupBankManualConfig,
            [EnumMember(Value = "account.tax")]
            AccountTax,
            [EnumMember(Value = "account.tax.group")]
            AccountTaxGroup,
            [EnumMember(Value = "account.tax.repartition.line")]
            AccountTaxRepartitionLine,
            [EnumMember(Value = "account.tax.repartition.line.template")]
            AccountTaxRepartitionLineTemplate,
            [EnumMember(Value = "account.tax.template")]
            AccountTaxTemplate,
            [EnumMember(Value = "account.tour.upload.bill")]
            AccountTourUploadBill,
            [EnumMember(Value = "account.tour.upload.bill.email.confirm")]
            AccountTourUploadBillEmailConfirm,
            [EnumMember(Value = "account.unreconcile")]
            AccountUnreconcile,
            [EnumMember(Value = "applicant.get.refuse.reason")]
            ApplicantGetRefuseReason,
            [EnumMember(Value = "applicant.send.mail")]
            ApplicantSendMail,
            [EnumMember(Value = "auth.totp.device")]
            AuthTotpDevice,
            [EnumMember(Value = "auth.totp.wizard")]
            AuthTotpWizard,
            [EnumMember(Value = "barcode.nomenclature")]
            BarcodeNomenclature,
            [EnumMember(Value = "barcode.rule")]
            BarcodeRule,
            [EnumMember(Value = "base.document.layout")]
            BaseDocumentLayout,
            [EnumMember(Value = "base.enable.profiling.wizard")]
            BaseEnableProfilingWizard,
            [EnumMember(Value = "base.import.import")]
            BaseImportImport,
            [EnumMember(Value = "base.import.mapping")]
            BaseImportMapping,
            [EnumMember(Value = "base.import.tests.models.char")]
            BaseImportTestsModelsChar,
            [EnumMember(Value = "base.import.tests.models.char.noreadonly")]
            BaseImportTestsModelsCharNoreadonly,
            [EnumMember(Value = "base.import.tests.models.char.readonly")]
            BaseImportTestsModelsCharReadonly,
            [EnumMember(Value = "base.import.tests.models.char.required")]
            BaseImportTestsModelsCharRequired,
            [EnumMember(Value = "base.import.tests.models.char.state")]
            BaseImportTestsModelsCharState,
            [EnumMember(Value = "base.import.tests.models.char.stillreadonly")]
            BaseImportTestsModelsCharStillreadonly,
            [EnumMember(Value = "base.import.tests.models.complex")]
            BaseImportTestsModelsComplex,
            [EnumMember(Value = "base.import.tests.models.float")]
            BaseImportTestsModelsFloat,
            [EnumMember(Value = "base.import.tests.models.m2o")]
            BaseImportTestsModelsM2o,
            [EnumMember(Value = "base.import.tests.models.m2o.related")]
            BaseImportTestsModelsM2oRelated,
            [EnumMember(Value = "base.import.tests.models.m2o.required")]
            BaseImportTestsModelsM2oRequired,
            [EnumMember(Value = "base.import.tests.models.m2o.required.related")]
            BaseImportTestsModelsM2oRequiredRelated,
            [EnumMember(Value = "base.import.tests.models.o2m")]
            BaseImportTestsModelsO2m,
            [EnumMember(Value = "base.import.tests.models.o2m.child")]
            BaseImportTestsModelsO2mChild,
            [EnumMember(Value = "base.import.tests.models.preview")]
            BaseImportTestsModelsPreview,
            [EnumMember(Value = "base.language.export")]
            BaseLanguageExport,
            [EnumMember(Value = "base.language.import")]
            BaseLanguageImport,
            [EnumMember(Value = "base.language.install")]
            BaseLanguageInstall,
            [EnumMember(Value = "base.module.install.request")]
            BaseModuleInstallRequest,
            [EnumMember(Value = "base.module.install.review")]
            BaseModuleInstallReview,
            [EnumMember(Value = "base.module.uninstall")]
            BaseModuleUninstall,
            [EnumMember(Value = "base.module.update")]
            BaseModuleUpdate,
            [EnumMember(Value = "base.module.upgrade")]
            BaseModuleUpgrade,
            [EnumMember(Value = "base.partner.merge.automatic.wizard")]
            BasePartnerMergeAutomaticWizard,
            [EnumMember(Value = "base.partner.merge.line")]
            BasePartnerMergeLine,
            [EnumMember(Value = "bus.bu")]
            BusBu,
            [EnumMember(Value = "bus.presence")]
            BusPresence,
            [EnumMember(Value = "calendar.alarm")]
            CalendarAlarm,
            [EnumMember(Value = "calendar.attendee")]
            CalendarAttendee,
            [EnumMember(Value = "calendar.event")]
            CalendarEvent,
            [EnumMember(Value = "calendar.event.type")]
            CalendarEventType,
            [EnumMember(Value = "calendar.filter")]
            CalendarFilter,
            [EnumMember(Value = "calendar.provider.config")]
            CalendarProviderConfig,
            [EnumMember(Value = "calendar.recurrence")]
            CalendarRecurrence,
            [EnumMember(Value = "change.password.own")]
            ChangePasswordOwn,
            [EnumMember(Value = "change.password.user")]
            ChangePasswordUser,
            [EnumMember(Value = "change.password.wizard")]
            ChangePasswordWizard,
            [EnumMember(Value = "change.production.qty")]
            ChangeProductionQty,
            [EnumMember(Value = "chatbot.message")]
            ChatbotMessage,
            [EnumMember(Value = "chatbot.script")]
            ChatbotScript,
            [EnumMember(Value = "chatbot.script.answer")]
            ChatbotScriptAnswer,
            [EnumMember(Value = "chatbot.script.step")]
            ChatbotScriptStep,
            [EnumMember(Value = "confirm.stock.sm")]
            ConfirmStockSm,
            [EnumMember(Value = "crm.activity.report")]
            CrmActivityReport,
            [EnumMember(Value = "crm.iap.lead.helper")]
            CrmIapLeadHelper,
            [EnumMember(Value = "crm.iap.lead.industry")]
            CrmIapLeadIndustry,
            [EnumMember(Value = "crm.iap.lead.mining.request")]
            CrmIapLeadMiningRequest,
            [EnumMember(Value = "crm.iap.lead.role")]
            CrmIapLeadRole,
            [EnumMember(Value = "crm.iap.lead.seniority")]
            CrmIapLeadSeniority,
            [EnumMember(Value = "crm.lead")]
            CrmLead,
            [EnumMember(Value = "crm.lead2opportunity.partner")]
            CrmLead2opportunityPartner,
            [EnumMember(Value = "crm.lead2opportunity.partner.mass")]
            CrmLead2opportunityPartnerMass,
            [EnumMember(Value = "crm.lead.lost")]
            CrmLeadLost,
            [EnumMember(Value = "crm.lead.pls.update")]
            CrmLeadPlsUpdate,
            [EnumMember(Value = "crm.lead.scoring.frequency")]
            CrmLeadScoringFrequency,
            [EnumMember(Value = "crm.lead.scoring.frequency.field")]
            CrmLeadScoringFrequencyField,
            [EnumMember(Value = "crm.lost.reason")]
            CrmLostReason,
            [EnumMember(Value = "crm.merge.opportunity")]
            CrmMergeOpportunity,
            [EnumMember(Value = "crm.quotation.partner")]
            CrmQuotationPartner,
            [EnumMember(Value = "crm.recurring.plan")]
            CrmRecurringPlan,
            [EnumMember(Value = "crm.stage")]
            CrmStage,
            [EnumMember(Value = "crm.tag")]
            CrmTag,
            [EnumMember(Value = "crm.team")]
            CrmTeam,
            [EnumMember(Value = "crm.team.member")]
            CrmTeamMember,
            [EnumMember(Value = "data.recycle.model")]
            DataRecycleModel,
            [EnumMember(Value = "data.recycle.record")]
            DataRecycleRecord,
            [EnumMember(Value = "decimal.precision")]
            DecimalPrecision,
            [EnumMember(Value = "digest.digest")]
            DigestDigest,
            [EnumMember(Value = "digest.tip")]
            DigestTip,
            [EnumMember(Value = "event.event")]
            EventEvent,
            [EnumMember(Value = "event.event.configurator")]
            EventEventConfigurator,
            [EnumMember(Value = "event.event.ticket")]
            EventEventTicket,
            [EnumMember(Value = "event.lead.rule")]
            EventLeadRule,
            [EnumMember(Value = "event.mail")]
            EventMail,
            [EnumMember(Value = "event.mail.registration")]
            EventMailRegistration,
            [EnumMember(Value = "event.registration")]
            EventRegistration,
            [EnumMember(Value = "event.sale.report")]
            EventSaleReport,
            [EnumMember(Value = "event.stage")]
            EventStage,
            [EnumMember(Value = "event.tag")]
            EventTag,
            [EnumMember(Value = "event.tag.category")]
            EventTagCategory,
            [EnumMember(Value = "event.type")]
            EventType,
            [EnumMember(Value = "event.type.mail")]
            EventTypeMail,
            [EnumMember(Value = "event.type.ticket")]
            EventTypeTicket,
            [EnumMember(Value = "fetchmail.server")]
            FetchmailServer,
            [EnumMember(Value = "fleet.service.type")]
            FleetServiceType,
            [EnumMember(Value = "fleet.vehicle")]
            FleetVehicle,
            [EnumMember(Value = "fleet.vehicle.assignation.log")]
            FleetVehicleAssignationLog,
            [EnumMember(Value = "fleet.vehicle.cost.report")]
            FleetVehicleCostReport,
            [EnumMember(Value = "fleet.vehicle.log.contract")]
            FleetVehicleLogContract,
            [EnumMember(Value = "fleet.vehicle.log.service")]
            FleetVehicleLogService,
            [EnumMember(Value = "fleet.vehicle.model")]
            FleetVehicleModel,
            [EnumMember(Value = "fleet.vehicle.model.brand")]
            FleetVehicleModelBrand,
            [EnumMember(Value = "fleet.vehicle.model.category")]
            FleetVehicleModelCategory,
            [EnumMember(Value = "fleet.vehicle.odometer")]
            FleetVehicleOdometer,
            [EnumMember(Value = "fleet.vehicle.state")]
            FleetVehicleState,
            [EnumMember(Value = "fleet.vehicle.tag")]
            FleetVehicleTag,
            [EnumMember(Value = "gamification.badge")]
            GamificationBadge,
            [EnumMember(Value = "gamification.badge.user")]
            GamificationBadgeUser,
            [EnumMember(Value = "gamification.badge.user.wizard")]
            GamificationBadgeUserWizard,
            [EnumMember(Value = "gamification.challenge")]
            GamificationChallenge,
            [EnumMember(Value = "gamification.challenge.line")]
            GamificationChallengeLine,
            [EnumMember(Value = "gamification.goal")]
            GamificationGoal,
            [EnumMember(Value = "gamification.goal.definition")]
            GamificationGoalDefinition,
            [EnumMember(Value = "gamification.goal.wizard")]
            GamificationGoalWizard,
            [EnumMember(Value = "gamification.karma.rank")]
            GamificationKarmaRank,
            [EnumMember(Value = "gamification.karma.tracking")]
            GamificationKarmaTracking,
            [EnumMember(Value = "hr.applicant")]
            HrApplicant,
            [EnumMember(Value = "hr.applicant.category")]
            HrApplicantCategory,
            [EnumMember(Value = "hr.applicant.refuse.reason")]
            HrApplicantRefuseReason,
            [EnumMember(Value = "hr.applicant.skill")]
            HrApplicantSkill,
            [EnumMember(Value = "hr.attendance")]
            HrAttendance,
            [EnumMember(Value = "hr.attendance.overtime")]
            HrAttendanceOvertime,
            [EnumMember(Value = "hr.attendance.report")]
            HrAttendanceReport,
            [EnumMember(Value = "hr.contract")]
            HrContract,
            [EnumMember(Value = "hr.contract.history")]
            HrContractHistory,
            [EnumMember(Value = "hr.contract.type")]
            HrContractType,
            [EnumMember(Value = "hr.department")]
            HrDepartment,
            [EnumMember(Value = "hr.departure.reason")]
            HrDepartureReason,
            [EnumMember(Value = "hr.departure.wizard")]
            HrDepartureWizard,
            [EnumMember(Value = "hr.employee")]
            HrEmployee,
            [EnumMember(Value = "hr.employee.category")]
            HrEmployeeCategory,
            [EnumMember(Value = "hr.employee.public")]
            HrEmployeePublic,
            [EnumMember(Value = "hr.employee.skill")]
            HrEmployeeSkill,
            [EnumMember(Value = "hr.employee.skill.log")]
            HrEmployeeSkillLog,
            [EnumMember(Value = "hr.employee.skill.report")]
            HrEmployeeSkillReport,
            [EnumMember(Value = "hr.expense")]
            HrExpense,
            [EnumMember(Value = "hr.expense.approve.duplicate")]
            HrExpenseApproveDuplicate,
            [EnumMember(Value = "hr.expense.refuse.wizard")]
            HrExpenseRefuseWizard,
            [EnumMember(Value = "hr.expense.sheet")]
            HrExpenseSheet,
            [EnumMember(Value = "hr.expense.split")]
            HrExpenseSplit,
            [EnumMember(Value = "hr.expense.split.wizard")]
            HrExpenseSplitWizard,
            [EnumMember(Value = "hr.holidays.cancel.leave")]
            HrHolidaysCancelLeave,
            [EnumMember(Value = "hr.holidays.summary.employee")]
            HrHolidaysSummaryEmployee,
            [EnumMember(Value = "hr.job")]
            HrJob,
            [EnumMember(Value = "hr.leave")]
            HrLeave,
            [EnumMember(Value = "hr.leave.accrual.level")]
            HrLeaveAccrualLevel,
            [EnumMember(Value = "hr.leave.accrual.plan")]
            HrLeaveAccrualPlan,
            [EnumMember(Value = "hr.leave.allocation")]
            HrLeaveAllocation,
            [EnumMember(Value = "hr.leave.employee.type.report")]
            HrLeaveEmployeeTypeReport,
            [EnumMember(Value = "hr.leave.report")]
            HrLeaveReport,
            [EnumMember(Value = "hr.leave.report.calendar")]
            HrLeaveReportCalendar,
            [EnumMember(Value = "hr.leave.stress.day")]
            HrLeaveStressDay,
            [EnumMember(Value = "hr.leave.type")]
            HrLeaveType,
            [EnumMember(Value = "hr.payroll.structure.type")]
            HrPayrollStructureType,
            [EnumMember(Value = "hr.plan")]
            HrPlan,
            [EnumMember(Value = "hr.plan.activity.type")]
            HrPlanActivityType,
            [EnumMember(Value = "hr.plan.wizard")]
            HrPlanWizard,
            [EnumMember(Value = "hr.recruitment.degree")]
            HrRecruitmentDegree,
            [EnumMember(Value = "hr.recruitment.source")]
            HrRecruitmentSource,
            [EnumMember(Value = "hr.recruitment.stage")]
            HrRecruitmentStage,
            [EnumMember(Value = "hr.resume.line")]
            HrResumeLine,
            [EnumMember(Value = "hr.resume.line.type")]
            HrResumeLineType,
            [EnumMember(Value = "hr.skill")]
            HrSkill,
            [EnumMember(Value = "hr.skill.level")]
            HrSkillLevel,
            [EnumMember(Value = "hr.skill.type")]
            HrSkillType,
            [EnumMember(Value = "hr.work.location")]
            HrWorkLocation,
            [EnumMember(Value = "iap.account")]
            IapAccount,
            [EnumMember(Value = "im.livechat.channel")]
            ImLivechatChannel,
            [EnumMember(Value = "im.livechat.channel.rule")]
            ImLivechatChannelRule,
            [EnumMember(Value = "im.livechat.report.channel")]
            ImLivechatReportChannel,
            [EnumMember(Value = "im.livechat.report.operator")]
            ImLivechatReportOperator,
            [EnumMember(Value = "ir.act.client")]
            IrActClient,
            [EnumMember(Value = "ir.act.report.xml")]
            IrActReportXml,
            [EnumMember(Value = "ir.act.server")]
            IrActServer,
            [EnumMember(Value = "ir.act.url")]
            IrActUrl,
            [EnumMember(Value = "ir.act.window")]
            IrActWindow,
            [EnumMember(Value = "ir.act.window.view")]
            IrActWindowView,
            [EnumMember(Value = "ir.action")]
            IrAction,
            [EnumMember(Value = "ir.actions.todo")]
            IrActionsTodo,
            [EnumMember(Value = "ir.asset")]
            IrAsset,
            [EnumMember(Value = "ir.attachment")]
            IrAttachment,
            [EnumMember(Value = "ir.config.parameter")]
            IrConfigParameter,
            [EnumMember(Value = "ir.cron")]
            IrCron,
            [EnumMember(Value = "ir.cron.trigger")]
            IrCronTrigger,
            [EnumMember(Value = "ir.default")]
            IrDefault,
            [EnumMember(Value = "ir.demo")]
            IrDemo,
            [EnumMember(Value = "ir.demo.failure")]
            IrDemoFailure,
            [EnumMember(Value = "ir.demo.failure.wizard")]
            IrDemoFailureWizard,
            [EnumMember(Value = "ir.export")]
            IrExport,
            [EnumMember(Value = "ir.exports.line")]
            IrExportsLine,
            [EnumMember(Value = "ir.filter")]
            IrFilter,
            [EnumMember(Value = "ir.logging")]
            IrLogging,
            [EnumMember(Value = "ir.mail.server")]
            IrMailServer,
            [EnumMember(Value = "ir.model")]
            IrModel,
            [EnumMember(Value = "ir.model.access")]
            IrModelAccess,
            [EnumMember(Value = "ir.model.constraint")]
            IrModelConstraint,
            [EnumMember(Value = "ir.model.datum")]
            IrModelDatum,
            [EnumMember(Value = "ir.model.field")]
            IrModelField,
            [EnumMember(Value = "ir.model.fields.selection")]
            IrModelFieldsSelection,
            [EnumMember(Value = "ir.model.relation")]
            IrModelRelation,
            [EnumMember(Value = "ir.module.category")]
            IrModuleCategory,
            [EnumMember(Value = "ir.module.module")]
            IrModuleModule,
            [EnumMember(Value = "ir.module.module.dependency")]
            IrModuleModuleDependency,
            [EnumMember(Value = "ir.module.module.exclusion")]
            IrModuleModuleExclusion,
            [EnumMember(Value = "ir.profile")]
            IrProfile,
            [EnumMember(Value = "ir.property")]
            IrProperty,
            [EnumMember(Value = "ir.rule")]
            IrRule,
            [EnumMember(Value = "ir.sequence")]
            IrSequence,
            [EnumMember(Value = "ir.sequence.date.range")]
            IrSequenceDateRange,
            [EnumMember(Value = "ir.server.object.line")]
            IrServerObjectLine,
            [EnumMember(Value = "ir.ui.menu")]
            IrUiMenu,
            [EnumMember(Value = "ir.ui.view")]
            IrUiView,
            [EnumMember(Value = "ir.ui.view.custom")]
            IrUiViewCustom,
            [EnumMember(Value = "link.tracker")]
            LinkTracker,
            [EnumMember(Value = "link.tracker.click")]
            LinkTrackerClick,
            [EnumMember(Value = "link.tracker.code")]
            LinkTrackerCode,
            [EnumMember(Value = "lot.label.layout")]
            LotLabelLayout,
            [EnumMember(Value = "lunch.alert")]
            LunchAlert,
            [EnumMember(Value = "lunch.cashmove")]
            LunchCashmove,
            [EnumMember(Value = "lunch.cashmove.report")]
            LunchCashmoveReport,
            [EnumMember(Value = "lunch.location")]
            LunchLocation,
            [EnumMember(Value = "lunch.order")]
            LunchOrder,
            [EnumMember(Value = "lunch.product")]
            LunchProduct,
            [EnumMember(Value = "lunch.product.category")]
            LunchProductCategory,
            [EnumMember(Value = "lunch.supplier")]
            LunchSupplier,
            [EnumMember(Value = "lunch.topping")]
            LunchTopping,
            [EnumMember(Value = "mail.activity")]
            MailActivity,
            [EnumMember(Value = "mail.activity.type")]
            MailActivityType,
            [EnumMember(Value = "mail.alias")]
            MailAlias,
            [EnumMember(Value = "mail.blacklist")]
            MailBlacklist,
            [EnumMember(Value = "mail.blacklist.remove")]
            MailBlacklistRemove,
            [EnumMember(Value = "mail.channel")]
            MailChannel,
            [EnumMember(Value = "mail.channel.member")]
            MailChannelMember,
            [EnumMember(Value = "mail.channel.rtc.session")]
            MailChannelRtcSession,
            [EnumMember(Value = "mail.compose.message")]
            MailComposeMessage,
            [EnumMember(Value = "mail.follower")]
            MailFollower,
            [EnumMember(Value = "mail.gateway.allowed")]
            MailGatewayAllowed,
            [EnumMember(Value = "mail.guest")]
            MailGuest,
            [EnumMember(Value = "mail.ice.server")]
            MailIceServer,
            [EnumMember(Value = "mail.link.preview")]
            MailLinkPreview,
            [EnumMember(Value = "mail.mail")]
            MailMail,
            [EnumMember(Value = "mail.message")]
            MailMessage,
            [EnumMember(Value = "mail.message.reaction")]
            MailMessageReaction,
            [EnumMember(Value = "mail.message.schedule")]
            MailMessageSchedule,
            [EnumMember(Value = "mail.message.subtype")]
            MailMessageSubtype,
            [EnumMember(Value = "mail.notification")]
            MailNotification,
            [EnumMember(Value = "mail.resend.message")]
            MailResendMessage,
            [EnumMember(Value = "mail.resend.partner")]
            MailResendPartner,
            [EnumMember(Value = "mail.shortcode")]
            MailShortcode,
            [EnumMember(Value = "mail.template")]
            MailTemplate,
            [EnumMember(Value = "mail.template.preview")]
            MailTemplatePreview,
            [EnumMember(Value = "mail.template.reset")]
            MailTemplateReset,
            [EnumMember(Value = "mail.tracking.value")]
            MailTrackingValue,
            [EnumMember(Value = "mail.wizard.invite")]
            MailWizardInvite,
            [EnumMember(Value = "mailing.contact")]
            MailingContact,
            [EnumMember(Value = "mailing.contact.import")]
            MailingContactImport,
            [EnumMember(Value = "mailing.contact.list.rel")]
            MailingContactListRel,
            [EnumMember(Value = "mailing.contact.to.list")]
            MailingContactToList,
            [EnumMember(Value = "mailing.filter")]
            MailingFilter,
            [EnumMember(Value = "mailing.list")]
            MailingList,
            [EnumMember(Value = "mailing.list.merge")]
            MailingListMerge,
            [EnumMember(Value = "mailing.mailing")]
            MailingMailing,
            [EnumMember(Value = "mailing.mailing.schedule.date")]
            MailingMailingScheduleDate,
            [EnumMember(Value = "mailing.mailing.test")]
            MailingMailingTest,
            [EnumMember(Value = "mailing.sms.test")]
            MailingSmsTest,
            [EnumMember(Value = "mailing.trace")]
            MailingTrace,
            [EnumMember(Value = "mailing.trace.report")]
            MailingTraceReport,
            [EnumMember(Value = "maintenance.equipment")]
            MaintenanceEquipment,
            [EnumMember(Value = "maintenance.equipment.category")]
            MaintenanceEquipmentCategory,
            [EnumMember(Value = "maintenance.request")]
            MaintenanceRequest,
            [EnumMember(Value = "maintenance.stage")]
            MaintenanceStage,
            [EnumMember(Value = "maintenance.team")]
            MaintenanceTeam,
            [EnumMember(Value = "mrp.bom")]
            MrpBom,
            [EnumMember(Value = "mrp.bom.byproduct")]
            MrpBomByproduct,
            [EnumMember(Value = "mrp.bom.line")]
            MrpBomLine,
            [EnumMember(Value = "mrp.consumption.warning")]
            MrpConsumptionWarning,
            [EnumMember(Value = "mrp.consumption.warning.line")]
            MrpConsumptionWarningLine,
            [EnumMember(Value = "mrp.document")]
            MrpDocument,
            [EnumMember(Value = "mrp.immediate.production")]
            MrpImmediateProduction,
            [EnumMember(Value = "mrp.immediate.production.line")]
            MrpImmediateProductionLine,
            [EnumMember(Value = "mrp.production")]
            MrpProduction,
            [EnumMember(Value = "mrp.production.backorder")]
            MrpProductionBackorder,
            [EnumMember(Value = "mrp.production.backorder.line")]
            MrpProductionBackorderLine,
            [EnumMember(Value = "mrp.production.split")]
            MrpProductionSplit,
            [EnumMember(Value = "mrp.production.split.line")]
            MrpProductionSplitLine,
            [EnumMember(Value = "mrp.production.split.multi")]
            MrpProductionSplitMulti,
            [EnumMember(Value = "mrp.routing.workcenter")]
            MrpRoutingWorkcenter,
            [EnumMember(Value = "mrp.unbuild")]
            MrpUnbuild,
            [EnumMember(Value = "mrp.workcenter")]
            MrpWorkcenter,
            [EnumMember(Value = "mrp.workcenter.capacity")]
            MrpWorkcenterCapacity,
            [EnumMember(Value = "mrp.workcenter.productivity")]
            MrpWorkcenterProductivity,
            [EnumMember(Value = "mrp.workcenter.productivity.loss")]
            MrpWorkcenterProductivityLoss,
            [EnumMember(Value = "mrp.workcenter.productivity.loss.type")]
            MrpWorkcenterProductivityLossType,
            [EnumMember(Value = "mrp.workcenter.tag")]
            MrpWorkcenterTag,
            [EnumMember(Value = "mrp.workorder")]
            MrpWorkorder,
            [EnumMember(Value = "note.note")]
            NoteNote,
            [EnumMember(Value = "note.stage")]
            NoteStage,
            [EnumMember(Value = "note.tag")]
            NoteTag,
            [EnumMember(Value = "payment.icon")]
            PaymentIcon,
            [EnumMember(Value = "payment.link.wizard")]
            PaymentLinkWizard,
            [EnumMember(Value = "payment.provider")]
            PaymentProvider,
            [EnumMember(Value = "payment.provider.onboarding.wizard")]
            PaymentProviderOnboardingWizard,
            [EnumMember(Value = "payment.refund.wizard")]
            PaymentRefundWizard,
            [EnumMember(Value = "payment.token")]
            PaymentToken,
            [EnumMember(Value = "payment.transaction")]
            PaymentTransaction,
            [EnumMember(Value = "phone.blacklist")]
            PhoneBlacklist,
            [EnumMember(Value = "phone.blacklist.remove")]
            PhoneBlacklistRemove,
            [EnumMember(Value = "picking.label.type")]
            PickingLabelType,
            [EnumMember(Value = "portal.share")]
            PortalShare,
            [EnumMember(Value = "portal.wizard")]
            PortalWizard,
            [EnumMember(Value = "portal.wizard.user")]
            PortalWizardUser,
            [EnumMember(Value = "pos.bill")]
            PosBill,
            [EnumMember(Value = "pos.category")]
            PosCategory,
            [EnumMember(Value = "pos.close.session.wizard")]
            PosCloseSessionWizard,
            [EnumMember(Value = "pos.config")]
            PosConfig,
            [EnumMember(Value = "pos.details.wizard")]
            PosDetailsWizard,
            [EnumMember(Value = "pos.make.payment")]
            PosMakePayment,
            [EnumMember(Value = "pos.order")]
            PosOrder,
            [EnumMember(Value = "pos.order.line")]
            PosOrderLine,
            [EnumMember(Value = "pos.pack.operation.lot")]
            PosPackOperationLot,
            [EnumMember(Value = "pos.payment")]
            PosPayment,
            [EnumMember(Value = "pos.payment.method")]
            PosPaymentMethod,
            [EnumMember(Value = "pos.session")]
            PosSession,
            [EnumMember(Value = "pos.session.check.product.wizard")]
            PosSessionCheckProductWizard,
            [EnumMember(Value = "privacy.log")]
            PrivacyLog,
            [EnumMember(Value = "privacy.lookup.wizard")]
            PrivacyLookupWizard,
            [EnumMember(Value = "privacy.lookup.wizard.line")]
            PrivacyLookupWizardLine,
            [EnumMember(Value = "procurement.group")]
            ProcurementGroup,
            [EnumMember(Value = "product.attribute")]
            ProductAttribute,
            [EnumMember(Value = "product.attribute.custom.value")]
            ProductAttributeCustomValue,
            [EnumMember(Value = "product.attribute.value")]
            ProductAttributeValue,
            [EnumMember(Value = "product.category")]
            ProductCategory,
            [EnumMember(Value = "product.image")]
            ProductImage,
            [EnumMember(Value = "product.label.layout")]
            ProductLabelLayout,
            [EnumMember(Value = "product.packaging")]
            ProductPackaging,
            [EnumMember(Value = "product.pricelist")]
            ProductPricelist,
            [EnumMember(Value = "product.pricelist.item")]
            ProductPricelistItem,
            [EnumMember(Value = "product.product")]
            ProductProduct,
            [EnumMember(Value = "product.public.category")]
            ProductPublicCategory,
            [EnumMember(Value = "product.removal")]
            ProductRemoval,
            [EnumMember(Value = "product.replenish")]
            ProductReplenish,
            [EnumMember(Value = "product.ribbon")]
            ProductRibbon,
            [EnumMember(Value = "product.supplierinfo")]
            ProductSupplierinfo,
            [EnumMember(Value = "product.tag")]
            ProductTag,
            [EnumMember(Value = "product.template")]
            ProductTemplate,
            [EnumMember(Value = "product.template.attribute.exclusion")]
            ProductTemplateAttributeExclusion,
            [EnumMember(Value = "product.template.attribute.line")]
            ProductTemplateAttributeLine,
            [EnumMember(Value = "product.template.attribute.value")]
            ProductTemplateAttributeValue,
            [EnumMember(Value = "project.collaborator")]
            ProjectCollaborator,
            [EnumMember(Value = "project.milestone")]
            ProjectMilestone,
            [EnumMember(Value = "project.project")]
            ProjectProject,
            [EnumMember(Value = "project.project.stage")]
            ProjectProjectStage,
            [EnumMember(Value = "project.share.wizard")]
            ProjectShareWizard,
            [EnumMember(Value = "project.tag")]
            ProjectTag,
            [EnumMember(Value = "project.task")]
            ProjectTask,
            [EnumMember(Value = "project.task.recurrence")]
            ProjectTaskRecurrence,
            [EnumMember(Value = "project.task.type")]
            ProjectTaskType,
            [EnumMember(Value = "project.task.type.delete.wizard")]
            ProjectTaskTypeDeleteWizard,
            [EnumMember(Value = "project.task.user.rel")]
            ProjectTaskUserRel,
            [EnumMember(Value = "project.update")]
            ProjectUpdate,
            [EnumMember(Value = "purchase.bill.union")]
            PurchaseBillUnion,
            [EnumMember(Value = "purchase.order")]
            PurchaseOrder,
            [EnumMember(Value = "purchase.order.line")]
            PurchaseOrderLine,
            [EnumMember(Value = "rating.rating")]
            RatingRating,
            [EnumMember(Value = "registration.editor")]
            RegistrationEditor,
            [EnumMember(Value = "registration.editor.line")]
            RegistrationEditorLine,
            [EnumMember(Value = "repair.fee")]
            RepairFee,
            [EnumMember(Value = "repair.line")]
            RepairLine,
            [EnumMember(Value = "repair.order")]
            RepairOrder,
            [EnumMember(Value = "repair.order.make.invoice")]
            RepairOrderMakeInvoice,
            [EnumMember(Value = "repair.tag")]
            RepairTag,
            [EnumMember(Value = "report.layout")]
            ReportLayout,
            [EnumMember(Value = "report.paperformat")]
            ReportPaperformat,
            [EnumMember(Value = "report.pos.order")]
            ReportPosOrder,
            [EnumMember(Value = "report.project.task.user")]
            ReportProjectTaskUser,
            [EnumMember(Value = "report.stock.quantity")]
            ReportStockQuantity,
            [EnumMember(Value = "res.bank")]
            ResBank,
            [EnumMember(Value = "res.company")]
            ResCompany,
            [EnumMember(Value = "res.config")]
            ResConfig,
            [EnumMember(Value = "res.config.installer")]
            ResConfigInstaller,
            [EnumMember(Value = "res.config.setting")]
            ResConfigSetting,
            [EnumMember(Value = "res.country")]
            ResCountry,
            [EnumMember(Value = "res.country.group")]
            ResCountryGroup,
            [EnumMember(Value = "res.country.state")]
            ResCountryState,
            [EnumMember(Value = "res.currency")]
            ResCurrency,
            [EnumMember(Value = "res.currency.rate")]
            ResCurrencyRate,
            [EnumMember(Value = "res.group")]
            ResGroup,
            [EnumMember(Value = "res.lang")]
            ResLang,
            [EnumMember(Value = "res.partner")]
            ResPartner,
            [EnumMember(Value = "res.partner.autocomplete.sync")]
            ResPartnerAutocompleteSync,
            [EnumMember(Value = "res.partner.bank")]
            ResPartnerBank,
            [EnumMember(Value = "res.partner.category")]
            ResPartnerCategory,
            [EnumMember(Value = "res.partner.industry")]
            ResPartnerIndustry,
            [EnumMember(Value = "res.partner.title")]
            ResPartnerTitle,
            [EnumMember(Value = "res.user")]
            ResUser,
            [EnumMember(Value = "res.users.apikey")]
            ResUsersApikey,
            [EnumMember(Value = "res.users.apikeys.description")]
            ResUsersApikeysDescription,
            [EnumMember(Value = "res.users.deletion")]
            ResUsersDeletion,
            [EnumMember(Value = "res.users.identitycheck")]
            ResUsersIdentitycheck,
            [EnumMember(Value = "res.users.log")]
            ResUsersLog,
            [EnumMember(Value = "res.users.setting")]
            ResUsersSetting,
            [EnumMember(Value = "res.users.settings.volume")]
            ResUsersSettingsVolume,
            [EnumMember(Value = "reset.view.arch.wizard")]
            ResetViewArchWizard,
            [EnumMember(Value = "resource.calendar")]
            ResourceCalendar,
            [EnumMember(Value = "resource.calendar.attendance")]
            ResourceCalendarAttendance,
            [EnumMember(Value = "resource.calendar.leaf")]
            ResourceCalendarLeaf,
            [EnumMember(Value = "resource.resource")]
            ResourceResource,
            [EnumMember(Value = "sale.advance.payment.inv")]
            SaleAdvancePaymentInv,
            [EnumMember(Value = "sale.order")]
            SaleOrder,
            [EnumMember(Value = "sale.order.cancel")]
            SaleOrderCancel,
            [EnumMember(Value = "sale.order.line")]
            SaleOrderLine,
            [EnumMember(Value = "sale.order.option")]
            SaleOrderOption,
            [EnumMember(Value = "sale.order.template")]
            SaleOrderTemplate,
            [EnumMember(Value = "sale.order.template.line")]
            SaleOrderTemplateLine,
            [EnumMember(Value = "sale.order.template.option")]
            SaleOrderTemplateOption,
            [EnumMember(Value = "sale.payment.provider.onboarding.wizard")]
            SalePaymentProviderOnboardingWizard,
            [EnumMember(Value = "slide.answer")]
            SlideAnswer,
            [EnumMember(Value = "slide.channel")]
            SlideChannel,
            [EnumMember(Value = "slide.channel.invite")]
            SlideChannelInvite,
            [EnumMember(Value = "slide.channel.partner")]
            SlideChannelPartner,
            [EnumMember(Value = "slide.channel.tag")]
            SlideChannelTag,
            [EnumMember(Value = "slide.channel.tag.group")]
            SlideChannelTagGroup,
            [EnumMember(Value = "slide.embed")]
            SlideEmbed,
            [EnumMember(Value = "slide.question")]
            SlideQuestion,
            [EnumMember(Value = "slide.slide")]
            SlideSlide,
            [EnumMember(Value = "slide.slide.partner")]
            SlideSlidePartner,
            [EnumMember(Value = "slide.slide.resource")]
            SlideSlideResource,
            [EnumMember(Value = "slide.tag")]
            SlideTag,
            [EnumMember(Value = "sms.composer")]
            SmsComposer,
            [EnumMember(Value = "sms.resend")]
            SmsResend,
            [EnumMember(Value = "sms.resend.recipient")]
            SmsResendRecipient,
            [EnumMember(Value = "sms.sm")]
            SmsSm,
            [EnumMember(Value = "sms.template")]
            SmsTemplate,
            [EnumMember(Value = "sms.template.preview")]
            SmsTemplatePreview,
            [EnumMember(Value = "sms.template.reset")]
            SmsTemplateReset,
            [EnumMember(Value = "snailmail.confirm.invoice")]
            SnailmailConfirmInvoice,
            [EnumMember(Value = "snailmail.letter")]
            SnailmailLetter,
            [EnumMember(Value = "snailmail.letter.format.error")]
            SnailmailLetterFormatError,
            [EnumMember(Value = "snailmail.letter.missing.required.field")]
            SnailmailLetterMissingRequiredField,
            [EnumMember(Value = "spreadsheet.dashboard")]
            SpreadsheetDashboard,
            [EnumMember(Value = "spreadsheet.dashboard.group")]
            SpreadsheetDashboardGroup,
            [EnumMember(Value = "stock.assign.serial")]
            StockAssignSerial,
            [EnumMember(Value = "stock.backorder.confirmation")]
            StockBackorderConfirmation,
            [EnumMember(Value = "stock.backorder.confirmation.line")]
            StockBackorderConfirmationLine,
            [EnumMember(Value = "stock.change.product.qty")]
            StockChangeProductQty,
            [EnumMember(Value = "stock.immediate.transfer")]
            StockImmediateTransfer,
            [EnumMember(Value = "stock.immediate.transfer.line")]
            StockImmediateTransferLine,
            [EnumMember(Value = "stock.inventory.adjustment.name")]
            StockInventoryAdjustmentName,
            [EnumMember(Value = "stock.inventory.conflict")]
            StockInventoryConflict,
            [EnumMember(Value = "stock.inventory.warning")]
            StockInventoryWarning,
            [EnumMember(Value = "stock.location")]
            StockLocation,
            [EnumMember(Value = "stock.lot")]
            StockLot,
            [EnumMember(Value = "stock.move")]
            StockMove,
            [EnumMember(Value = "stock.move.line")]
            StockMoveLine,
            [EnumMember(Value = "stock.orderpoint.snooze")]
            StockOrderpointSnooze,
            [EnumMember(Value = "stock.package.destination")]
            StockPackageDestination,
            [EnumMember(Value = "stock.package.level")]
            StockPackageLevel,
            [EnumMember(Value = "stock.package.type")]
            StockPackageType,
            [EnumMember(Value = "stock.picking")]
            StockPicking,
            [EnumMember(Value = "stock.picking.type")]
            StockPickingType,
            [EnumMember(Value = "stock.putaway.rule")]
            StockPutawayRule,
            [EnumMember(Value = "stock.quant")]
            StockQuant,
            [EnumMember(Value = "stock.quant.package")]
            StockQuantPackage,
            [EnumMember(Value = "stock.quantity.history")]
            StockQuantityHistory,
            [EnumMember(Value = "stock.replenishment.info")]
            StockReplenishmentInfo,
            [EnumMember(Value = "stock.replenishment.option")]
            StockReplenishmentOption,
            [EnumMember(Value = "stock.request.count")]
            StockRequestCount,
            [EnumMember(Value = "stock.return.picking")]
            StockReturnPicking,
            [EnumMember(Value = "stock.return.picking.line")]
            StockReturnPickingLine,
            [EnumMember(Value = "stock.route")]
            StockRoute,
            [EnumMember(Value = "stock.rule")]
            StockRule,
            [EnumMember(Value = "stock.rules.report")]
            StockRulesReport,
            [EnumMember(Value = "stock.scheduler.compute")]
            StockSchedulerCompute,
            [EnumMember(Value = "stock.scrap")]
            StockScrap,
            [EnumMember(Value = "stock.storage.category")]
            StockStorageCategory,
            [EnumMember(Value = "stock.storage.category.capacity")]
            StockStorageCategoryCapacity,
            [EnumMember(Value = "stock.traceability.report")]
            StockTraceabilityReport,
            [EnumMember(Value = "stock.track.confirmation")]
            StockTrackConfirmation,
            [EnumMember(Value = "stock.track.line")]
            StockTrackLine,
            [EnumMember(Value = "stock.valuation.layer")]
            StockValuationLayer,
            [EnumMember(Value = "stock.valuation.layer.revaluation")]
            StockValuationLayerRevaluation,
            [EnumMember(Value = "stock.warehouse")]
            StockWarehouse,
            [EnumMember(Value = "stock.warehouse.orderpoint")]
            StockWarehouseOrderpoint,
            [EnumMember(Value = "stock.warn.insufficient.qty.repair")]
            StockWarnInsufficientQtyRepair,
            [EnumMember(Value = "stock.warn.insufficient.qty.scrap")]
            StockWarnInsufficientQtyScrap,
            [EnumMember(Value = "stock.warn.insufficient.qty.unbuild")]
            StockWarnInsufficientQtyUnbuild,
            [EnumMember(Value = "survey.invite")]
            SurveyInvite,
            [EnumMember(Value = "survey.question")]
            SurveyQuestion,
            [EnumMember(Value = "survey.question.answer")]
            SurveyQuestionAnswer,
            [EnumMember(Value = "survey.survey")]
            SurveySurvey,
            [EnumMember(Value = "survey.user.input")]
            SurveyUserInput,
            [EnumMember(Value = "survey.user.input.line")]
            SurveyUserInputLine,
            [EnumMember(Value = "theme.ir.asset")]
            ThemeIrAsset,
            [EnumMember(Value = "theme.ir.attachment")]
            ThemeIrAttachment,
            [EnumMember(Value = "theme.ir.ui.view")]
            ThemeIrUiView,
            [EnumMember(Value = "theme.website.menu")]
            ThemeWebsiteMenu,
            [EnumMember(Value = "theme.website.page")]
            ThemeWebsitePage,
            [EnumMember(Value = "uom.category")]
            UomCategory,
            [EnumMember(Value = "uom.uom")]
            UomUom,
            [EnumMember(Value = "utm.campaign")]
            UtmCampaign,
            [EnumMember(Value = "utm.medium")]
            UtmMedium,
            [EnumMember(Value = "utm.source")]
            UtmSource,
            [EnumMember(Value = "utm.stage")]
            UtmStage,
            [EnumMember(Value = "utm.tag")]
            UtmTag,
            [EnumMember(Value = "validate.account.move")]
            ValidateAccountMove,
            [EnumMember(Value = "vendor.delay.report")]
            VendorDelayReport,
            [EnumMember(Value = "web.editor.converter.test")]
            WebEditorConverterTest,
            [EnumMember(Value = "web.editor.converter.test.sub")]
            WebEditorConverterTestSub,
            [EnumMember(Value = "web.tour.tour")]
            WebTourTour,
            [EnumMember(Value = "website")]
            Website,
            [EnumMember(Value = "website.base.unit")]
            WebsiteBaseUnit,
            [EnumMember(Value = "website.configurator.feature")]
            WebsiteConfiguratorFeature,
            [EnumMember(Value = "website.event.menu")]
            WebsiteEventMenu,
            [EnumMember(Value = "website.menu")]
            WebsiteMenu,
            [EnumMember(Value = "website.page")]
            WebsitePage,
            [EnumMember(Value = "website.rewrite")]
            WebsiteRewrite,
            [EnumMember(Value = "website.robot")]
            WebsiteRobot,
            [EnumMember(Value = "website.route")]
            WebsiteRoute,
            [EnumMember(Value = "website.sale.extra.field")]
            WebsiteSaleExtraField,
            [EnumMember(Value = "website.snippet.filter")]
            WebsiteSnippetFilter,
            [EnumMember(Value = "website.track")]
            WebsiteTrack,
            [EnumMember(Value = "website.visitor")]
            WebsiteVisitor,

        }
    }
}
