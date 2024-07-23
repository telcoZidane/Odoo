using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Account Invoice Send
/// </summary>
public partial class AccountInvoiceSend
{
    public int Id { get; set; }

    /// <summary>
    /// Composer
    /// </summary>
    public int ComposerId { get; set; }

    /// <summary>
    /// Use template
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
    /// Email
    /// </summary>
    public bool? IsEmail { get; set; }

    /// <summary>
    /// Print
    /// </summary>
    public bool? IsPrint { get; set; }

    /// <summary>
    /// Is Printed
    /// </summary>
    public bool? Printed { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Send by Post
    /// </summary>
    public bool? SnailmailIsLetter { get; set; }

    public virtual MailComposeMessage Composer { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<SnailmailConfirmInvoice> SnailmailConfirmInvoices { get; set; } = new List<SnailmailConfirmInvoice>();

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();
}
