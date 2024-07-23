using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// SMS Templates
/// </summary>
public partial class SmsTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Applies to
    /// </summary>
    public int ModelId { get; set; }

    /// <summary>
    /// Sidebar action
    /// </summary>
    public int? SidebarActionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Template Filename
    /// </summary>
    public string? TemplateFs { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Body
    /// </summary>
    public string Body { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<CalendarAlarm> CalendarAlarms { get; set; } = new List<CalendarAlarm>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrActServer> IrActServers { get; set; } = new List<IrActServer>();

    public virtual ICollection<MailingMailing> MailingMailings { get; set; } = new List<MailingMailing>();

    public virtual IrModel ModelNavigation { get; set; } = null!;

    public virtual ICollection<ProjectProjectStage> ProjectProjectStages { get; set; } = new List<ProjectProjectStage>();

    public virtual ICollection<ProjectTaskType> ProjectTaskTypes { get; set; } = new List<ProjectTaskType>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual IrActWindow? SidebarAction { get; set; }

    public virtual ICollection<SmsComposer> SmsComposers { get; set; } = new List<SmsComposer>();

    public virtual ICollection<SmsTemplatePreview> SmsTemplatePreviews { get; set; } = new List<SmsTemplatePreview>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<SmsTemplateReset> SmsTemplateResets { get; set; } = new List<SmsTemplateReset>();
}
