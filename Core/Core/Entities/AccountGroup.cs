using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Account Group
/// </summary>
public partial class AccountGroup
{
    public int Id { get; set; }

    /// <summary>
    /// Parent
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Parent Path
    /// </summary>
    public string? ParentPath { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Code Prefix Start
    /// </summary>
    public string? CodePrefixStart { get; set; }

    /// <summary>
    /// Code Prefix End
    /// </summary>
    public string? CodePrefixEnd { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAccount> AccountAccounts { get; set; } = new List<AccountAccount>();

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<AccountGroup> InverseParent { get; set; } = new List<AccountGroup>();

    public virtual AccountGroup? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
