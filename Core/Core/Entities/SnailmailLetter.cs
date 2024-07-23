using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Snailmail Letter
/// </summary>
public partial class SnailmailLetter
{
    public int Id { get; set; }

    /// <summary>
    /// Sent by
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Document ID
    /// </summary>
    public int ResId { get; set; }

    /// <summary>
    /// Recipient
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Optional report to print and attach
    /// </summary>
    public int? ReportTemplate { get; set; }

    /// <summary>
    /// Attachment
    /// </summary>
    public int? AttachmentId { get; set; }

    /// <summary>
    /// Snailmail Status Message
    /// </summary>
    public int? MessageId { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public int? StateId { get; set; }

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
    /// Model
    /// </summary>
    public string Model { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Error
    /// </summary>
    public string? ErrorCode { get; set; }

    /// <summary>
    /// Information
    /// </summary>
    public string? InfoMsg { get; set; }

    /// <summary>
    /// Street
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// Street2
    /// </summary>
    public string? Street2 { get; set; }

    /// <summary>
    /// Zip
    /// </summary>
    public string? Zip { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public bool? Color { get; set; }

    /// <summary>
    /// Cover Page
    /// </summary>
    public bool? Cover { get; set; }

    /// <summary>
    /// Both side
    /// </summary>
    public bool? Duplex { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual IrAttachment? Attachment { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailNotification> MailNotifications { get; set; } = new List<MailNotification>();

    public virtual MailMessage? Message { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual IrActReportXml? ReportTemplateNavigation { get; set; }

    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; set; } = new List<SnailmailLetterMissingRequiredField>();

    public virtual ResCountryState? StateNavigation { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
