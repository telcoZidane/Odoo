using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Fiscal Position
/// </summary>
public partial class AccountFiscalPosition
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

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
    /// Fiscal Position
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
    /// Foreign Tax ID
    /// </summary>
    public string? ForeignVat { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

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

    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccounts { get; set; } = new List<AccountFiscalPositionAccount>();

    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxes { get; set; } = new List<AccountFiscalPositionTax>();

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; set; } = new List<AccountReportExternalValue>();

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResCountry? Country { get; set; }

    public virtual ResCountryGroup? CountryGroup { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PosConfig> PosConfigsNavigation { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResCountryState> ResCountryStates { get; set; } = new List<ResCountryState>();
}
