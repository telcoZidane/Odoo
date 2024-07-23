using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mail Server
/// </summary>
public partial class IrMailServer
{
    public int Id { get; set; }

    /// <summary>
    /// SMTP Port
    /// </summary>
    public int SmtpPort { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public int? Sequence { get; set; }

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
    /// FROM Filtering
    /// </summary>
    public string? FromFilter { get; set; }

    /// <summary>
    /// SMTP Server
    /// </summary>
    public string SmtpHost { get; set; } = null!;

    /// <summary>
    /// Authenticate with
    /// </summary>
    public string SmtpAuthentication { get; set; } = null!;

    /// <summary>
    /// Username
    /// </summary>
    public string? SmtpUser { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    public string? SmtpPass { get; set; }

    /// <summary>
    /// Connection Encryption
    /// </summary>
    public string SmtpEncryption { get; set; } = null!;

    /// <summary>
    /// Debugging
    /// </summary>
    public bool? SmtpDebug { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// SSL Certificate
    /// </summary>
    public byte[]? SmtpSslCertificate { get; set; }

    /// <summary>
    /// SSL Private Key
    /// </summary>
    public byte[]? SmtpSslPrivateKey { get; set; }

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

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailMessage> MailMessages { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailTemplate> MailTemplates { get; set; } = new List<MailTemplate>();

    public virtual ICollection<MailingMailing> MailingMailings { get; set; } = new List<MailingMailing>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<SurveyInvite> SurveyInvites { get; set; } = new List<SurveyInvite>();

    public virtual ResUser? WriteU { get; set; }
}
