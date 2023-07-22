using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace MUCOBADI.Repository.Dashboard
{
    public class HivStatHeiEidPositiveRepository : IHivStatHeiEidPositive
    {
        private readonly SPToCoreContext _context;

        public HivStatHeiEidPositiveRepository(SPToCoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<spDashboard_HEI_EID_PositiveResult>> 
            GetInfantsByDistrict(DateTime? startDate, DateTime? endDate,
                string districtId)
        {
            var data = await _context
                 .spDashboard_HEI_EID_PositiveAsync(districtId);
            return data;
        }
        
        async Task<IEnumerable<spDashboard_HEI_EID_Positive_SubcountyResult>> 
        IHivStatHeiEidPositive.GetInfantsBySubcounty(string districtId, string subcountyId)
        {
            var data = await _context
                .spDashboard_HEI_EID_Positive_SubcountyAsync(districtId, subcountyId);
            return data;
        }
    }
}
