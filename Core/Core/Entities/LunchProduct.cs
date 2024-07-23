using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Lunch Product
/// </summary>
public partial class LunchProduct
{
    public int Id { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// Vendor
    /// </summary>
    public int SupplierId { get; set; }

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
    /// New Until
    /// </summary>
    public DateOnly? NewUntil { get; set; }

    /// <summary>
    /// Product Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Price
    /// </summary>
    public decimal Price { get; set; }

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

    public virtual LunchProductCategory Category { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<LunchOrder> LunchOrders { get; set; } = new List<LunchOrder>();

    public virtual LunchSupplier Supplier { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> Users { get; set; } = new List<ResUser>();
}
