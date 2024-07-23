using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Registration
/// </summary>
public partial class EventRegistration
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Event
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// Event Ticket
    /// </summary>
    public int? EventTicketId { get; set; }

    /// <summary>
    /// Campaign
    /// </summary>
    public int? UtmCampaignId { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public int? UtmSourceId { get; set; }

    /// <summary>
    /// Medium
    /// </summary>
    public int? UtmMediumId { get; set; }

    /// <summary>
    /// Booked by
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Attendee Name
    /// </summary>
    public string? Name { get; set; }

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
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Attended Date
    /// </summary>
    public DateTime? DateClosed { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Visitor
    /// </summary>
    public int? VisitorId { get; set; }

    /// <summary>
    /// Sales Order
    /// </summary>
    public int? SaleOrderId { get; set; }

    /// <summary>
    /// Sales Order Line
    /// </summary>
    public int? SaleOrderLineId { get; set; }

    /// <summary>
    /// Is Paid
    /// </summary>
    public bool? IsPaid { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual EventEvent Event { get; set; } = null!;

    public virtual ICollection<EventMailRegistration> EventMailRegistrations { get; set; } = new List<EventMailRegistration>();

    public virtual EventEventTicket? EventTicket { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ICollection<RegistrationEditorLine> RegistrationEditorLines { get; set; } = new List<RegistrationEditorLine>();

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual SaleOrderLine? SaleOrderLine { get; set; }

    public virtual UtmCampaign? UtmCampaign { get; set; }

    public virtual UtmMedium? UtmMedium { get; set; }

    public virtual UtmSource? UtmSource { get; set; }

    public virtual WebsiteVisitor? Visitor { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();
}
