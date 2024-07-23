using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Test SMS Mailing
/// </summary>
public partial class MailingSmsTest
{
    public int Id { get; set; }

    /// <summary>
    /// Mailing
    /// </summary>
    public int MailingId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Number(s)
    /// </summary>
    public string Numbers { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailingMailing Mailing { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
