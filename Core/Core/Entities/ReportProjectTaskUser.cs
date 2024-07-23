using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ReportProjectTaskUser
{
    public int? Nbr { get; set; }

    public int? Id { get; set; }

    public int? TaskId { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? DateAssign { get; set; }

    public DateTime? DateEnd { get; set; }

    public DateTime? DateLastStageUpdate { get; set; }

    public DateOnly? DateDeadline { get; set; }

    public int? ProjectId { get; set; }

    public string? Priority { get; set; }

    public string? Name { get; set; }

    public int? CompanyId { get; set; }

    public int? PartnerId { get; set; }

    public int? ParentId { get; set; }

    public int? AncestorId { get; set; }

    public int? StageId { get; set; }

    public bool? IsClosed { get; set; }

    public string? State { get; set; }

    public int? MilestoneId { get; set; }

    public bool? MilestoneReached { get; set; }

    public DateOnly? MilestoneDeadline { get; set; }

    public double? RatingLastValue { get; set; }

    public double? RatingAvg { get; set; }

    public double? WorkingDaysClose { get; set; }

    public double? WorkingDaysOpen { get; set; }

    public decimal? WorkingHoursOpen { get; set; }

    public decimal? WorkingHoursClose { get; set; }

    public double? DelayEndingsDays { get; set; }

    public int? SaleLineId { get; set; }

    public int? SaleOrderId { get; set; }
}
