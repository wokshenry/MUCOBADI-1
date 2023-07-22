using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatPositiveClientsEligibleVL
    {
        Task<IEnumerable<spDashboard_PositiveClientsEligibleVL_DistrictResult>>
           GetByDistrict(DateTime? startDate,
           DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_PositiveClientsEligibleVL_SubcountyResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
