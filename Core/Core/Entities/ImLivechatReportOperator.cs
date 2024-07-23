using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ImLivechatReportOperator
{
    public long? Id { get; set; }

    public int? PartnerId { get; set; }

    public int? LivechatChannelId { get; set; }

    public long? NbrChannel { get; set; }

    public int? ChannelId { get; set; }

    public DateTime? StartDate { get; set; }

    public double? Duration { get; set; }

    public double? TimeToAnswer { get; set; }
}
