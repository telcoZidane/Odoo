using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// User Settings Volumes
/// </summary>
public partial class ResUsersSettingsVolume
{
    public int Id { get; set; }

    /// <summary>
    /// User Setting
    /// </summary>
    public int UserSettingId { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Guest
    /// </summary>
    public int? GuestId { get; set; }

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

    /// <summary>
    /// Volume
    /// </summary>
    public double? Volume { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Guest { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUsersSetting UserSetting { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
