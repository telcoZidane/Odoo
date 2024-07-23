using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sales Order Line
/// </summary>
public partial class SaleOrderLine
{
    public int Id { get; set; }

    /// <summary>
    /// Order Reference
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? OrderPartnerId { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? SalesmanId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int? ProductUom { get; set; }

    /// <summary>
    /// Packaging
    /// </summary>
    public int? ProductPackagingId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Order Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Display Type
    /// </summary>
    public string? DisplayType { get; set; }

    /// <summary>
    /// Method to update delivered qty
    /// </summary>
    public string? QtyDeliveredMethod { get; set; }

    /// <summary>
    /// Invoice Status
    /// </summary>
    public string? InvoiceStatus { get; set; }

    /// <summary>
    /// Analytic
    /// </summary>
    public string? AnalyticDistribution { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductUomQty { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public decimal PriceUnit { get; set; }

    /// <summary>
    /// Discount (%)
    /// </summary>
    public decimal? Discount { get; set; }

    /// <summary>
    /// Price Reduce
    /// </summary>
    public decimal? PriceReduce { get; set; }

    /// <summary>
    /// Subtotal
    /// </summary>
    public decimal? PriceSubtotal { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public decimal? PriceTotal { get; set; }

    /// <summary>
    /// Price Reduce Tax excl
    /// </summary>
    public decimal? PriceReduceTaxexcl { get; set; }

    /// <summary>
    /// Price Reduce Tax incl
    /// </summary>
    public decimal? PriceReduceTaxinc { get; set; }

    /// <summary>
    /// Delivery Quantity
    /// </summary>
    public decimal? QtyDelivered { get; set; }

    /// <summary>
    /// Invoiced Quantity
    /// </summary>
    public decimal? QtyInvoiced { get; set; }

    /// <summary>
    /// Quantity To Invoice
    /// </summary>
    public decimal? QtyToInvoice { get; set; }

    /// <summary>
    /// Untaxed Invoiced Amount
    /// </summary>
    public decimal? UntaxedAmountInvoiced { get; set; }

    /// <summary>
    /// Untaxed Amount To Invoice
    /// </summary>
    public decimal? UntaxedAmountToInvoice { get; set; }

    /// <summary>
    /// Is a down payment
    /// </summary>
    public bool? IsDownpayment { get; set; }

    /// <summary>
    /// Is expense
    /// </summary>
    public bool? IsExpense { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Total Tax
    /// </summary>
    public double? PriceTax { get; set; }

    /// <summary>
    /// Packaging Quantity
    /// </summary>
    public double? ProductPackagingQty { get; set; }

    /// <summary>
    /// Lead Time
    /// </summary>
    public double CustomerLead { get; set; }

    public bool? IsService { get; set; }

    /// <summary>
    /// Generated Project
    /// </summary>
    public int? ProjectId { get; set; }

    /// <summary>
    /// Generated Task
    /// </summary>
    public int? TaskId { get; set; }

    /// <summary>
    /// Route
    /// </summary>
    public int? RouteId { get; set; }

    /// <summary>
    /// Linked Order Line
    /// </summary>
    public int? LinkedLineId { get; set; }

    /// <summary>
    /// Warning
    /// </summary>
    public string? ShopWarning { get; set; }

    /// <summary>
    /// Event
    /// </summary>
    public int? EventId { get; set; }

    /// <summary>
    /// Event Ticket
    /// </summary>
    public int? EventTicketId { get; set; }

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual EventEvent? Event { get; set; }

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual EventEventTicket? EventTicket { get; set; }

    public virtual ICollection<SaleOrderLine> InverseLinkedLine { get; set; } = new List<SaleOrderLine>();

    public virtual SaleOrderLine? LinkedLine { get; set; }

    public virtual SaleOrder Order { get; set; } = null!;

    public virtual ResPartner? OrderPartner { get; set; }

    public virtual ICollection<PosOrderLine> PosOrderLines { get; set; } = new List<PosOrderLine>();

    public virtual ProductProduct? Product { get; set; }

    public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValues { get; set; } = new List<ProductAttributeCustomValue>();

    public virtual ProductPackaging? ProductPackaging { get; set; }

    public virtual UomUom? ProductUomNavigation { get; set; }

    public virtual ProjectProject? Project { get; set; }

    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; set; } = new List<ProjectMilestone>();

    public virtual ICollection<ProjectProject> ProjectProjects { get; set; } = new List<ProjectProject>();

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<RegistrationEditorLine> RegistrationEditorLines { get; set; } = new List<RegistrationEditorLine>();

    public virtual StockRoute? Route { get; set; }

    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; set; } = new List<SaleOrderOption>();

    public virtual ResUser? Salesman { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ProjectTask? Task { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();

    public virtual ICollection<AccountMoveLine> InvoiceLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; set; } = new List<ProductTemplateAttributeValue>();
}
