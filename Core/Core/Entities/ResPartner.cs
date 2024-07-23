using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ResPartner
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Name { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public int? Title { get; set; }

    /// <summary>
    /// Related Company
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public int? StateId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Industry
    /// </summary>
    public int? IndustryId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Commercial Entity
    /// </summary>
    public int? CommercialPartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Display Name
    /// </summary>
    public string? DisplayName { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public string? Ref { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Timezone
    /// </summary>
    public string? Tz { get; set; }

    /// <summary>
    /// Tax ID
    /// </summary>
    public string? Vat { get; set; }

    /// <summary>
    /// Company ID
    /// </summary>
    public string? CompanyRegistry { get; set; }

    /// <summary>
    /// Website Link
    /// </summary>
    public string? Website { get; set; }

    /// <summary>
    /// Job Position
    /// </summary>
    public string? Function { get; set; }

    /// <summary>
    /// Address Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Street
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// Street2
    /// </summary>
    public string? Street2 { get; set; }

    /// <summary>
    /// Zip
    /// </summary>
    public string? Zip { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

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
    /// Company Name Entity
    /// </summary>
    public string? CommercialCompanyName { get; set; }

    /// <summary>
    /// Company Name
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Geo Latitude
    /// </summary>
    public decimal? PartnerLatitude { get; set; }

    /// <summary>
    /// Geo Longitude
    /// </summary>
    public decimal? PartnerLongitude { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public bool? Employee { get; set; }

    /// <summary>
    /// Is a Company
    /// </summary>
    public bool? IsCompany { get; set; }

    /// <summary>
    /// Share Partner
    /// </summary>
    public bool? PartnerShare { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Bounce
    /// </summary>
    public int? MessageBounce { get; set; }

    /// <summary>
    /// Normalized Email
    /// </summary>
    public string? EmailNormalized { get; set; }

    /// <summary>
    /// Signup Token
    /// </summary>
    public string? SignupToken { get; set; }

    /// <summary>
    /// Signup Token Type
    /// </summary>
    public string? SignupType { get; set; }

    /// <summary>
    /// Signup Expiration
    /// </summary>
    public DateTime? SignupExpiration { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? TeamId { get; set; }

    /// <summary>
    /// Company database ID
    /// </summary>
    public int? PartnerGid { get; set; }

    /// <summary>
    /// Additional info
    /// </summary>
    public string? AdditionalInfo { get; set; }

    /// <summary>
    /// Sanitized Number
    /// </summary>
    public string? PhoneSanitized { get; set; }

    /// <summary>
    /// Supplier Rank
    /// </summary>
    public int? SupplierRank { get; set; }

    /// <summary>
    /// Customer Rank
    /// </summary>
    public int? CustomerRank { get; set; }

    /// <summary>
    /// Invoice
    /// </summary>
    public string? InvoiceWarn { get; set; }

    /// <summary>
    /// Message for Invoice
    /// </summary>
    public string? InvoiceWarnMsg { get; set; }

    /// <summary>
    /// Payable Limit
    /// </summary>
    public decimal? DebitLimit { get; set; }

    /// <summary>
    /// Latest Invoices &amp; Payments Matching Date
    /// </summary>
    public DateTime? LastTimeEntriesChecked { get; set; }

    /// <summary>
    /// Sales Warnings
    /// </summary>
    public string? SaleWarn { get; set; }

    /// <summary>
    /// Message for Sales Order
    /// </summary>
    public string? SaleWarnMsg { get; set; }

    /// <summary>
    /// Last notification marked as read from base Calendar
    /// </summary>
    public DateTime? CalendarLastNotifAck { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Stock Picking
    /// </summary>
    public string? PickingWarn { get; set; }

    /// <summary>
    /// Message for Stock Picking
    /// </summary>
    public string? PickingWarnMsg { get; set; }

    /// <summary>
    /// Purchase Order
    /// </summary>
    public string? PurchaseWarn { get; set; }

    /// <summary>
    /// Message for Purchase Order
    /// </summary>
    public string? PurchaseWarnMsg { get; set; }

    /// <summary>
    /// Plan To Change Car
    /// </summary>
    public bool? PlanToChangeCar { get; set; }

    /// <summary>
    /// Plan To Change Bike
    /// </summary>
    public bool? PlanToChangeBike { get; set; }

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
    /// Website Partner Full Description
    /// </summary>
    public string? WebsiteDescription { get; set; }

    /// <summary>
    /// Website Partner Short Description
    /// </summary>
    public string? WebsiteShortDescription { get; set; }

    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; set; } = new List<AccountAnalyticAccount>();

    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; set; } = new List<AccountAnalyticDistributionModel>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; set; } = new List<AccountBankStatementLine>();

    public virtual ICollection<AccountMove> AccountMoveCommercialPartners { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMove> AccountMovePartnerShippings { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountMove> AccountMovePartners { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappings { get; set; } = new List<AccountReconcileModelPartnerMapping>();

    public virtual ICollection<ApplicantSendMail> ApplicantSendMails { get; set; } = new List<ApplicantSendMail>();

    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizards { get; set; } = new List<BasePartnerMergeAutomaticWizard>();

    public virtual ICollection<CalendarAttendee> CalendarAttendees { get; set; } = new List<CalendarAttendee>();

    public virtual ICollection<CalendarFilter> CalendarFilters { get; set; } = new List<CalendarFilter>();

    public virtual ICollection<ChatbotScript> ChatbotScripts { get; set; } = new List<ChatbotScript>();

    public virtual ResPartner? CommercialPartner { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; set; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartners { get; set; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ICollection<CrmQuotationPartner> CrmQuotationPartners { get; set; } = new List<CrmQuotationPartner>();

    public virtual ICollection<EventEvent> EventEventAddresses { get; set; } = new List<EventEvent>();

    public virtual ICollection<EventEvent> EventEventOrganizers { get; set; } = new List<EventEvent>();

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogs { get; set; } = new List<FleetVehicleAssignationLog>();

    public virtual ICollection<FleetVehicle> FleetVehicleDrivers { get; set; } = new List<FleetVehicle>();

    public virtual ICollection<FleetVehicle> FleetVehicleFutureDrivers { get; set; } = new List<FleetVehicle>();

    public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; set; } = new List<FleetVehicleLogContract>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServicePurchasers { get; set; } = new List<FleetVehicleLogService>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServiceVendors { get; set; } = new List<FleetVehicleLogService>();

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrEmployee> HrEmployeeAddressHomes { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> HrEmployeeAddresses { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> HrEmployeeWorkContacts { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrWorkLocation> HrWorkLocations { get; set; } = new List<HrWorkLocation>();

    public virtual ResPartnerIndustry? Industry { get; set; }

    public virtual ICollection<ResPartner> InverseCommercialPartner { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResPartner> InverseParent { get; set; } = new List<ResPartner>();

    public virtual ICollection<LunchSupplier> LunchSuppliers { get; set; } = new List<LunchSupplier>();

    public virtual ICollection<MailActivity> MailActivities { get; set; } = new List<MailActivity>();

    public virtual ICollection<MailChannelMember> MailChannelMembers { get; set; } = new List<MailChannelMember>();

    public virtual ICollection<MailChannel> MailChannels { get; set; } = new List<MailChannel>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailFollower> MailFollowers { get; set; } = new List<MailFollower>();

    public virtual ICollection<MailMessageReaction> MailMessageReactions { get; set; } = new List<MailMessageReaction>();

    public virtual ICollection<MailMessage> MailMessages { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailNotification> MailNotificationAuthors { get; set; } = new List<MailNotification>();

    public virtual ICollection<MailNotification> MailNotificationResPartners { get; set; } = new List<MailNotification>();

    public virtual ICollection<MailResendPartner> MailResendPartners { get; set; } = new List<MailResendPartner>();

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; set; } = new List<MaintenanceEquipment>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Parent { get; set; }

    public virtual ICollection<PaymentLinkWizard> PaymentLinkWizards { get; set; } = new List<PaymentLinkWizard>();

    public virtual ICollection<PaymentToken> PaymentTokens { get; set; } = new List<PaymentToken>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual ICollection<PortalWizardUser> PortalWizardUsers { get; set; } = new List<PortalWizardUser>();

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<ProcurementGroup> ProcurementGroups { get; set; } = new List<ProcurementGroup>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<ProjectCollaborator> ProjectCollaborators { get; set; } = new List<ProjectCollaborator>();

    public virtual ICollection<ProjectProject> ProjectProjects { get; set; } = new List<ProjectProject>();

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual ICollection<PurchaseOrder> PurchaseOrderDestAddresses { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<PurchaseOrder> PurchaseOrderPartners { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<RatingRating> RatingRatingPartners { get; set; } = new List<RatingRating>();

    public virtual ICollection<RatingRating> RatingRatingPublishers { get; set; } = new List<RatingRating>();

    public virtual ICollection<RatingRating> RatingRatingRatedPartners { get; set; } = new List<RatingRating>();

    public virtual ICollection<RepairOrder> RepairOrderAddresses { get; set; } = new List<RepairOrder>();

    public virtual ICollection<RepairOrder> RepairOrderPartnerInvoices { get; set; } = new List<RepairOrder>();

    public virtual ICollection<RepairOrder> RepairOrderPartners { get; set; } = new List<RepairOrder>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResPartnerAutocompleteSync> ResPartnerAutocompleteSyncs { get; set; } = new List<ResPartnerAutocompleteSync>();

    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumeGuests { get; set; } = new List<ResUsersSettingsVolume>();

    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumePartners { get; set; } = new List<ResUsersSettingsVolume>();

    public virtual ICollection<SaleOrderCancel> SaleOrderCancels { get; set; } = new List<SaleOrderCancel>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrder> SaleOrderPartnerInvoices { get; set; } = new List<SaleOrder>();

    public virtual ICollection<SaleOrder> SaleOrderPartnerShippings { get; set; } = new List<SaleOrder>();

    public virtual ICollection<SaleOrder> SaleOrderPartners { get; set; } = new List<SaleOrder>();

    public virtual ICollection<SlideChannelPartner> SlideChannelPartners { get; set; } = new List<SlideChannelPartner>();

    public virtual ICollection<SlideSlidePartner> SlideSlidePartners { get; set; } = new List<SlideSlidePartner>();

    public virtual ICollection<SmsSm> SmsSms { get; set; } = new List<SmsSm>();

    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; set; } = new List<SnailmailLetterMissingRequiredField>();

    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; set; } = new List<SnailmailLetter>();

    public virtual ResCountryState? State { get; set; }

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMovePartners { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMoveRestrictPartners { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPicking> StockPickingOwners { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockPicking> StockPickingPartners { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockRule> StockRules { get; set; } = new List<StockRule>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehouses { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<SurveyInvite> SurveyInvites { get; set; } = new List<SurveyInvite>();

    public virtual ICollection<SurveyUserInput> SurveyUserInputs { get; set; } = new List<SurveyUserInput>();

    public virtual CrmTeam? Team { get; set; }

    public virtual ResPartnerTitle? TitleNavigation { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual Website? WebsiteNavigation { get; set; }

    public virtual ICollection<WebsiteVisitor> WebsiteVisitorLivechatOperators { get; set; } = new List<WebsiteVisitor>();

    public virtual ICollection<WebsiteVisitor> WebsiteVisitorPartners { get; set; } = new List<WebsiteVisitor>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; set; } = new List<AccountReconcileModelTemplate>();

    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; set; } = new List<AccountReconcileModel>();

    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizardsNavigation { get; set; } = new List<BasePartnerMergeAutomaticWizard>();

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();

    public virtual ICollection<ResPartnerCategory> Categories { get; set; } = new List<ResPartnerCategory>();

    public virtual ICollection<SurveyInvite> Invites { get; set; } = new List<SurveyInvite>();

    public virtual ICollection<IrActServer> IrActServers { get; set; } = new List<IrActServer>();

    public virtual ICollection<MailMail> MailMails { get; set; } = new List<MailMail>();

    public virtual ICollection<MailMessage> MailMessages1 { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailMessage> MailMessagesNavigation { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailWizardInvite> MailWizardInvites { get; set; } = new List<MailWizardInvite>();

    public virtual ICollection<FleetVehicleModel> Models { get; set; } = new List<FleetVehicleModel>();

    public virtual ICollection<PortalShare> PortalShares { get; set; } = new List<PortalShare>();

    public virtual ICollection<PortalWizard> PortalWizards { get; set; } = new List<PortalWizard>();

    public virtual ICollection<ProductProduct> ProductProducts { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProjectShareWizard> ProjectShareWizards { get; set; } = new List<ProjectShareWizard>();

    public virtual ICollection<SlideChannelInvite> SlideChannelInvites { get; set; } = new List<SlideChannelInvite>();

    public virtual ICollection<MailComposeMessage> Wizards { get; set; } = new List<MailComposeMessage>();
}
