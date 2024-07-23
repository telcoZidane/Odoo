using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Template for Account Groups
/// </summary>
public partial class AccountGroupTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Parent
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Chart Template
    /// </summary>
    public int ChartTemplateId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

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

    public virtual AccountChartTemplate ChartTemplate { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<AccountGroupTemplate> InverseParent { get; set; } = new List<AccountGroupTemplate>();

    public virtual AccountGroupTemplate? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
