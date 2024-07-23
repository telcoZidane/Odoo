using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Models
/// </summary>
public partial class IrModel
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public string Model { get; set; } = null!;

    /// <summary>
    /// Order
    /// </summary>
    public string Order { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Model Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Information
    /// </summary>
    public string? Info { get; set; }

    /// <summary>
    /// Transient Model
    /// </summary>
    public bool? Transient { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Has Mail Thread
    /// </summary>
    public bool? IsMailThread { get; set; }

    /// <summary>
    /// Has Mail Activity
    /// </summary>
    public bool? IsMailActivity { get; set; }

    /// <summary>
    /// Has Mail Blacklist
    /// </summary>
    public bool? IsMailBlacklist { get; set; }

    /// <summary>
    /// Field for custom form data
    /// </summary>
    public int? WebsiteFormDefaultFieldId { get; set; }

    /// <summary>
    /// Label for form action
    /// </summary>
    public string? WebsiteFormLabel { get; set; }

    /// <summary>
    /// Website Form Key
    /// </summary>
    public string? WebsiteFormKey { get; set; }

    /// <summary>
    /// Allowed to use in forms
    /// </summary>
    public bool? WebsiteFormAccess { get; set; }

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<DataRecycleModel> DataRecycleModels { get; set; } = new List<DataRecycleModel>();

    public virtual ICollection<DataRecycleRecord> DataRecycleRecords { get; set; } = new List<DataRecycleRecord>();

    public virtual ICollection<FetchmailServer> FetchmailServers { get; set; } = new List<FetchmailServer>();

    public virtual ICollection<GamificationGoalDefinition> GamificationGoalDefinitions { get; set; } = new List<GamificationGoalDefinition>();

    public virtual ICollection<IrActClient> IrActClients { get; set; } = new List<IrActClient>();

    public virtual ICollection<IrActReportXml> IrActReportXmls { get; set; } = new List<IrActReportXml>();

    public virtual ICollection<IrActServer> IrActServerBindingModels { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerCrudModels { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerModels { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActUrl> IrActUrls { get; set; } = new List<IrActUrl>();

    public virtual ICollection<IrActWindow> IrActWindows { get; set; } = new List<IrActWindow>();

    public virtual ICollection<IrAction> IrActions { get; set; } = new List<IrAction>();

    public virtual ICollection<IrModelAccess> IrModelAccesses { get; set; } = new List<IrModelAccess>();

    public virtual ICollection<IrModelConstraint> IrModelConstraints { get; set; } = new List<IrModelConstraint>();

    public virtual ICollection<IrModelField> IrModelFields { get; set; } = new List<IrModelField>();

    public virtual ICollection<IrModelRelation> IrModelRelations { get; set; } = new List<IrModelRelation>();

    public virtual ICollection<IrRule> IrRules { get; set; } = new List<IrRule>();

    public virtual ICollection<MailActivity> MailActivities { get; set; } = new List<MailActivity>();

    public virtual ICollection<MailAlias> MailAliasAliasModels { get; set; } = new List<MailAlias>();

    public virtual ICollection<MailAlias> MailAliasAliasParentModels { get; set; } = new List<MailAlias>();

    public virtual ICollection<MailTemplate> MailTemplates { get; set; } = new List<MailTemplate>();

    public virtual ICollection<MailingFilter> MailingFilters { get; set; } = new List<MailingFilter>();

    public virtual ICollection<MailingMailing> MailingMailings { get; set; } = new List<MailingMailing>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual ICollection<PrivacyLookupWizardLine> PrivacyLookupWizardLines { get; set; } = new List<PrivacyLookupWizardLine>();

    public virtual ICollection<RatingRating> RatingRatingParentResModelNavigations { get; set; } = new List<RatingRating>();

    public virtual ICollection<RatingRating> RatingRatingResModelNavigations { get; set; } = new List<RatingRating>();

    public virtual ICollection<SmsTemplate> SmsTemplates { get; set; } = new List<SmsTemplate>();

    public virtual IrModelField? WebsiteFormDefaultField { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
