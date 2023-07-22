using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace MUCOBADI.Repository.Dashboard
{
    public class HivStatPositiveClientsRepository : IHivStatPositiveClients
    {
        private readonly SPToCoreContext _context;

        public HivStatPositiveClientsRepository(SPToCoreContext context)
        {
            _context = context;
        }

        async Task<IEnumerable<spDashboard_PositiveClients_DistrictResult>>
           IHivStatPositiveClients.GetByDistrict(DateTime? startDate,
           DateTime? endDate, string districtId)
        {
            var data = await _context
                .spDashboard_PositiveClients_DistrictAsync(districtId, null, null);
            return data;
        }

        public async Task<IEnumerable<spDashboard_PositiveClients_SubcountyResult>> 
        GetBySubcounty(DateTime? startDate, DateTime? endDate, 
            string district, string subcounty)
        {
           var data = await _context
               .spDashboard_PositiveClients_SubcountyAsync(
                    district, subcounty, null, null);
           return data;
        }
    }
}
