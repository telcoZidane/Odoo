using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sales Order Cancel
/// </summary>
public partial class SaleOrderCancel
{
    public int Id { get; set; }

    /// <summary>
    /// Mail Template
    /// </summary>
    public int? TemplateId { get; set; }

    /// <summary>
    /// Author
    /// </summary>
    public int? AuthorId { get; set; }

    /// <summary>
    /// Sale Order
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Subject
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// From
    /// </summary>
    public string? EmailFrom { get; set; }

    /// <summary>
    /// Contents
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SaleOrder Order { get; set; } = null!;

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
