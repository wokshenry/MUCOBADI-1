using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatPositiveClientsArt
    {
        Task<IEnumerable<spDashboard_PositiveClientsArt_DistrictResult>>
           GetByDistrict(DateTime? startDate, DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_PositiveClientsArt_SubcountyResult>>
           GetBySubcounty(DateTime? startDate,
            DateTime? endDate, string district, string subcounty);
    }
}
