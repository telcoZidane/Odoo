using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Incoming Mail Server
/// </summary>
public partial class FetchmailServer
{
    public int Id { get; set; }

    /// <summary>
    /// Port
    /// </summary>
    public int? Port { get; set; }

    /// <summary>
    /// Create a New Record
    /// </summary>
    public int? ObjectId { get; set; }

    /// <summary>
    /// Server Priority
    /// </summary>
    public int? Priority { get; set; }

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
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Server Name
    /// </summary>
    public string? Server { get; set; }

    /// <summary>
    /// Server Type
    /// </summary>
    public string ServerType { get; set; } = null!;

    /// <summary>
    /// Username
    /// </summary>
    public string? User { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// Script
    /// </summary>
    public string? Script { get; set; }

    /// <summary>
    /// Configuration
    /// </summary>
    public string? Configuration { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// SSL/TLS
    /// </summary>
    public bool? IsSsl { get; set; }

    /// <summary>
    /// Keep Attachments
    /// </summary>
    public bool? Attach { get; set; }

    /// <summary>
    /// Keep Original
    /// </summary>
    public bool? Original { get; set; }

    /// <summary>
    /// Last Fetch Date
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Access Token Expiration Timestamp
    /// </summary>
    public int? GoogleGmailAccessTokenExpiration { get; set; }

    /// <summary>
    /// Authorization Code
    /// </summary>
    public string? GoogleGmailAuthorizationCode { get; set; }

    /// <summary>
    /// Refresh Token
    /// </summary>
    public string? GoogleGmailRefreshToken { get; set; }

    /// <summary>
    /// Access Token
    /// </summary>
    public string? GoogleGmailAccessToken { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailMail> MailMails { get; set; } = new List<MailMail>();

    public virtual IrModel? Object { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
