using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Lunch Order
/// </summary>
public partial class LunchOrder
{
    public int Id { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Vendor
    /// </summary>
    public int? SupplierId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Lunch Location
    /// </summary>
    public int? LunchLocationId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Order Date
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Product Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Extras
    /// </summary>
    public string? DisplayToppings { get; set; }

    /// <summary>
    /// Total Price
    /// </summary>
    public decimal? Price { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Notified
    /// </summary>
    public bool? Notified { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public double Quantity { get; set; }

    public virtual LunchProductCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual LunchLocation? LunchLocation { get; set; }

    public virtual LunchProduct Product { get; set; } = null!;

    public virtual LunchSupplier? Supplier { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<LunchTopping> Toppings { get; set; } = new List<LunchTopping>();
}
