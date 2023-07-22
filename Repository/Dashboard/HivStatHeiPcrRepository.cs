using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace MUCOBADI.Repository.Dashboard
{
    public class HivStatHeiPcrRepository : IHivStatHeiPcr
    {
        private readonly SPToCoreContext _context;

        public HivStatHeiPcrRepository(SPToCoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<spDashboard_HEI_PCR_TestResult>> 
            GetInfantsByDistrict(DateTime? startDate, DateTime? endDate,
                string districtId)
        {
            var data = await _context
                .spDashboard_HEI_PCR_TestAsync(districtId);
            return data;
        }
        
        async Task<IEnumerable<spDashboard_HEI_PCR_Test_SubcountyResult>> 
        IHivStatHeiPcr.GetInfantsBySubcounty(string districtId, string subcountyId)
        {
            var data = await _context
                .spDashboard_HEI_PCR_Test_SubcountyAsync(districtId, subcountyId);
            return data;
        }
    }
}
