using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Website Visitor
/// </summary>
public partial class WebsiteVisitor
{
    public int Id { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Contact
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public int? LangId { get; set; }

    /// <summary>
    /// # Visits
    /// </summary>
    public int? VisitCount { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Access Token
    /// </summary>
    public string AccessToken { get; set; } = null!;

    /// <summary>
    /// Timezone
    /// </summary>
    public string? Timezone { get; set; }

    /// <summary>
    /// First Connection
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Connection
    /// </summary>
    public DateTime? LastConnectionDatetime { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public int? LivechatOperatorId { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual ResLang? Lang { get; set; }

    public virtual ResPartner? LivechatOperator { get; set; }

    public virtual ICollection<MailChannel> MailChannels { get; set; } = new List<MailChannel>();

    public virtual ResPartner? Partner { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ICollection<WebsiteTrack> WebsiteTracks { get; set; } = new List<WebsiteTrack>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();
}
