using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mail Tracking Value
/// </summary>
public partial class MailTrackingValue
{
    public int Id { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int Field { get; set; }

    /// <summary>
    /// Old Value Integer
    /// </summary>
    public int? OldValueInteger { get; set; }

    /// <summary>
    /// New Value Integer
    /// </summary>
    public int? NewValueInteger { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Message ID
    /// </summary>
    public int MailMessageId { get; set; }

    /// <summary>
    /// Tracking field sequence
    /// </summary>
    public int? TrackingSequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Field Description
    /// </summary>
    public string FieldDesc { get; set; } = null!;

    /// <summary>
    /// Field Type
    /// </summary>
    public string? FieldType { get; set; }

    /// <summary>
    /// Old Value Char
    /// </summary>
    public string? OldValueChar { get; set; }

    /// <summary>
    /// New Value Char
    /// </summary>
    public string? NewValueChar { get; set; }

    /// <summary>
    /// Old Value Text
    /// </summary>
    public string? OldValueText { get; set; }

    /// <summary>
    /// New Value Text
    /// </summary>
    public string? NewValueText { get; set; }

    /// <summary>
    /// Old Value DateTime
    /// </summary>
    public DateTime? OldValueDatetime { get; set; }

    /// <summary>
    /// New Value Datetime
    /// </summary>
    public DateTime? NewValueDatetime { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Old Value Float
    /// </summary>
    public double? OldValueFloat { get; set; }

    /// <summary>
    /// Old Value Monetary
    /// </summary>
    public double? OldValueMonetary { get; set; }

    /// <summary>
    /// New Value Float
    /// </summary>
    public double? NewValueFloat { get; set; }

    /// <summary>
    /// New Value Monetary
    /// </summary>
    public double? NewValueMonetary { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual IrModelField FieldNavigation { get; set; } = null!;

    public virtual MailMessage MailMessage { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
