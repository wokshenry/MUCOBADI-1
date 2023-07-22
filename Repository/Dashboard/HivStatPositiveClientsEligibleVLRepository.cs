using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace MUCOBADI.Repository.Dashboard
{
    public class HivStatPositiveClientsEligibleVLRepository : IHivStatPositiveClientsEligibleVL
    {
        private readonly SPToCoreContext _context;

        public HivStatPositiveClientsEligibleVLRepository(SPToCoreContext context)
        {
            _context = context;
        }

        async Task<IEnumerable<spDashboard_PositiveClientsEligibleVL_DistrictResult>>
           IHivStatPositiveClientsEligibleVL.GetByDistrict(DateTime? startDate,
           DateTime? endDate, string districtId)
        {
            var data = await _context
                .spDashboard_PositiveClientsEligibleVL_DistrictAsync(districtId, null, null);
            return data;
        }

        public async Task<IEnumerable<spDashboard_PositiveClientsEligibleVL_SubcountyResult>> 
        GetBySubcounty(DateTime? startDate, DateTime? endDate, 
            string district, string subcounty)
        {
           var data = await _context
               .spDashboard_PositiveClientsEligibleVL_SubcountyAsync(
                    district, subcounty, null, null);
           return data;
        }
    }
}
