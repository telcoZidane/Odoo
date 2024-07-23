using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Activity Type
/// </summary>
public partial class MailActivityType
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Create Uid
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Schedule
    /// </summary>
    public int? DelayCount { get; set; }

    /// <summary>
    /// Trigger
    /// </summary>
    public int? TriggeredNextTypeId { get; set; }

    /// <summary>
    /// Default User
    /// </summary>
    public int? DefaultUserId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Delay units
    /// </summary>
    public string DelayUnit { get; set; } = null!;

    /// <summary>
    /// Delay Type
    /// </summary>
    public string DelayFrom { get; set; } = null!;

    /// <summary>
    /// Icon
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Decoration Type
    /// </summary>
    public string? DecorationType { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Chaining Type
    /// </summary>
    public string ChainingType { get; set; } = null!;

    /// <summary>
    /// Action
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Default Summary
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// Default Note
    /// </summary>
    public string? DefaultNote { get; set; }

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

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? DefaultUser { get; set; }

    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypes { get; set; } = new List<HrPlanActivityType>();

    public virtual ICollection<MailActivityType> InverseTriggeredNextType { get; set; } = new List<MailActivityType>();

    public virtual ICollection<IrActServer> IrActServers { get; set; } = new List<IrActServer>();

    public virtual ICollection<MailActivity> MailActivityActivityTypes { get; set; } = new List<MailActivity>();

    public virtual ICollection<MailActivity> MailActivityPreviousActivityTypes { get; set; } = new List<MailActivity>();

    public virtual ICollection<MailActivity> MailActivityRecommendedActivityTypes { get; set; } = new List<MailActivity>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailMessage> MailMessages { get; set; } = new List<MailMessage>();

    public virtual MailActivityType? TriggeredNextType { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MailActivityType> Activities { get; set; } = new List<MailActivityType>();

    public virtual ICollection<MailTemplate> MailTemplates { get; set; } = new List<MailTemplate>();

    public virtual ICollection<MailActivityType> Recommendeds { get; set; } = new List<MailActivityType>();
}
