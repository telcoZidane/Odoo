using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Link Tracker Click
/// </summary>
public partial class LinkTrackerClick
{
    public int Id { get; set; }

    /// <summary>
    /// UTM Campaign
    /// </summary>
    public int? CampaignId { get; set; }

    /// <summary>
    /// Link
    /// </summary>
    public int LinkId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Internet Protocol
    /// </summary>
    public string? Ip { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Mail Statistics
    /// </summary>
    public int? MailingTraceId { get; set; }

    /// <summary>
    /// Mass Mailing
    /// </summary>
    public int? MassMailingId { get; set; }

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual LinkTracker Link { get; set; } = null!;

    public virtual MailingTrace? MailingTrace { get; set; }

    public virtual MailingMailing? MassMailing { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
