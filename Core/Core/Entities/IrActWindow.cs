using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class IrActWindow
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
    /// View Ref.
    /// </summary>
    public int? ViewId { get; set; }

    /// <summary>
    /// Record ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Limit
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Search View Ref.
    /// </summary>
    public int? SearchViewId { get; set; }

    /// <summary>
    /// Domain Value
    /// </summary>
    public string? Domain { get; set; }

    /// <summary>
    /// Context Value
    /// </summary>
    public string Context { get; set; } = null!;

    /// <summary>
    /// Destination Model
    /// </summary>
    public string ResModel { get; set; } = null!;

    /// <summary>
    /// Target Window
    /// </summary>
    public string? Target { get; set; }

    /// <summary>
    /// View Mode
    /// </summary>
    public string ViewMode { get; set; } = null!;

    /// <summary>
    /// Action Usage
    /// </summary>
    public string? Usage { get; set; }

    /// <summary>
    /// Filter
    /// </summary>
    public bool? Filter { get; set; }

    public virtual ICollection<AccountReportColumn> AccountReportColumns { get; set; } = new List<AccountReportColumn>();

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<GamificationGoalDefinition> GamificationGoalDefinitions { get; set; } = new List<GamificationGoalDefinition>();

    public virtual ICollection<IrActWindowView> IrActWindowViews { get; set; } = new List<IrActWindowView>();

    public virtual ICollection<MailTemplate> MailTemplates { get; set; } = new List<MailTemplate>();

    public virtual IrUiView? SearchView { get; set; }

    public virtual ICollection<SmsTemplate> SmsTemplates { get; set; } = new List<SmsTemplate>();

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResGroup> Gids { get; set; } = new List<ResGroup>();
}
