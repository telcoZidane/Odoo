using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Recycling Record
/// </summary>
public partial class DataRecycleRecord
{
    public int Id { get; set; }

    /// <summary>
    /// Recycle Model
    /// </summary>
    public int? RecycleModelId { get; set; }

    /// <summary>
    /// Record ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int? ResModelId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Model Name
    /// </summary>
    public string? ResModelName { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

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

    public virtual DataRecycleModel? RecycleModel { get; set; }

    public virtual IrModel? ResModel { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
