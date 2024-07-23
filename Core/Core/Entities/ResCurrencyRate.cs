﻿using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Currency Rate
/// </summary>
public partial class ResCurrencyRate
{
    public int Id { get; set; }

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
    /// Date
    /// </summary>
    public DateOnly Name { get; set; }

    /// <summary>
    /// Technical Rate
    /// </summary>
    public decimal? Rate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
