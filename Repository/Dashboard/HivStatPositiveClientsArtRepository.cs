using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace MUCOBADI.Repository.Dashboard
{
    public class HivStatPositiveClientsArtRepository : IHivStatPositiveClientsArt
    {
        private readonly SPToCoreContext _context;

        public HivStatPositiveClientsArtRepository(SPToCoreContext context)
        {
            _context = context;
        }

        async Task<IEnumerable<spDashboard_PositiveClientsArt_DistrictResult>>
           IHivStatPositiveClientsArt.GetByDistrict(DateTime? startDate,
           DateTime? endDate, string districtId)
        {
            var data = await _context
                .spDashboard_PositiveClientsArt_DistrictAsync(districtId, null, null);
            return data;
        }

        public async Task<IEnumerable<spDashboard_PositiveClientsArt_SubcountyResult>> 
        GetBySubcounty(DateTime? startDate, DateTime? endDate, 
            string district, string subcounty)
        {
           var data = await _context
               .spDashboard_PositiveClientsArt_SubcountyAsync(
                    district, subcounty, null, null);
           return data;
        }
    }
}
