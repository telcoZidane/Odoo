using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Send SMS Wizard
/// </summary>
public partial class SmsComposer
{
    public int Id { get; set; }

    /// <summary>
    /// Document ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Use Template
    /// </summary>
    public int? TemplateId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Composition Mode
    /// </summary>
    public string CompositionMode { get; set; } = null!;

    /// <summary>
    /// Document Model Name
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Document IDs
    /// </summary>
    public string? ResIds { get; set; }

    /// <summary>
    /// Recipient Number
    /// </summary>
    public string? RecipientSingleNumberItf { get; set; }

    /// <summary>
    /// Number Field
    /// </summary>
    public string? NumberFieldName { get; set; }

    /// <summary>
    /// Recipients (Numbers)
    /// </summary>
    public string? Numbers { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public string Body { get; set; } = null!;

    /// <summary>
    /// Keep a note on document
    /// </summary>
    public bool? MassKeepLog { get; set; }

    /// <summary>
    /// Send directly
    /// </summary>
    public bool? MassForceSend { get; set; }

    /// <summary>
    /// Use blacklist
    /// </summary>
    public bool? MassUseBlacklist { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Mailing
    /// </summary>
    public int? MailingId { get; set; }

    /// <summary>
    /// Campaign
    /// </summary>
    public int? UtmCampaignId { get; set; }

    /// <summary>
    /// Include opt-out link
    /// </summary>
    public bool? MassSmsAllowUnsubscribe { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailingMailing? Mailing { get; set; }

    public virtual SmsTemplate? Template { get; set; }

    public virtual UtmCampaign? UtmCampaign { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
