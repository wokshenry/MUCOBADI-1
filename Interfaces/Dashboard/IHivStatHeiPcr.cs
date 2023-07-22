using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatHeiPcr
    {
        Task<IEnumerable<spDashboard_HEI_PCR_TestResult>>
           GetInfantsByDistrict
            (DateTime? startDate, DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_HEI_PCR_Test_SubcountyResult>>
           GetInfantsBySubcounty
            (string districtId, string subcountyId);
    }
}
