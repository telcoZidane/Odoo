using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Lunch Supplier
/// </summary>
public partial class LunchSupplier
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Vendor
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? ResponsibleId { get; set; }

    /// <summary>
    /// Cron
    /// </summary>
    public int CronId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Send Order By
    /// </summary>
    public string? SendBy { get; set; }

    /// <summary>
    /// Timezone
    /// </summary>
    public string Tz { get; set; } = null!;

    /// <summary>
    /// Moment
    /// </summary>
    public string Moment { get; set; } = null!;

    /// <summary>
    /// Delivery
    /// </summary>
    public string? Delivery { get; set; }

    /// <summary>
    /// Extra 1 Label
    /// </summary>
    public string ToppingLabel1 { get; set; } = null!;

    /// <summary>
    /// Extra 2 Label
    /// </summary>
    public string ToppingLabel2 { get; set; } = null!;

    /// <summary>
    /// Extra 3 Label
    /// </summary>
    public string ToppingLabel3 { get; set; } = null!;

    /// <summary>
    /// Extra 1 Quantity
    /// </summary>
    public string ToppingQuantity1 { get; set; } = null!;

    /// <summary>
    /// Extra 2 Quantity
    /// </summary>
    public string ToppingQuantity2 { get; set; } = null!;

    /// <summary>
    /// Extra 3 Quantity
    /// </summary>
    public string ToppingQuantity3 { get; set; } = null!;

    /// <summary>
    /// Until
    /// </summary>
    public DateOnly? RecurrencyEndDate { get; set; }

    /// <summary>
    /// Mon
    /// </summary>
    public bool? Mon { get; set; }

    /// <summary>
    /// Tue
    /// </summary>
    public bool? Tue { get; set; }

    /// <summary>
    /// Wed
    /// </summary>
    public bool? Wed { get; set; }

    /// <summary>
    /// Thu
    /// </summary>
    public bool? Thu { get; set; }

    /// <summary>
    /// Fri
    /// </summary>
    public bool? Fri { get; set; }

    /// <summary>
    /// Sat
    /// </summary>
    public bool? Sat { get; set; }

    /// <summary>
    /// Sun
    /// </summary>
    public bool? Sun { get; set; }

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
    /// Order Time
    /// </summary>
    public double AutomaticEmailTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrCron Cron { get; set; } = null!;

    public virtual ICollection<LunchOrder> LunchOrders { get; set; } = new List<LunchOrder>();

    public virtual ICollection<LunchProduct> LunchProducts { get; set; } = new List<LunchProduct>();

    public virtual ICollection<LunchTopping> LunchToppings { get; set; } = new List<LunchTopping>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResUser? Responsible { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<LunchLocation> LunchLocations { get; set; } = new List<LunchLocation>();
}
