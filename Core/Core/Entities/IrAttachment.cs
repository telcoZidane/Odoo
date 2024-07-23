using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Attachment
/// </summary>
public partial class IrAttachment
{
    public int Id { get; set; }

    /// <summary>
    /// Resource ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// File Size
    /// </summary>
    public int? FileSize { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Resource Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Resource Field
    /// </summary>
    public string? ResField { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Url
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Access Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Stored Filename
    /// </summary>
    public string? StoreFname { get; set; }

    /// <summary>
    /// Checksum/SHA1
    /// </summary>
    public string? Checksum { get; set; }

    /// <summary>
    /// Mime Type
    /// </summary>
    public string? Mimetype { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Indexed Content
    /// </summary>
    public string? IndexContent { get; set; }

    /// <summary>
    /// Is public document
    /// </summary>
    public bool? Public { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Database Data
    /// </summary>
    public byte[]? DbDatas { get; set; }

    /// <summary>
    /// Original (unoptimized, unresized) attachment
    /// </summary>
    public int? OriginalId { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Theme Template
    /// </summary>
    public int? ThemeTemplateId { get; set; }

    /// <summary>
    /// Key
    /// </summary>
    public string? Key { get; set; }

    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; set; } = new List<AccountAccountTemplate>();

    public virtual ICollection<AccountAccount> AccountAccounts { get; set; } = new List<AccountAccount>();

    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; set; } = new List<AccountAnalyticAccount>();

    public virtual ICollection<AccountEdiDocument> AccountEdiDocuments { get; set; } = new List<AccountEdiDocument>();

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; set; } = new List<AccountReconcileModel>();

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ICollection<CrmTeamMember> CrmTeamMembers { get; set; } = new List<CrmTeamMember>();

    public virtual ICollection<CrmTeam> CrmTeams { get; set; } = new List<CrmTeam>();

    public virtual ICollection<EventEvent> EventEvents { get; set; } = new List<EventEvent>();

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; set; } = new List<FleetVehicleLogContract>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; set; } = new List<FleetVehicleLogService>();

    public virtual ICollection<FleetVehicle> FleetVehicles { get; set; } = new List<FleetVehicle>();

    public virtual ICollection<GamificationBadge> GamificationBadges { get; set; } = new List<GamificationBadge>();

    public virtual ICollection<GamificationChallenge> GamificationChallenges { get; set; } = new List<GamificationChallenge>();

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrContract> HrContracts { get; set; } = new List<HrContract>();

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeaveType> HrLeaveTypes { get; set; } = new List<HrLeaveType>();

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();

    public virtual ICollection<IrAttachment> InverseOriginal { get; set; } = new List<IrAttachment>();

    public virtual ICollection<LunchSupplier> LunchSuppliers { get; set; } = new List<LunchSupplier>();

    public virtual ICollection<MailBlacklist> MailBlacklists { get; set; } = new List<MailBlacklist>();

    public virtual ICollection<MailChannel> MailChannels { get; set; } = new List<MailChannel>();

    public virtual ICollection<MailingContact> MailingContacts { get; set; } = new List<MailingContact>();

    public virtual ICollection<MailingMailing> MailingMailings { get; set; } = new List<MailingMailing>();

    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategories { get; set; } = new List<MaintenanceEquipmentCategory>();

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; set; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();

    public virtual ICollection<MrpBom> MrpBoms { get; set; } = new List<MrpBom>();

    public virtual ICollection<MrpDocument> MrpDocuments { get; set; } = new List<MrpDocument>();

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; set; } = new List<MrpUnbuild>();

    public virtual ICollection<NoteNote> NoteNotes { get; set; } = new List<NoteNote>();

    public virtual IrAttachment? Original { get; set; }

    public virtual ICollection<PhoneBlacklist> PhoneBlacklists { get; set; } = new List<PhoneBlacklist>();

    public virtual ICollection<PosSession> PosSessions { get; set; } = new List<PosSession>();

    public virtual ICollection<ProductProduct> ProductProducts { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; set; } = new List<ProjectMilestone>();

    public virtual ICollection<ProjectProject> ProjectProjects { get; set; } = new List<ProjectProject>();

    public virtual ICollection<ProjectTask> ProjectTaskDisplayedImages { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTask> ProjectTaskMessageMainAttachments { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectUpdate> ProjectUpdates { get; set; } = new List<ProjectUpdate>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ICollection<SlideChannel> SlideChannels { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SlideSlide> SlideSlides { get; set; } = new List<SlideSlide>();

    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; set; } = new List<SnailmailLetter>();

    public virtual ICollection<StockLot> StockLots { get; set; } = new List<StockLot>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual ICollection<SurveySurvey> SurveySurveys { get; set; } = new List<SurveySurvey>();

    public virtual ICollection<SurveyUserInput> SurveyUserInputs { get; set; } = new List<SurveyUserInput>();

    public virtual ThemeIrAttachment? ThemeTemplate { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountBankStatement> AccountBankStatements { get; set; } = new List<AccountBankStatement>();

    public virtual ICollection<AccountTourUploadBill> AccountTourUploadBills { get; set; } = new List<AccountTourUploadBill>();

    public virtual ICollection<MailTemplate> EmailTemplates { get; set; } = new List<MailTemplate>();

    public virtual ICollection<MailingMailing> MassMailings { get; set; } = new List<MailingMailing>();

    public virtual ICollection<MailMessage> Messages { get; set; } = new List<MailMessage>();

    public virtual ICollection<SlideChannelInvite> SlideChannelInvites { get; set; } = new List<SlideChannelInvite>();

    public virtual ICollection<MailComposeMessage> Wizards { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<SurveyInvite> WizardsNavigation { get; set; } = new List<SurveyInvite>();
}
