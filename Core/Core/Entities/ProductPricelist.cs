using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Pricelist
/// </summary>
public partial class ProductPricelist
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Discount Policy
    /// </summary>
    public string DiscountPolicy { get; set; } = null!;

    /// <summary>
    /// Pricelist Name
    /// </summary>
    public string Name { get; set; } = null!;

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

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// E-commerce Promotional Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Selectable
    /// </summary>
    public bool? Selectable { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItemBasePricelists { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItemPricelists { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<PosConfig> PosConfigsNavigation { get; set; } = new List<PosConfig>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResCountryGroup> ResCountryGroups { get; set; } = new List<ResCountryGroup>();
}
