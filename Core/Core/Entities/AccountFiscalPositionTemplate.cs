using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Template for Fiscal Position
/// </summary>
public partial class AccountFiscalPositionTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Chart Template
    /// </summary>
    public int ChartTemplateId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Country Group
    /// </summary>
    public int? CountryGroupId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Fiscal Position Template
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Zip Range From
    /// </summary>
    public string? ZipFrom { get; set; }

    /// <summary>
    /// Zip Range To
    /// </summary>
    public string? ZipTo { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Detect Automatically
    /// </summary>
    public bool? AutoApply { get; set; }

    /// <summary>
    /// VAT required
    /// </summary>
    public bool? VatRequired { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplates { get; set; } = new List<AccountFiscalPositionAccountTemplate>();

    public virtual ICollection<AccountFiscalPositionTaxTemplate> AccountFiscalPositionTaxTemplates { get; set; } = new List<AccountFiscalPositionTaxTemplate>();

    public virtual AccountChartTemplate ChartTemplate { get; set; } = null!;

    public virtual ResCountry? Country { get; set; }

    public virtual ResCountryGroup? CountryGroup { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResCountryState> ResCountryStates { get; set; } = new List<ResCountryState>();
}
