using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Repository.Dashboard
{
    public class OvcChildProtectionRepository : IOvcChildProtection
    {
        private readonly SPToCoreContext _context;

        public OvcChildProtectionRepository(SPToCoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<spDashboard_OVC_ChildProtectionResult>> 
            GetByDistrict(DateTime? startDate, DateTime? endDate, 
                string districtId)
        {
            var data = await _context
               .spDashboard_OVC_ChildProtectionAsync
               (districtId, null, null);
            return data;
        }

        public Task<IEnumerable<spDashboard_OVC_ChildProtectionResult>> 
            GetBySubcounty(DateTime? startDate, DateTime? endDate, 
                string district, string subcounty)
        {
            throw new NotImplementedException();
        }
    }
}
