using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sample Mail Wizard
/// </summary>
public partial class MailingMailingTest
{
    public int Id { get; set; }

    /// <summary>
    /// Mailing
    /// </summary>
    public int MassMailingId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Recipients
    /// </summary>
    public string EmailTo { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailingMailing MassMailing { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
