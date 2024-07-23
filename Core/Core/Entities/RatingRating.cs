using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Rating
/// </summary>
public partial class RatingRating
{
    public int Id { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public int? ResModelId { get; set; }

    /// <summary>
    /// Document
    /// </summary>
    public int ResId { get; set; }

    /// <summary>
    /// Parent Related Document Model
    /// </summary>
    public int? ParentResModelId { get; set; }

    /// <summary>
    /// Parent Document
    /// </summary>
    public int? ParentResId { get; set; }

    /// <summary>
    /// Rated Operator
    /// </summary>
    public int? RatedPartnerId { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public int? MessageId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Resource name
    /// </summary>
    public string? ResName { get; set; }

    /// <summary>
    /// Document Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Parent Document Name
    /// </summary>
    public string? ParentResName { get; set; }

    /// <summary>
    /// Parent Document Model
    /// </summary>
    public string? ParentResModel { get; set; }

    /// <summary>
    /// Rating
    /// </summary>
    public string? RatingText { get; set; }

    /// <summary>
    /// Security Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Comment
    /// </summary>
    public string? Feedback { get; set; }

    /// <summary>
    /// Visible Internally Only
    /// </summary>
    public bool? IsInternal { get; set; }

    /// <summary>
    /// Filled Rating
    /// </summary>
    public bool? Consumed { get; set; }

    /// <summary>
    /// Submitted on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Rating Value
    /// </summary>
    public double? Rating { get; set; }

    /// <summary>
    /// Commented by
    /// </summary>
    public int? PublisherId { get; set; }

    /// <summary>
    /// Publisher comment
    /// </summary>
    public string? PublisherComment { get; set; }

    /// <summary>
    /// Commented on
    /// </summary>
    public DateTime? PublisherDatetime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? Message { get; set; }

    public virtual IrModel? ParentResModelNavigation { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartner? Publisher { get; set; }

    public virtual ResPartner? RatedPartner { get; set; }

    public virtual IrModel? ResModelNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
