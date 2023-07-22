using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IOvcHhICare
    {
        Task<IEnumerable<spDashboard_OVC_HH_ICAREResult>>
          GetByDistrict(DateTime? startDate,
          DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_OVC_HH_ICAREResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
