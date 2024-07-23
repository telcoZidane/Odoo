namespace OdooApi.Data.Dtos.Jobs
{
    public class JobDto
    {
        /// <summary>
        /// Job Position
        /// </summary>
        public string Name { get; set; } = null!;
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
        /// Requirements
        /// </summary>
        //public string? Requirements { get; set; }

        /// <summary>
        /// Active
        /// </summary>
        //public bool? Active { get; set; }

        public int? AddressId { get; set; }

        /// <summary>
        /// Department Manager
        /// </summary>
        public int? ManagerId { get; set; }
        //public string? JobDetails { get; set; }
  /// <summary>
        /// Target
        /// </summary>
        public int? NoOfRecruitment { get; set; }

        /// <summary>
        /// Is Published
        /// </summary>
        public bool? IsPublished { get; set; }

      
        /// <summary>
        /// Job Description
        /// </summary>
        public string? Description { get; set; }
    }
}
