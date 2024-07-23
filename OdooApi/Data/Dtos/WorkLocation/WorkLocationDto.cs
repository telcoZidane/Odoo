using Core.Core.Entities;

namespace OdooApi.Data.Dtos.WorkLocation
{
    public class WorkLocationDto
    {
        /// <summary>
        /// Company
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// Work Address
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Work Location
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Active
        /// </summary>
        public bool? Active { get; set; }

    }
}
