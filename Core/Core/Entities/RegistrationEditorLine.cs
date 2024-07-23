using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Edit Attendee Line on Sales Confirmation
/// </summary>
public partial class RegistrationEditorLine
{
    public int Id { get; set; }

    /// <summary>
    /// Editor
    /// </summary>
    public int? EditorId { get; set; }

    /// <summary>
    /// Sales Order Line
    /// </summary>
    public int? SaleOrderLineId { get; set; }

    /// <summary>
    /// Event
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// Original Registration
    /// </summary>
    public int? RegistrationId { get; set; }

    /// <summary>
    /// Event Ticket
    /// </summary>
    public int? EventTicketId { get; set; }

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
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual RegistrationEditor? Editor { get; set; }

    public virtual EventEvent Event { get; set; } = null!;

    public virtual EventEventTicket? EventTicket { get; set; }

    public virtual EventRegistration? Registration { get; set; }

    public virtual SaleOrderLine? SaleOrderLine { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
