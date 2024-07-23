using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Partner with additional information for mail resend
/// </summary>
public partial class MailResendPartner
{
    public int Id { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Resend wizard
    /// </summary>
    public int? ResendWizardId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Error message
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Try Again
    /// </summary>
    public bool? Resend { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual MailResendMessage? ResendWizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
