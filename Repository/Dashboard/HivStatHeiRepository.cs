using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace MUCOBADI.Repository.Dashboard
{
    public class HivStatHeiRepository : IHivStatHei
    {
        private readonly SPToCoreContext _context;

        public HivStatHeiRepository(SPToCoreContext context)
        {
            _context = context; 
        }

        public async Task<IEnumerable<spDashboard_HEIResult>> 
            GetInfantsByDistrict(DateTime? startDate, DateTime? endDate,
                string districtId)
        {
            var data = await _context
                .spDashboard_HEIAsync(districtId);
            return data;
        }

        async Task<IEnumerable<spDashboard_HEI_SubcountyResult>> 
        IHivStatHei.GetInfantsBySubcounty(string districtId, string subcountyId)
        {
            var data = await _context
                .spDashboard_HEI_SubcountyAsync(districtId, subcountyId);
            return data;
        }
    }
}
