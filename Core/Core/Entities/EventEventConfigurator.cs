using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Configurator
/// </summary>
public partial class EventEventConfigurator
{
    public int Id { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Event
    /// </summary>
    public int? EventId { get; set; }

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
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual EventEvent? Event { get; set; }

    public virtual EventEventTicket? EventTicket { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
