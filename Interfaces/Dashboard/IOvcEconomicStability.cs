using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IOvcEconomicStability
    {
        Task<IEnumerable<spDashboard_OVC_EconomicStabilityResult>>
          GetByDistrict(DateTime? startDate,
          DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_OVC_EconomicStabilityResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
