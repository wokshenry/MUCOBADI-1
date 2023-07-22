using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatPositiveClients
    {
        Task<IEnumerable<spDashboard_PositiveClients_DistrictResult>>
           GetByDistrict(DateTime? startDate,
           DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_PositiveClients_SubcountyResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
