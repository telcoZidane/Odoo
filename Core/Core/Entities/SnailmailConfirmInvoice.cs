using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Snailmail Confirm Invoice
/// </summary>
public partial class SnailmailConfirmInvoice
{
    public int Id { get; set; }

    /// <summary>
    /// Invoice Send
    /// </summary>
    public int? InvoiceSendId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Model Name
    /// </summary>
    public string? ModelName { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountInvoiceSend? InvoiceSend { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
