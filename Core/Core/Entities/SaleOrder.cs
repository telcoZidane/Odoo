using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sales Order
/// </summary>
public partial class SaleOrder
{
    public int Id { get; set; }

    /// <summary>
    /// Campaign
    /// </summary>
    public int? CampaignId { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public int? SourceId { get; set; }

    /// <summary>
    /// Medium
    /// </summary>
    public int? MediumId { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Invoice Address
    /// </summary>
    public int PartnerInvoiceId { get; set; }

    /// <summary>
    /// Delivery Address
    /// </summary>
    public int PartnerShippingId { get; set; }

    /// <summary>
    /// Fiscal Position
    /// </summary>
    public int? FiscalPositionId { get; set; }

    /// <summary>
    /// Payment Terms
    /// </summary>
    public int? PaymentTermId { get; set; }

    /// <summary>
    /// Pricelist
    /// </summary>
    public int PricelistId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? TeamId { get; set; }

    /// <summary>
    /// Analytic Account
    /// </summary>
    public int? AnalyticAccountId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Security Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Order Reference
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Customer Reference
    /// </summary>
    public string? ClientOrderRef { get; set; }

    /// <summary>
    /// Source Document
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// Payment Ref.
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// Signed By
    /// </summary>
    public string? SignedBy { get; set; }

    /// <summary>
    /// Invoice Status
    /// </summary>
    public string? InvoiceStatus { get; set; }

    /// <summary>
    /// Expiration
    /// </summary>
    public DateOnly? ValidityDate { get; set; }

    /// <summary>
    /// Terms and conditions
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Currency Rate
    /// </summary>
    public decimal? CurrencyRate { get; set; }

    /// <summary>
    /// Untaxed Amount
    /// </summary>
    public decimal? AmountUntaxed { get; set; }

    /// <summary>
    /// Taxes
    /// </summary>
    public decimal? AmountTax { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public decimal? AmountTotal { get; set; }

    /// <summary>
    /// Online Signature
    /// </summary>
    public bool? RequireSignature { get; set; }

    /// <summary>
    /// Online Payment
    /// </summary>
    public bool? RequirePayment { get; set; }

    /// <summary>
    /// Creation Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Delivery Date
    /// </summary>
    public DateTime? CommitmentDate { get; set; }

    /// <summary>
    /// Order Date
    /// </summary>
    public DateTime DateOrder { get; set; }

    /// <summary>
    /// Signed On
    /// </summary>
    public DateTime? SignedOn { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public int? SaleOrderTemplateId { get; set; }

    /// <summary>
    /// Project
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// Opportunity
    /// </summary>
    public int? OpportunityId { get; set; }

    /// <summary>
    /// Incoterm
    /// </summary>
    public int? Incoterm { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int WarehouseId { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? ProcurementGroupId { get; set; }

    /// <summary>
    /// Incoterm Location
    /// </summary>
    public string? IncotermLocation { get; set; }

    /// <summary>
    /// Shipping Policy
    /// </summary>
    public string PickingPolicy { get; set; } = null!;

    /// <summary>
    /// Delivery Status
    /// </summary>
    public string? DeliveryStatus { get; set; }

    /// <summary>
    /// Effective Date
    /// </summary>
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    /// Unpaid Amount
    /// </summary>
    public decimal? AmountUnpaid { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Warning
    /// </summary>
    public string? ShopWarning { get; set; }

    /// <summary>
    /// Cart recovery email already sent
    /// </summary>
    public bool? CartRecoveryEmailSent { get; set; }

    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; set; } = new List<HrExpenseSplit>();

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();

    public virtual AccountIncoterm? IncotermNavigation { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual CrmLead? Opportunity { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResPartner PartnerInvoice { get; set; } = null!;

    public virtual ResPartner PartnerShipping { get; set; } = null!;

    public virtual AccountPaymentTerm? PaymentTerm { get; set; }

    public virtual ICollection<PosOrderLine> PosOrderLines { get; set; } = new List<PosOrderLine>();

    public virtual ProductPricelist Pricelist { get; set; } = null!;

    public virtual ProcurementGroup? ProcurementGroup { get; set; }

    public virtual ICollection<ProcurementGroup> ProcurementGroups { get; set; } = new List<ProcurementGroup>();

    public virtual ProjectProject? Project { get; set; }

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<RegistrationEditor> RegistrationEditors { get; set; } = new List<RegistrationEditor>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ICollection<SaleOrderCancel> SaleOrderCancels { get; set; } = new List<SaleOrderCancel>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; set; } = new List<SaleOrderOption>();

    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    public virtual UtmSource? Source { get; set; }

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual StockWarehouse Warehouse { get; set; } = null!;

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; set; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<CrmTag> Tags { get; set; } = new List<CrmTag>();

    public virtual ICollection<PaymentTransaction> Transactions { get; set; } = new List<PaymentTransaction>();
}
