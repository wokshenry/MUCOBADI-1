using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.Dashboard
{
    public interface IOvcEducation
    {
        Task<IEnumerable<spDashboard_OVC_EducationResult>>
          GetByDistrict(DateTime? startDate,
          DateTime? endDate, string districtId);

        Task<IEnumerable<spDashboard_OVC_EducationResult>>
           GetBySubcounty(DateTime? startDate,
           DateTime? endDate, string district, string subcounty);
    }
}
