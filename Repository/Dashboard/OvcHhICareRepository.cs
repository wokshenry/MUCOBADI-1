using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Repository.Dashboard
{
    public class OvcHhICareRepository : IOvcHhICare
    {
        private readonly SPToCoreContext _context;

        public OvcHhICareRepository(SPToCoreContext context)
        {
            _context = context;
        }

        public  async Task<IEnumerable<spDashboard_OVC_HH_ICAREResult>> 
            GetByDistrict(DateTime? startDate, DateTime? endDate, 
                string districtId)
        {
            var data = await _context
              .spDashboard_OVC_HH_ICAREAsync
              (districtId, null, null);
            return data;
        }

        public Task<IEnumerable<spDashboard_OVC_HH_ICAREResult>> 
            GetBySubcounty(DateTime? startDate, DateTime? endDate, 
                string district, string subcounty)
        {
            throw new NotImplementedException();
        }
    }
}
