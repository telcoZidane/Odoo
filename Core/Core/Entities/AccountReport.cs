using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accounting Report
/// </summary>
public partial class AccountReport
{
    public int Id { get; set; }

    /// <summary>
    /// Root Report
    /// </summary>
    public int? RootReportId { get; set; }

    /// <summary>
    /// Chart of Accounts
    /// </summary>
    public int? ChartTemplateId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Load More Limit
    /// </summary>
    public int? LoadMoreLimit { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Availability
    /// </summary>
    public string? AvailabilityCondition { get; set; }

    /// <summary>
    /// Default Opening
    /// </summary>
    public string? DefaultOpeningDateFilter { get; set; }

    /// <summary>
    /// Multi-Company
    /// </summary>
    public string? FilterMultiCompany { get; set; }

    /// <summary>
    /// Account Groups
    /// </summary>
    public string? FilterHierarchy { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Only Tax Exigible Lines
    /// </summary>
    public bool? OnlyTaxExigible { get; set; }

    /// <summary>
    /// Search Bar
    /// </summary>
    public bool? SearchBar { get; set; }

    /// <summary>
    /// Date Range
    /// </summary>
    public bool? FilterDateRange { get; set; }

    /// <summary>
    /// Draft Entries
    /// </summary>
    public bool? FilterShowDraft { get; set; }

    /// <summary>
    /// Unreconciled Entries
    /// </summary>
    public bool? FilterUnreconciled { get; set; }

    /// <summary>
    /// Unfold All
    /// </summary>
    public bool? FilterUnfoldAll { get; set; }

    /// <summary>
    /// Period Comparison
    /// </summary>
    public bool? FilterPeriodComparison { get; set; }

    /// <summary>
    /// Growth Comparison
    /// </summary>
    public bool? FilterGrowthComparison { get; set; }

    /// <summary>
    /// Journals
    /// </summary>
    public bool? FilterJournals { get; set; }

    /// <summary>
    /// Analytic Filter
    /// </summary>
    public bool? FilterAnalytic { get; set; }

    /// <summary>
    /// Account Types
    /// </summary>
    public bool? FilterAccountType { get; set; }

    /// <summary>
    /// Partners
    /// </summary>
    public bool? FilterPartner { get; set; }

    /// <summary>
    /// Filter Multivat
    /// </summary>
    public bool? FilterFiscalPosition { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountReportColumn> AccountReportColumns { get; set; } = new List<AccountReportColumn>();

    public virtual ICollection<AccountReportLine> AccountReportLines { get; set; } = new List<AccountReportLine>();

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<AccountReport> InverseRootReport { get; set; } = new List<AccountReport>();

    public virtual AccountReport? RootReport { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
