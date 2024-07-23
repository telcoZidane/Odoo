using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event
/// </summary>
public partial class EventEvent
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Organizer
    /// </summary>
    public int? OrganizerId { get; set; }

    /// <summary>
    /// Template
    /// </summary>
    public int? EventTypeId { get; set; }

    /// <summary>
    /// Stage
    /// </summary>
    public int? StageId { get; set; }

    /// <summary>
    /// Maximum Attendees
    /// </summary>
    public int? SeatsMax { get; set; }

    /// <summary>
    /// Venue
    /// </summary>
    public int? AddressId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Kanban State
    /// </summary>
    public string? KanbanState { get; set; }

    /// <summary>
    /// Kanban State Label
    /// </summary>
    public string? KanbanStateLabel { get; set; }

    /// <summary>
    /// Timezone
    /// </summary>
    public string DateTz { get; set; } = null!;

    /// <summary>
    /// Event
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Ticket Instructions
    /// </summary>
    public string? TicketInstructions { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Limit Attendees
    /// </summary>
    public bool SeatsLimited { get; set; }

    /// <summary>
    /// Autoconfirmation
    /// </summary>
    public bool? AutoConfirm { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime DateBegin { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateTime DateEnd { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Event Menu
    /// </summary>
    public int? MenuId { get; set; }

    /// <summary>
    /// Website opengraph image
    /// </summary>
    public string? WebsiteMetaOgImg { get; set; }

    /// <summary>
    /// Website meta title
    /// </summary>
    public string? WebsiteMetaTitle { get; set; }

    /// <summary>
    /// Website meta description
    /// </summary>
    public string? WebsiteMetaDescription { get; set; }

    /// <summary>
    /// Website meta keywords
    /// </summary>
    public string? WebsiteMetaKeywords { get; set; }

    /// <summary>
    /// Seo name
    /// </summary>
    public string? SeoName { get; set; }

    /// <summary>
    /// Event Subtitle
    /// </summary>
    public string? Subtitle { get; set; }

    /// <summary>
    /// Cover Properties
    /// </summary>
    public string? CoverProperties { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Website Menu
    /// </summary>
    public bool? WebsiteMenu { get; set; }

    /// <summary>
    /// Extra Register Button
    /// </summary>
    public bool? MenuRegisterCta { get; set; }

    /// <summary>
    /// Introduction Menu
    /// </summary>
    public bool? IntroductionMenu { get; set; }

    /// <summary>
    /// Location Menu
    /// </summary>
    public bool? LocationMenu { get; set; }

    /// <summary>
    /// Register Menu
    /// </summary>
    public bool? RegisterMenu { get; set; }

    /// <summary>
    /// Community Menu
    /// </summary>
    public bool? CommunityMenu { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ICollection<EventEventConfigurator> EventEventConfigurators { get; set; } = new List<EventEventConfigurator>();

    public virtual ICollection<EventEventTicket> EventEventTickets { get; set; } = new List<EventEventTicket>();

    public virtual ICollection<EventLeadRule> EventLeadRules { get; set; } = new List<EventLeadRule>();

    public virtual ICollection<EventMail> EventMails { get; set; } = new List<EventMail>();

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual EventType? EventType { get; set; }

    public virtual WebsiteMenu? Menu { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Organizer { get; set; }

    public virtual ICollection<RegistrationEditorLine> RegistrationEditorLines { get; set; } = new List<RegistrationEditorLine>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual EventStage? Stage { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ICollection<WebsiteEventMenu> WebsiteEventMenus { get; set; } = new List<WebsiteEventMenu>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<EventTag> EventTags { get; set; } = new List<EventTag>();
}
