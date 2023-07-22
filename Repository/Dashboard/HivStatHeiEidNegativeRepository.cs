using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace MUCOBADI.Repository.Dashboard
{
    public class HivStatHeiEidNegativeRepository : IHivStatHeiEidNegative
    {
        private readonly SPToCoreContext _context;

        public HivStatHeiEidNegativeRepository(SPToCoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<spDashboard_HEI_EID_NegativeResult>> 
            GetInfantsByDistrict(DateTime? startDate, DateTime? endDate,
                string districtId)
        {
            var data = await _context
                 .spDashboard_HEI_EID_NegativeAsync(districtId);
            return data;
        }

        async Task<IEnumerable<spDashboard_HEI_EID_Negative_SubcountyResult>> 
        IHivStatHeiEidNegative.GetInfantsBySubcounty(string districtId, string subcountyId)
        {
            var data = await _context
                .spDashboard_HEI_EID_Negative_SubcountyAsync(districtId, subcountyId);
            return data;
        }
    }
}
