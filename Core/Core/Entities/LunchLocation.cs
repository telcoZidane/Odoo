using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Lunch Locations
/// </summary>
public partial class LunchLocation
{
    public int Id { get; set; }

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
    /// Location Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Address
    /// </summary>
    public string? Address { get; set; }

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

    public virtual ICollection<LunchOrder> LunchOrders { get; set; } = new List<LunchOrder>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<LunchAlert> LunchAlerts { get; set; } = new List<LunchAlert>();

    public virtual ICollection<LunchSupplier> LunchSuppliers { get; set; } = new List<LunchSupplier>();
}
