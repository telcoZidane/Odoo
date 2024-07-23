using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// ICE server
/// </summary>
public partial class MailIceServer
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
    /// Type
    /// </summary>
    public string ServerType { get; set; } = null!;

    /// <summary>
    /// URI
    /// </summary>
    public string Uri { get; set; } = null!;

    /// <summary>
    /// Username
    /// </summary>
    public string? Username { get; set; }

    /// <summary>
    /// Credential
    /// </summary>
    public string? Credential { get; set; }

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
