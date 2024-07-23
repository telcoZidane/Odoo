using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mail Gateway Allowed
/// </summary>
public partial class MailGatewayAllowed
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Email Address
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Normalized Email
    /// </summary>
    public string? EmailNormalized { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
