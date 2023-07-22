using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace MUCOBADI.Repository.Dashboard
{
    public class HivStatPositiveClientsTakenVLRepository :
        IHivStatPositiveClientsTakenVL
    {
        private readonly SPToCoreContext _context;

        public HivStatPositiveClientsTakenVLRepository(SPToCoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<spDashboard_PositiveClientsTakenVL_DistrictResult>> 
            GetByDistrict
            (DateTime? startDate, DateTime? endDate, string districtId)
        {
            var data = await _context.spDashboard_PositiveClientsTakenVL_DistrictAsync
                (districtId, null, null);
            return data;
        }

        public async Task<IEnumerable<spDashboard_PositiveClientsTakenVL_SubcountyResult>> 
        GetBySubcounty(DateTime? startDate, DateTime? endDate, 
            string district, string subcounty)
        {
           var data = await _context
               .spDashboard_PositiveClientsTakenVL_SubcountyAsync(
                    district, subcounty, null, null);
           return data;
        }
    }
}
