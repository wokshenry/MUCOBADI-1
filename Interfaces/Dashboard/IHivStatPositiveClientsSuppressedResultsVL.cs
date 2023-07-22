using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MUCOBADI.Models;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatPositiveClientsSuppressedResultsVL
    {
        Task<IEnumerable<spDashboard_PositiveClientsVLSuppressed_DistrictResult>>
           GetByDistrict(DateTime? startDate,
           DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_PositiveClientsVLSuppressed_SubcountyResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
