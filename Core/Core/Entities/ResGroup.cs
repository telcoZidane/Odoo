using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ResGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// Application
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Comment
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Share Group
    /// </summary>
    public bool? Share { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual IrModuleCategory? Category { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<DigestTip> DigestTips { get; set; } = new List<DigestTip>();

    public virtual ICollection<IrModelAccess> IrModelAccesses { get; set; } = new List<IrModelAccess>();

    public virtual ICollection<MailChannel> MailChannels { get; set; } = new List<MailChannel>();

    public virtual ICollection<PosConfig> PosConfigGroupPosManagers { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosConfig> PosConfigGroupPosUsers { get; set; } = new List<PosConfig>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrActServer> Acts { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActWindow> ActsNavigation { get; set; } = new List<IrActWindow>();

    public virtual ICollection<SlideChannel> Channels { get; set; } = new List<SlideChannel>();

    public virtual ICollection<IrModelField> Fields { get; set; } = new List<IrModelField>();

    public virtual ICollection<ResGroup> Gids { get; set; } = new List<ResGroup>();

    public virtual ICollection<ResGroup> Hids { get; set; } = new List<ResGroup>();

    public virtual ICollection<MailChannel> MailChannelsNavigation { get; set; } = new List<MailChannel>();

    public virtual ICollection<IrUiMenu> Menus { get; set; } = new List<IrUiMenu>();

    public virtual ICollection<IrRule> RuleGroups { get; set; } = new List<IrRule>();

    public virtual ICollection<SlideChannel> SlideChannels { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboards { get; set; } = new List<SpreadsheetDashboard>();

    public virtual ICollection<IrActReportXml> Uids { get; set; } = new List<IrActReportXml>();

    public virtual ICollection<ResUser> UidsNavigation { get; set; } = new List<ResUser>();

    public virtual ICollection<IrUiView> Views { get; set; } = new List<IrUiView>();
}
