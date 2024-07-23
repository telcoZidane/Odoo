using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mailing Favorite Filters
/// </summary>
public partial class MailingFilter
{
    public int Id { get; set; }

    /// <summary>
    /// Saved by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Recipients Model
    /// </summary>
    public int MailingModelId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Filter Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Filter Domain
    /// </summary>
    public string MailingDomain { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailingMailing> MailingMailings { get; set; } = new List<MailingMailing>();

    public virtual IrModel MailingModel { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
