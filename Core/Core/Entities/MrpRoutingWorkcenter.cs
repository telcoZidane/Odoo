using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Work Center Usage
/// </summary>
public partial class MrpRoutingWorkcenter
{
    public int Id { get; set; }

    /// <summary>
    /// Work Center
    /// </summary>
    public int WorkcenterId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Bill of Material
    /// </summary>
    public int BomId { get; set; }

    /// <summary>
    /// Based on
    /// </summary>
    public int? TimeModeBatch { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Operation
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Worksheet
    /// </summary>
    public string? WorksheetType { get; set; }

    /// <summary>
    /// Google Slide
    /// </summary>
    public string? WorksheetGoogleSlide { get; set; }

    /// <summary>
    /// Duration Computation
    /// </summary>
    public string? TimeMode { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Note { get; set; }

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

    /// <summary>
    /// Manual Duration
    /// </summary>
    public double? TimeCycleManual { get; set; }

    public virtual MrpBom Bom { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; set; } = new List<MrpBomByproduct>();

    public virtual ICollection<MrpBomLine> MrpBomLines { get; set; } = new List<MrpBomLine>();

    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; set; } = new List<MrpWorkorder>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual MrpWorkcenter Workcenter { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpRoutingWorkcenter> BlockedBies { get; set; } = new List<MrpRoutingWorkcenter>();

    public virtual ICollection<MrpRoutingWorkcenter> Operations { get; set; } = new List<MrpRoutingWorkcenter>();

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; set; } = new List<ProductTemplateAttributeValue>();
}
