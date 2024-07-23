using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class EventSaleReport
{
    public long? Id { get; set; }

    public int? EventRegistrationId { get; set; }

    public int? CompanyId { get; set; }

    public int? EventId { get; set; }

    public int? EventTicketId { get; set; }

    public DateTime? EventRegistrationCreateDate { get; set; }

    public string? EventRegistrationName { get; set; }

    public string? EventRegistrationState { get; set; }

    public bool? Active { get; set; }

    public int? SaleOrderId { get; set; }

    public int? SaleOrderLineId { get; set; }

    public bool? IsPaid { get; set; }

    public int? EventTypeId { get; set; }

    public DateTime? EventDateBegin { get; set; }

    public DateTime? EventDateEnd { get; set; }

    public decimal? EventTicketPrice { get; set; }

    public DateTime? SaleOrderDate { get; set; }

    public int? InvoicePartnerId { get; set; }

    public int? SaleOrderPartnerId { get; set; }

    public string? SaleOrderState { get; set; }

    public int? SaleOrderUserId { get; set; }

    public int? ProductId { get; set; }

    public decimal? SalePrice { get; set; }

    public decimal? SalePriceUntaxed { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? IsPublished { get; set; }
}
