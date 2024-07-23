using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Analytic Distribution Model
/// </summary>
public partial class AccountAnalyticDistributionModel
{
    public int Id { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Partner Category
    /// </summary>
    public int? PartnerCategoryId { get; set; }

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
    /// Analytic
    /// </summary>
    public string? AnalyticDistribution { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int? ProductCategId { get; set; }

    /// <summary>
    /// Accounts Prefix
    /// </summary>
    public string? AccountPrefix { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartnerCategory? PartnerCategory { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductCategory? ProductCateg { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
