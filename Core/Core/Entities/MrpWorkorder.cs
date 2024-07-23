using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Work Order
/// </summary>
public partial class MrpWorkorder
{
    public int Id { get; set; }

    /// <summary>
    /// Work Center
    /// </summary>
    public int WorkcenterId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// Manufacturing Order
    /// </summary>
    public int ProductionId { get; set; }

    /// <summary>
    /// Leave
    /// </summary>
    public int? LeaveId { get; set; }

    /// <summary>
    /// Duration Deviation (%)
    /// </summary>
    public int? DurationPercent { get; set; }

    /// <summary>
    /// Operation
    /// </summary>
    public int? OperationId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Work Order
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Stock Availability
    /// </summary>
    public string? ProductionAvailability { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal? QtyProduced { get; set; }

    /// <summary>
    /// Expected Duration
    /// </summary>
    public decimal? DurationExpected { get; set; }

    /// <summary>
    /// Carried Quantity
    /// </summary>
    public decimal? QtyReportedFromPreviousWo { get; set; }

    /// <summary>
    /// Scheduled Start Date
    /// </summary>
    public DateTime? DatePlannedStart { get; set; }

    /// <summary>
    /// Scheduled End Date
    /// </summary>
    public DateTime? DatePlannedFinished { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime? DateStart { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateTime? DateFinished { get; set; }

    /// <summary>
    /// Production Date
    /// </summary>
    public DateTime? ProductionDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Real Duration
    /// </summary>
    public double? Duration { get; set; }

    /// <summary>
    /// Duration Per Unit
    /// </summary>
    public double? DurationUnit { get; set; }

    /// <summary>
    /// Cost per hour
    /// </summary>
    public double? CostsHour { get; set; }

    /// <summary>
    /// Mo Analytic Account Line
    /// </summary>
    public int? MoAnalyticAccountLineId { get; set; }

    /// <summary>
    /// Wc Analytic Account Line
    /// </summary>
    public int? WcAnalyticAccountLineId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceCalendarLeaf? Leave { get; set; }

    public virtual AccountAnalyticLine? MoAnalyticAccountLine { get; set; }

    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; set; } = new List<MrpWorkcenterProductivity>();

    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom ProductUom { get; set; } = null!;

    public virtual MrpProduction Production { get; set; } = null!;

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual AccountAnalyticLine? WcAnalyticAccountLine { get; set; }

    public virtual MrpWorkcenter Workcenter { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpWorkorder> BlockedBies { get; set; } = new List<MrpWorkorder>();

    public virtual ICollection<MrpWorkorder> Workorders { get; set; } = new List<MrpWorkorder>();
}
