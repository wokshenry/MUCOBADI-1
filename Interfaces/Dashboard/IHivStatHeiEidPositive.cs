using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatHeiEidPositive
    {
        Task<IEnumerable<spDashboard_HEI_EID_PositiveResult>>
           GetInfantsByDistrict
            (DateTime? startDate, DateTime? endDate, string districtId);
        
        Task<IEnumerable<spDashboard_HEI_EID_Positive_SubcountyResult>>
           GetInfantsBySubcounty
            (string districtId, string subcountyId);
    }
}
