using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class MailingTraceReport
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? MailingType { get; set; }

    public string? Campaign { get; set; }

    public DateTime? ScheduledDate { get; set; }

    public string? State { get; set; }

    public string? EmailFrom { get; set; }

    public long? Scheduled { get; set; }

    public long? Sent { get; set; }

    public long? Delivered { get; set; }

    public long? Error { get; set; }

    public long? Bounced { get; set; }

    public long? Canceled { get; set; }

    public long? Opened { get; set; }

    public long? Replied { get; set; }

    public long? Clicked { get; set; }
}
