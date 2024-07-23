using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Languages
/// </summary>
public partial class ResLang
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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Locale Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// ISO code
    /// </summary>
    public string? IsoCode { get; set; }

    /// <summary>
    /// URL Code
    /// </summary>
    public string UrlCode { get; set; } = null!;

    /// <summary>
    /// Direction
    /// </summary>
    public string Direction { get; set; } = null!;

    /// <summary>
    /// Date Format
    /// </summary>
    public string DateFormat { get; set; } = null!;

    /// <summary>
    /// Time Format
    /// </summary>
    public string TimeFormat { get; set; } = null!;

    /// <summary>
    /// First Day of Week
    /// </summary>
    public string WeekStart { get; set; } = null!;

    /// <summary>
    /// Separator Format
    /// </summary>
    public string Grouping { get; set; } = null!;

    /// <summary>
    /// Decimal Separator
    /// </summary>
    public string DecimalPoint { get; set; } = null!;

    /// <summary>
    /// Thousands Separator
    /// </summary>
    public string? ThousandsSep { get; set; }

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

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; set; } = new List<WebsiteVisitor>();

    public virtual ICollection<Website> Websites { get; set; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<BaseLanguageInstall> LanguageWizards { get; set; } = new List<BaseLanguageInstall>();

    public virtual ICollection<Website> WebsitesNavigation { get; set; } = new List<Website>();
}
