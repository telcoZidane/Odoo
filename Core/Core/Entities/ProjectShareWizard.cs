using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Project Sharing
/// </summary>
public partial class ProjectShareWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Related Document ID
    /// </summary>
    public int ResId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public string ResModel { get; set; } = null!;

    /// <summary>
    /// Access Mode
    /// </summary>
    public string? AccessMode { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Display Access Mode
    /// </summary>
    public bool? DisplayAccessMode { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();
}
