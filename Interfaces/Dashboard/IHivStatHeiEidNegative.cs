using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatHeiEidNegative
    {
        Task<IEnumerable<spDashboard_HEI_EID_NegativeResult>>
           GetInfantsByDistrict
            (DateTime? startDate, DateTime? endDate, string districtId);
        
        Task<IEnumerable<spDashboard_HEI_EID_Negative_SubcountyResult>>
           GetInfantsBySubcounty
            (string districtId, string subcountyId);
    }
}
