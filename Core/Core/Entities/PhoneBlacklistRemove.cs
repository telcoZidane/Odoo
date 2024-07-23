using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Remove phone from blacklist
/// </summary>
public partial class PhoneBlacklistRemove
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
    /// Phone Number
    /// </summary>
    public string Phone { get; set; } = null!;

    /// <summary>
    /// Reason
    /// </summary>
    public string? Reason { get; set; }

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
