using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Pricelist Rule
/// </summary>
public partial class ProductPricelistItem
{
    public int Id { get; set; }

    /// <summary>
    /// Pricelist
    /// </summary>
    public int PricelistId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int? CategId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductTmplId { get; set; }

    /// <summary>
    /// Product Variant
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Other Pricelist
    /// </summary>
    public int? BasePricelistId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Apply On
    /// </summary>
    public string AppliedOn { get; set; } = null!;

    /// <summary>
    /// Based on
    /// </summary>
    public string Base { get; set; } = null!;

    /// <summary>
    /// Compute Price
    /// </summary>
    public string ComputePrice { get; set; } = null!;

    /// <summary>
    /// Min. Quantity
    /// </summary>
    public decimal? MinQuantity { get; set; }

    /// <summary>
    /// Fixed Price
    /// </summary>
    public decimal? FixedPrice { get; set; }

    /// <summary>
    /// Price Discount
    /// </summary>
    public decimal? PriceDiscount { get; set; }

    /// <summary>
    /// Price Rounding
    /// </summary>
    public decimal? PriceRound { get; set; }

    /// <summary>
    /// Price Surcharge
    /// </summary>
    public decimal? PriceSurcharge { get; set; }

    /// <summary>
    /// Min. Price Margin
    /// </summary>
    public decimal? PriceMinMargin { get; set; }

    /// <summary>
    /// Max. Price Margin
    /// </summary>
    public decimal? PriceMaxMargin { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateTime? DateEnd { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Percentage Price
    /// </summary>
    public double? PercentPrice { get; set; }

    public virtual ProductPricelist? BasePricelist { get; set; }

    public virtual ProductCategory? Categ { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ProductPricelist Pricelist { get; set; } = null!;

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
