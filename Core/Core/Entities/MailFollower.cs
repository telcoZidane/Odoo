using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Document Followers
/// </summary>
public partial class MailFollower
{
    public int Id { get; set; }

    /// <summary>
    /// Related Document ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Related Partner
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Related Document Model Name
    /// </summary>
    public string ResModel { get; set; } = null!;

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ICollection<MailMessageSubtype> MailMessageSubtypes { get; set; } = new List<MailMessageSubtype>();
}
