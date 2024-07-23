using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Create new or use existing Customer on new Quotation
/// </summary>
public partial class CrmQuotationPartner
{
    public int Id { get; set; }

    /// <summary>
    /// Associated Lead
    /// </summary>
    public int LeadId { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Quotation Customer
    /// </summary>
    public string Action { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmLead Lead { get; set; } = null!;

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
