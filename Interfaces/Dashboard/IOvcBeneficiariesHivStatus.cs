using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IOvcBeneficiariesHivStatus
    {
        Task<IEnumerable<spDashboard_OVC_Beneficiairies_HIVStatusResult>>
          GetByDistrict(DateTime? startDate,
          DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_OVC_Beneficiairies_HIVStatusResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
