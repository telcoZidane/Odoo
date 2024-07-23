using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Slides
/// </summary>
public partial class SlideSlide
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Uploaded by
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Course
    /// </summary>
    public int ChannelId { get; set; }

    /// <summary>
    /// Section
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Reward: first attempt
    /// </summary>
    public int? QuizFirstAttemptReward { get; set; }

    /// <summary>
    /// Reward: second attempt
    /// </summary>
    public int? QuizSecondAttemptReward { get; set; }

    /// <summary>
    /// Reward: third attempt
    /// </summary>
    public int? QuizThirdAttemptReward { get; set; }

    /// <summary>
    /// Reward: every attempt after the third try
    /// </summary>
    public int? QuizFourthAttemptReward { get; set; }

    /// <summary>
    /// Likes
    /// </summary>
    public int? Likes { get; set; }

    /// <summary>
    /// Dislikes
    /// </summary>
    public int? Dislikes { get; set; }

    /// <summary>
    /// # of Website Views
    /// </summary>
    public int? SlideViews { get; set; }

    /// <summary>
    /// # of Public Views
    /// </summary>
    public int? PublicViews { get; set; }

    /// <summary>
    /// # Total Views
    /// </summary>
    public int? TotalViews { get; set; }

    /// <summary>
    /// Number of Documents
    /// </summary>
    public int? NbrDocument { get; set; }

    /// <summary>
    /// Number of Videos
    /// </summary>
    public int? NbrVideo { get; set; }

    /// <summary>
    /// Number of Images
    /// </summary>
    public int? NbrInfographic { get; set; }

    /// <summary>
    /// Number of Articles
    /// </summary>
    public int? NbrArticle { get; set; }

    /// <summary>
    /// Number of Quizs
    /// </summary>
    public int? NbrQuiz { get; set; }

    /// <summary>
    /// Total Slides
    /// </summary>
    public int? TotalSlides { get; set; }

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
    /// Category
    /// </summary>
    public string SlideCategory { get; set; } = null!;

    /// <summary>
    /// Source Type
    /// </summary>
    public string SourceType { get; set; } = null!;

    /// <summary>
    /// External URL
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Slide Type
    /// </summary>
    public string? SlideType { get; set; }

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
    /// Title
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// HTML Content
    /// </summary>
    public string? HtmlContent { get; set; }

    /// <summary>
    /// Duration
    /// </summary>
    public decimal? CompletionTime { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Allow Preview
    /// </summary>
    public bool? IsPreview { get; set; }

    /// <summary>
    /// Is a category
    /// </summary>
    public bool? IsCategory { get; set; }

    /// <summary>
    /// Allow Download
    /// </summary>
    public bool? SlideResourceDownloadable { get; set; }

    /// <summary>
    /// Publish Date
    /// </summary>
    public DateTime? DatePublished { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Certification
    /// </summary>
    public int? SurveyId { get; set; }

    /// <summary>
    /// Number of Certifications
    /// </summary>
    public int? NbrCertification { get; set; }

    public virtual SlideSlide? Category { get; set; }

    public virtual SlideChannel Channel { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<SlideSlide> InverseCategory { get; set; } = new List<SlideSlide>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<SlideChannel> SlideChannels { get; set; } = new List<SlideChannel>();

    public virtual ICollection<SlideEmbed> SlideEmbeds { get; set; } = new List<SlideEmbed>();

    public virtual ICollection<SlideQuestion> SlideQuestions { get; set; } = new List<SlideQuestion>();

    public virtual ICollection<SlideSlidePartner> SlideSlidePartners { get; set; } = new List<SlideSlidePartner>();

    public virtual ICollection<SlideSlideResource> SlideSlideResources { get; set; } = new List<SlideSlideResource>();

    public virtual SurveySurvey? Survey { get; set; }

    public virtual ICollection<SurveyUserInput> SurveyUserInputs { get; set; } = new List<SurveyUserInput>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<SlideTag> Tags { get; set; } = new List<SlideTag>();
}
