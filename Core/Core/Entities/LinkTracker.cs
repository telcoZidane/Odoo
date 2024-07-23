using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Link Tracker
/// </summary>
public partial class LinkTracker
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
    /// Number of Clicks
    /// </summary>
    public int? Count { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Target URL
    /// </summary>
    public string Url { get; set; } = null!;

    /// <summary>
    /// Page Title
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Button label
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Mass Mailing
    /// </summary>
    public int? MassMailingId { get; set; }

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<LinkTrackerClick> LinkTrackerClicks { get; set; } = new List<LinkTrackerClick>();

    public virtual ICollection<LinkTrackerCode> LinkTrackerCodes { get; set; } = new List<LinkTrackerCode>();

    public virtual MailingMailing? MassMailing { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual UtmSource? Source { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
