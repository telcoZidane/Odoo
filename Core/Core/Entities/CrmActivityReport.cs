using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class CrmActivityReport
{
    public int? Id { get; set; }

    public DateTime? LeadCreateDate { get; set; }

    public DateTime? DateConversion { get; set; }

    public DateOnly? DateDeadline { get; set; }

    public DateTime? DateClosed { get; set; }

    public int? SubtypeId { get; set; }

    public int? MailActivityTypeId { get; set; }

    public int? AuthorId { get; set; }

    public DateTime? Date { get; set; }

    public string? Body { get; set; }

    public int? LeadId { get; set; }

    public int? UserId { get; set; }

    public int? TeamId { get; set; }

    public int? CountryId { get; set; }

    public int? CompanyId { get; set; }

    public int? StageId { get; set; }

    public int? PartnerId { get; set; }

    public string? LeadType { get; set; }

    public bool? Active { get; set; }
}
