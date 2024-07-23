using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class IrActServer
{
    public int Id { get; set; }

    public int? BindingModelId { get; set; }

    public int? CreateUid { get; set; }

    public int? WriteUid { get; set; }

    public string Type { get; set; } = null!;

    public string BindingType { get; set; } = null!;

    public string? BindingViewTypes { get; set; }

    public string Name { get; set; } = null!;

    public string? Help { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int ModelId { get; set; }

    /// <summary>
    /// Target Model
    /// </summary>
    public int? CrudModelId { get; set; }

    /// <summary>
    /// Link Field
    /// </summary>
    public int? LinkFieldId { get; set; }

    /// <summary>
    /// Usage
    /// </summary>
    public string Usage { get; set; } = null!;

    /// <summary>
    /// Action To Do
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Model Name
    /// </summary>
    public string? ModelName { get; set; }

    /// <summary>
    /// Python Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Email Template
    /// </summary>
    public int? TemplateId { get; set; }

    /// <summary>
    /// Activity
    /// </summary>
    public int? ActivityTypeId { get; set; }

    /// <summary>
    /// Due Date In
    /// </summary>
    public int? ActivityDateDeadlineRange { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? ActivityUserId { get; set; }

    /// <summary>
    /// Send as
    /// </summary>
    public string? MailPostMethod { get; set; }

    /// <summary>
    /// Summary
    /// </summary>
    public string? ActivitySummary { get; set; }

    /// <summary>
    /// Due type
    /// </summary>
    public string? ActivityDateDeadlineRangeType { get; set; }

    /// <summary>
    /// Activity User Type
    /// </summary>
    public string? ActivityUserType { get; set; }

    /// <summary>
    /// User field name
    /// </summary>
    public string? ActivityUserFieldName { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? ActivityNote { get; set; }

    /// <summary>
    /// Subscribe Recipients
    /// </summary>
    public bool? MailPostAutofollow { get; set; }

    /// <summary>
    /// SMS Template
    /// </summary>
    public int? SmsTemplateId { get; set; }

    /// <summary>
    /// Send as (SMS)
    /// </summary>
    public string? SmsMethod { get; set; }

    /// <summary>
    /// Website Path
    /// </summary>
    public string? WebsitePath { get; set; }

    /// <summary>
    /// Available on the Website
    /// </summary>
    public bool? WebsitePublished { get; set; }

    public virtual MailActivityType? ActivityType { get; set; }

    public virtual ResUser? ActivityUser { get; set; }

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel? CrudModel { get; set; }

    public virtual ICollection<IrCron> IrCrons { get; set; } = new List<IrCron>();

    public virtual ICollection<IrServerObjectLine> IrServerObjectLines { get; set; } = new List<IrServerObjectLine>();

    public virtual IrModelField? LinkField { get; set; }

    public virtual IrModel Model { get; set; } = null!;

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual MailTemplate? Template { get; set; }

    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilters { get; set; } = new List<WebsiteSnippetFilter>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrActServer> Actions { get; set; } = new List<IrActServer>();

    public virtual ICollection<ResGroup> Gids { get; set; } = new List<ResGroup>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<IrActServer> Servers { get; set; } = new List<IrActServer>();
}
