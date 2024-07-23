using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// IAP Account
/// </summary>
public partial class IapAccount
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
    /// Service Name
    /// </summary>
    public string? ServiceName { get; set; }

    /// <summary>
    /// Account Token
    /// </summary>
    public string? AccountToken { get; set; }

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

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();
}
