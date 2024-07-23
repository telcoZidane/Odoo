using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Format Error Sending a Snailmail Letter
/// </summary>
public partial class SnailmailLetterFormatError
{
    public int Id { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public int? MessageId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Add a Cover Page
    /// </summary>
    public bool? SnailmailCover { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? Message { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
