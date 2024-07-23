using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Message subtypes
/// </summary>
public partial class MailMessageSubtype
{
    public int Id { get; set; }

    /// <summary>
    /// Parent
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Sequence
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
    /// Relation field
    /// </summary>
    public string? RelationField { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Message Type
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Internal Only
    /// </summary>
    public bool? Internal { get; set; }

    /// <summary>
    /// Default
    /// </summary>
    public bool? Default { get; set; }

    /// <summary>
    /// Hidden
    /// </summary>
    public bool? Hidden { get; set; }

    /// <summary>
    /// Track Recipients
    /// </summary>
    public bool? TrackRecipients { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrLeaveType> HrLeaveTypeAllocationNotifSubtypes { get; set; } = new List<HrLeaveType>();

    public virtual ICollection<HrLeaveType> HrLeaveTypeLeaveNotifSubtypes { get; set; } = new List<HrLeaveType>();

    public virtual ICollection<MailMessageSubtype> InverseParent { get; set; } = new List<MailMessageSubtype>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailMessage> MailMessages { get; set; } = new List<MailMessage>();

    public virtual MailMessageSubtype? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MailFollower> MailFollowers { get; set; } = new List<MailFollower>();
}
