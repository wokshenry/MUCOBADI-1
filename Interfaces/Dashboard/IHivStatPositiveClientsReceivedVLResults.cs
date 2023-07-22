using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using MUCOBADI.Models;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatPositiveClientsReceivedVLResults
    {
        Task<IEnumerable<spDashboard_PositiveClientsReceivedResultsVL_DistrictResult>>
           GetByDistrict(DateTime? startDate,
           DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_PositiveClientsReceivedResultsVL_SubcountyResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
