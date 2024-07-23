using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// User Settings
/// </summary>
public partial class ResUsersSetting
{
    public int Id { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Duration of voice activity in ms
    /// </summary>
    public int? VoiceActiveDuration { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Push-To-Talk shortcut
    /// </summary>
    public string? PushToTalkKey { get; set; }

    /// <summary>
    /// Is discuss sidebar category channel open?
    /// </summary>
    public bool? IsDiscussSidebarCategoryChannelOpen { get; set; }

    /// <summary>
    /// Is discuss sidebar category chat open?
    /// </summary>
    public bool? IsDiscussSidebarCategoryChatOpen { get; set; }

    /// <summary>
    /// Use the push to talk feature
    /// </summary>
    public bool? UsePushToTalk { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Is category livechat open
    /// </summary>
    public bool? IsDiscussSidebarCategoryLivechatOpen { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumes { get; set; } = new List<ResUsersSettingsVolume>();

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
