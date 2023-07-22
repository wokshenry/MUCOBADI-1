using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IOvcPss
    {
        Task<IEnumerable<spDashboard_OVC_PSSResult>>
          GetByDistrict(DateTime? startDate,
          DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_OVC_PSSResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
