using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Ticket
/// </summary>
public partial class EventEventTicket
{
    public int Id { get; set; }

    /// <summary>
    /// Event Category
    /// </summary>
    public int? EventTypeId { get; set; }

    /// <summary>
    /// Maximum Attendees
    /// </summary>
    public int? SeatsMax { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Event
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Limit Attendees
    /// </summary>
    public bool? SeatsLimited { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Registration Start
    /// </summary>
    public DateTime? StartSaleDatetime { get; set; }

    /// <summary>
    /// Registration End
    /// </summary>
    public DateTime? EndSaleDatetime { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Price
    /// </summary>
    public decimal? Price { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual EventEvent Event { get; set; } = null!;

    public virtual ICollection<EventEventConfigurator> EventEventConfigurators { get; set; } = new List<EventEventConfigurator>();

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual EventType? EventType { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ICollection<RegistrationEditorLine> RegistrationEditorLines { get; set; } = new List<RegistrationEditorLine>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ResUser? WriteU { get; set; }
}
