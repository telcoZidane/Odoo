using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Job Position
/// </summary>
public partial class HrJob
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
    /// Total Forecasted Employees
    /// </summary>
    public int? ExpectedEmployees { get; set; }

    /// <summary>
    /// Current Number of Employees
    /// </summary>
    public int? NoOfEmployee { get; set; }

    /// <summary>
    /// Target
    /// </summary>
    public int? NoOfRecruitment { get; set; }

    /// <summary>
    /// Hired Employees
    /// </summary>
    public int? NoOfHiredEmployee { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Employment Type
    /// </summary>
    public int? ContractTypeId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Job Position
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Job Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Requirements
    /// </summary>
    public string? Requirements { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Alias
    /// </summary>
    public int AliasId { get; set; }

    /// <summary>
    /// Job Location
    /// </summary>
    public int? AddressId { get; set; }

    /// <summary>
    /// Department Manager
    /// </summary>
    public int? ManagerId { get; set; }

    /// <summary>
    /// Recruiter
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// HR Responsible
    /// </summary>
    public int? HrResponsibleId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

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
    /// Website description
    /// </summary>
    public string? WebsiteDescription { get; set; }

    /// <summary>
    /// Process Details
    /// </summary>
    public string? JobDetails { get; set; }

    /// <summary>
    /// Is Published
    /// </summary>
    public bool? IsPublished { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual MailAlias Alias { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual HrContractType? ContractType { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrContract> HrContracts { get; set; } = new List<HrContract>();

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrRecruitmentSource> HrRecruitmentSources { get; set; } = new List<HrRecruitmentSource>();

    public virtual ResUser? HrResponsible { get; set; }

    public virtual HrEmployee? Manager { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrRecruitmentStage> HrRecruitmentStages { get; set; } = new List<HrRecruitmentStage>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ICollection<ResUser> ResUsersNavigation { get; set; } = new List<ResUser>();

    public virtual ICollection<ResUser> Users { get; set; } = new List<ResUser>();
}
