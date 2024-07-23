using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ImLivechatReportChannel
{
    public int? Id { get; set; }

    public string? Uuid { get; set; }

    public int? ChannelId { get; set; }

    public string? ChannelName { get; set; }

    public string? TechnicalName { get; set; }

    public int? LivechatChannelId { get; set; }

    public DateTime? StartDate { get; set; }

    public string? StartDateHour { get; set; }

    public string? StartHour { get; set; }

    public double? DayNumber { get; set; }

    public double? Duration { get; set; }

    public double? TimeToAnswer { get; set; }

    public long? NbrSpeaker { get; set; }

    public long? NbrMessage { get; set; }

    public int? IsWithoutAnswer { get; set; }

    public double? DaysOfActivity { get; set; }

    public int? IsAnonymous { get; set; }

    public int? CountryId { get; set; }

    public int? IsHappy { get; set; }

    public double? Rating { get; set; }

    public string? RatingText { get; set; }

    public int? IsUnrated { get; set; }

    public int? PartnerId { get; set; }
}
