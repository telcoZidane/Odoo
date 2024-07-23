using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Payment Terms Line
/// </summary>
public partial class AccountPaymentTermLine
{
    public int Id { get; set; }

    /// <summary>
    /// Months
    /// </summary>
    public int Months { get; set; }

    /// <summary>
    /// Days
    /// </summary>
    public int Days { get; set; }

    /// <summary>
    /// Days after End of month
    /// </summary>
    public int? DaysAfter { get; set; }

    /// <summary>
    /// Discount Days
    /// </summary>
    public int? DiscountDays { get; set; }

    /// <summary>
    /// Payment Terms
    /// </summary>
    public int PaymentId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Value { get; set; } = null!;

    /// <summary>
    /// Value
    /// </summary>
    public decimal? ValueAmount { get; set; }

    /// <summary>
    /// End of month
    /// </summary>
    public bool? EndMonth { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Discount %
    /// </summary>
    public double? DiscountPercentage { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountPaymentTerm Payment { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
