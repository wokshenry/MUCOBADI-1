using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MUCOBADI.Models;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IHivStatPositiveClientsTakenVL
    {
        Task<IEnumerable<spDashboard_PositiveClientsTakenVL_DistrictResult>>
          GetByDistrict(DateTime? startDate,
          DateTime? endDate, string districtId);
        
        Task<IEnumerable<spDashboard_PositiveClientsTakenVL_SubcountyResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
