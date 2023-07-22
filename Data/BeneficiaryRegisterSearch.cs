using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUCOBADI.Data
{
    public class BeneficiaryRegisterSearch
    {
		public int?[] HouseHoldId { get; set; }
		public int?[] DistrictId { get; set; }
		public int?[] SubcountyId { get; set; }
		public int?[] ParishId { get; set; }
		public int?[] VillageId { get; set; }
		public int? QuarterId { get; set; }
		public int? YearId { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public int?[] GroupId { get; set; }
		public int?[] GroupTypeId { get; set; }
	}
}
