using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Template Ticket
/// </summary>
public partial class EventTypeTicket
{
    public int Id { get; set; }

    /// <summary>
    /// Event Category
    /// </summary>
    public int EventTypeId { get; set; }

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
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Price
    /// </summary>
    public decimal? Price { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual EventType EventType { get; set; } = null!;

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
