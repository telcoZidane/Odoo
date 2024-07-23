using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Calendar Provider Configuration Wizard
/// </summary>
public partial class CalendarProviderConfig
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Choose an external calendar to configure
    /// </summary>
    public string? ExternalCalendarProvider { get; set; }

    /// <summary>
    /// Google Client_id
    /// </summary>
    public string? CalClientId { get; set; }

    /// <summary>
    /// Google Client_key
    /// </summary>
    public string? CalClientSecret { get; set; }

    /// <summary>
    /// Outlook Client Id
    /// </summary>
    public string? MicrosoftOutlookClientIdentifier { get; set; }

    /// <summary>
    /// Outlook Client Secret
    /// </summary>
    public string? MicrosoftOutlookClientSecret { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
