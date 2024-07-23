using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Edit Attendee Details on Sales Confirmation
/// </summary>
public partial class RegistrationEditor
{
    public int Id { get; set; }

    /// <summary>
    /// Sales Order
    /// </summary>
    public int SaleOrderId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<RegistrationEditorLine> RegistrationEditorLines { get; set; } = new List<RegistrationEditorLine>();

    public virtual SaleOrder SaleOrder { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
