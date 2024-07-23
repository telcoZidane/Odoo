using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Quotation Template
/// </summary>
public partial class SaleOrderTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Confirmation Mail
    /// </summary>
    public int? MailTemplateId { get; set; }

    /// <summary>
    /// Quotation Duration
    /// </summary>
    public int? NumberOfDays { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Quotation Template
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Terms and conditions
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Online Signature
    /// </summary>
    public bool? RequireSignature { get; set; }

    /// <summary>
    /// Online Payment
    /// </summary>
    public bool? RequirePayment { get; set; }

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

    public virtual MailTemplate? MailTemplate { get; set; }

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; set; } = new List<SaleOrderTemplateLine>();

    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; set; } = new List<SaleOrderTemplateOption>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }
}
