using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatHei
    {
        Task<IEnumerable<spDashboard_HEIResult>>
           GetInfantsByDistrict
            (DateTime? startDate, DateTime? endDate, string districtId);
        
        Task<IEnumerable<spDashboard_HEI_SubcountyResult>>
           GetInfantsBySubcounty
            (string districtId, string subcountyId);
    }
}
