using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Country
/// </summary>
public partial class ResCountry
{
    public int Id { get; set; }

    /// <summary>
    /// Input View
    /// </summary>
    public int? AddressViewId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Country Calling Code
    /// </summary>
    public int? PhoneCode { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Country Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Customer Name Position
    /// </summary>
    public string? NamePosition { get; set; }

    /// <summary>
    /// Country Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Vat Label
    /// </summary>
    public string? VatLabel { get; set; }

    /// <summary>
    /// Layout in Reports
    /// </summary>
    public string? AddressFormat { get; set; }

    /// <summary>
    /// State Required
    /// </summary>
    public bool? StateRequired { get; set; }

    /// <summary>
    /// Zip Required
    /// </summary>
    public bool? ZipRequired { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAccountTag> AccountAccountTags { get; set; } = new List<AccountAccountTag>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplates { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; set; } = new List<AccountFiscalPositionTemplate>();

    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; set; } = new List<AccountFiscalPosition>();

    public virtual ICollection<AccountReport> AccountReports { get; set; } = new List<AccountReport>();

    public virtual ICollection<AccountTaxGroup> AccountTaxGroups { get; set; } = new List<AccountTaxGroup>();

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();

    public virtual IrUiView? AddressView { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ResCurrency? Currency { get; set; }

    public virtual ICollection<EventEvent> EventEvents { get; set; } = new List<EventEvent>();

    public virtual ICollection<HrEmployee> HrEmployeeCountries { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> HrEmployeeCountryOfBirthNavigations { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypes { get; set; } = new List<HrPayrollStructureType>();

    public virtual ICollection<LinkTrackerClick> LinkTrackerClicks { get; set; } = new List<LinkTrackerClick>();

    public virtual ICollection<MailChannel> MailChannels { get; set; } = new List<MailChannel>();

    public virtual ICollection<MailGuest> MailGuests { get; set; } = new List<MailGuest>();

    public virtual ICollection<MailingContact> MailingContacts { get; set; } = new List<MailingContact>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual ICollection<ResBank> ResBanks { get; set; } = new List<ResBank>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCountryState> ResCountryStates { get; set; } = new List<ResCountryState>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; set; } = new List<SnailmailLetterMissingRequiredField>();

    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; set; } = new List<SnailmailLetter>();

    public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; set; } = new List<WebsiteVisitor>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ImLivechatChannelRule> Channels { get; set; } = new List<ImLivechatChannelRule>();

    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequests { get; set; } = new List<CrmIapLeadMiningRequest>();

    public virtual ICollection<PaymentProvider> Payments { get; set; } = new List<PaymentProvider>();

    public virtual ICollection<ResCountryGroup> ResCountryGroups { get; set; } = new List<ResCountryGroup>();
}
