using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Course
/// </summary>
public partial class SlideChannel
{
    public int Id { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Promoted Slide
    /// </summary>
    public int? PromotedSlideId { get; set; }

    /// <summary>
    /// Documents
    /// </summary>
    public int? NbrDocument { get; set; }

    /// <summary>
    /// Videos
    /// </summary>
    public int? NbrVideo { get; set; }

    /// <summary>
    /// Infographics
    /// </summary>
    public int? NbrInfographic { get; set; }

    /// <summary>
    /// Articles
    /// </summary>
    public int? NbrArticle { get; set; }

    /// <summary>
    /// Number of Quizs
    /// </summary>
    public int? NbrQuiz { get; set; }

    /// <summary>
    /// Number of Contents
    /// </summary>
    public int? TotalSlides { get; set; }

    /// <summary>
    /// Visits
    /// </summary>
    public int? TotalViews { get; set; }

    /// <summary>
    /// Votes
    /// </summary>
    public int? TotalVotes { get; set; }

    /// <summary>
    /// New Content Notification
    /// </summary>
    public int? PublishTemplateId { get; set; }

    /// <summary>
    /// Channel Share Template
    /// </summary>
    public int? ShareChannelTemplateId { get; set; }

    /// <summary>
    /// Share Template
    /// </summary>
    public int? ShareSlideTemplateId { get; set; }

    /// <summary>
    /// Completion Notification
    /// </summary>
    public int? CompletedTemplateId { get; set; }

    /// <summary>
    /// Lesson voted
    /// </summary>
    public int? KarmaGenSlideVote { get; set; }

    /// <summary>
    /// Course ranked
    /// </summary>
    public int? KarmaGenChannelRank { get; set; }

    /// <summary>
    /// Course finished
    /// </summary>
    public int? KarmaGenChannelFinish { get; set; }

    /// <summary>
    /// Add Review
    /// </summary>
    public int? KarmaReview { get; set; }

    /// <summary>
    /// Add Comment
    /// </summary>
    public int? KarmaSlideComment { get; set; }

    /// <summary>
    /// Vote
    /// </summary>
    public int? KarmaSlideVote { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Website opengraph image
    /// </summary>
    public string? WebsiteMetaOgImg { get; set; }

    /// <summary>
    /// Course type
    /// </summary>
    public string ChannelType { get; set; } = null!;

    /// <summary>
    /// Featured Content
    /// </summary>
    public string? PromoteStrategy { get; set; }

    /// <summary>
    /// Security Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Enroll Policy
    /// </summary>
    public string Enroll { get; set; } = null!;

    /// <summary>
    /// Visibility
    /// </summary>
    public string Visibility { get; set; } = null!;

    /// <summary>
    /// Last Update
    /// </summary>
    public DateOnly? SlideLastUpdate { get; set; }

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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Short Description
    /// </summary>
    public string? DescriptionShort { get; set; }

    /// <summary>
    /// Detailed Description
    /// </summary>
    public string? DescriptionHtml { get; set; }

    /// <summary>
    /// Enroll Message
    /// </summary>
    public string? EnrollMsg { get; set; }

    /// <summary>
    /// Cover Properties
    /// </summary>
    public string? CoverProperties { get; set; }

    /// <summary>
    /// Duration
    /// </summary>
    public decimal? TotalTime { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Allow rating on Course
    /// </summary>
    public bool? AllowComment { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Rating Last Value
    /// </summary>
    public double? RatingLastValue { get; set; }

    /// <summary>
    /// Number of Certifications
    /// </summary>
    public int? NbrCertification { get; set; }

    public virtual MailTemplate? CompletedTemplate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrResumeLine> HrResumeLines { get; set; } = new List<HrResumeLine>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual SlideSlide? PromotedSlide { get; set; }

    public virtual MailTemplate? PublishTemplate { get; set; }

    public virtual MailTemplate? ShareChannelTemplate { get; set; }

    public virtual MailTemplate? ShareSlideTemplate { get; set; }

    public virtual ICollection<SlideChannelInvite> SlideChannelInvites { get; set; } = new List<SlideChannelInvite>();

    public virtual ICollection<SlideChannelPartner> SlideChannelPartners { get; set; } = new List<SlideChannelPartner>();

    public virtual ICollection<SlideSlidePartner> SlideSlidePartners { get; set; } = new List<SlideSlidePartner>();

    public virtual ICollection<SlideSlide> SlideSlides { get; set; } = new List<SlideSlide>();

    public virtual ResUser? User { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResGroup> Groups { get; set; } = new List<ResGroup>();

    public virtual ICollection<ResGroup> ResGroups { get; set; } = new List<ResGroup>();

    public virtual ICollection<SlideChannelTag> Tags { get; set; } = new List<SlideChannelTag>();
}
