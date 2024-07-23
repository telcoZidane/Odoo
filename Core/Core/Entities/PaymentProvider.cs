using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Payment Provider
/// </summary>
public partial class PaymentProvider
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Redirect Form Template
    /// </summary>
    public int? RedirectFormViewId { get; set; }

    /// <summary>
    /// Inline Form Template
    /// </summary>
    public int? InlineFormViewId { get; set; }

    /// <summary>
    /// Token Inline Form Template
    /// </summary>
    public int? TokenInlineFormViewId { get; set; }

    /// <summary>
    /// Express Checkout Form Template
    /// </summary>
    public int? ExpressCheckoutFormViewId { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Corresponding Module
    /// </summary>
    public int? ModuleId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// State
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Installation State
    /// </summary>
    public string? ModuleState { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Displayed as
    /// </summary>
    public string? DisplayAs { get; set; }

    /// <summary>
    /// Help Message
    /// </summary>
    public string? PreMsg { get; set; }

    /// <summary>
    /// Pending Message
    /// </summary>
    public string? PendingMsg { get; set; }

    /// <summary>
    /// Authorize Message
    /// </summary>
    public string? AuthMsg { get; set; }

    /// <summary>
    /// Done Message
    /// </summary>
    public string? DoneMsg { get; set; }

    /// <summary>
    /// Canceled Message
    /// </summary>
    public string? CancelMsg { get; set; }

    /// <summary>
    /// Maximum Amount
    /// </summary>
    public decimal? MaximumAmount { get; set; }

    /// <summary>
    /// Published
    /// </summary>
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Allow Saving Payment Methods
    /// </summary>
    public bool? AllowTokenization { get; set; }

    /// <summary>
    /// Capture Amount Manually
    /// </summary>
    public bool? CaptureManually { get; set; }

    /// <summary>
    /// Allow Express Checkout
    /// </summary>
    public bool? AllowExpressCheckout { get; set; }

    /// <summary>
    /// Add Extra Fees
    /// </summary>
    public bool? FeesActive { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Fixed domestic fees
    /// </summary>
    public double? FeesDomFixed { get; set; }

    /// <summary>
    /// Variable domestic fees (in percents)
    /// </summary>
    public double? FeesDomVar { get; set; }

    /// <summary>
    /// Fixed international fees
    /// </summary>
    public double? FeesIntFixed { get; set; }

    /// <summary>
    /// Variable international fees (in percents)
    /// </summary>
    public double? FeesIntVar { get; set; }

    /// <summary>
    /// Communication
    /// </summary>
    public string? SoReferenceType { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLines { get; set; } = new List<AccountPaymentMethodLine>();

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? ExpressCheckoutFormView { get; set; }

    public virtual IrUiView? InlineFormView { get; set; }

    public virtual IrModuleModule? Module { get; set; }

    public virtual ICollection<PaymentToken> PaymentTokens { get; set; } = new List<PaymentToken>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual IrUiView? RedirectFormView { get; set; }

    public virtual IrUiView? TokenInlineFormView { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResCountry> Countries { get; set; } = new List<ResCountry>();

    public virtual ICollection<PaymentIcon> PaymentIcons { get; set; } = new List<PaymentIcon>();
}
