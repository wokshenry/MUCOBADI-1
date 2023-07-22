using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace MUCOBADI.Repository.Dashboard
{
    public class HivStatPositiveClientsReceivedVLResultsRepository :
        IHivStatPositiveClientsReceivedVLResults
    {
        private readonly SPToCoreContext _context;

        public HivStatPositiveClientsReceivedVLResultsRepository(SPToCoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<spDashboard_PositiveClientsReceivedResultsVL_DistrictResult>> 
            GetByDistrict
            (DateTime? startDate, DateTime? endDate, string districtId)
        {
            var data = await _context
                .spDashboard_PositiveClientsReceivedResultsVL_DistrictAsync
                (districtId, null, null);
            return data;
        }

        public async Task<IEnumerable<spDashboard_PositiveClientsReceivedResultsVL_SubcountyResult>> 
        GetBySubcounty(DateTime? startDate, DateTime? endDate, 
            string district, string subcounty)
        {
           var data = await _context
               .spDashboard_PositiveClientsReceivedResultsVL_SubcountyAsync(
                    district, subcounty, null, null);
           return data;
        }
    }
}
