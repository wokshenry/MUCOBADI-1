using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MUCOBADI.Interfaces.Dashboard;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace MUCOBADI.Controller.Dashboards
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAnyOrigins")]
    public class OvcServicesController : ControllerBase
    {
        private IOvcBeneficiariesHivStatus _beneficiariesHivStatus;
        private IOvcBeneficiariesICare _beneficiariesICare;
        private IOvcChildProtection _childProtection;
        private IOvcEconomicStability _economicStability;
        private IOvcEducation _education;
        private IOvcFoodSecurity _foodSecurity;
        private IOvcGenderICare _genderICare;
        private IOvcHealthService _healthService;
        private IOvcHhICare _hhICare;
        private IOvcPss _pss;

        public OvcServicesController(
            IOvcBeneficiariesHivStatus beneficiariesHivStatus,
            IOvcBeneficiariesICare beneficiariesICare,
            IOvcChildProtection childProtection,
            IOvcEconomicStability economicStability,
            IOvcEducation education,
            IOvcFoodSecurity foodSecurity,
            IOvcGenderICare genderICare,
            IOvcHealthService healthService,
            IOvcHhICare hhICare,
            IOvcPss pss)
        {
            _beneficiariesHivStatus = beneficiariesHivStatus;
            _beneficiariesICare = beneficiariesICare;
            _childProtection = childProtection;
            _economicStability = economicStability;
            _education = education;
            _foodSecurity = foodSecurity;
            _genderICare = genderICare;
            _healthService = healthService;
            _hhICare = hhICare;
            _pss = pss;
        }

        [HttpGet("{districtId}/district/beneficiariesHivStatus")]
        public async Task<IActionResult> GetBeneficiariesHivStatusByDistrict(string districtId)
        {
            var results = await _beneficiariesHivStatus
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/beneficiariesICare")]
        public async Task<IActionResult> GetBeneficiariesICareByDistrict(string districtId)
        {
            var results = await _beneficiariesICare
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/childProtection")]
        public async Task<IActionResult> GetChildProtectionByDistrict(string districtId)
        {
            var results = await _childProtection
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/economicStability")]
        public async Task<IActionResult> GetEconomicStabilityByDistrict(string districtId)
        {
            var results = await _economicStability
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/education")]
        public async Task<IActionResult> GetEducationByDistrict(string districtId)
        {
            var results = await _education
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/foodSecurity")]
        public async Task<IActionResult> GetFoodSecurityByDistrict(string districtId)
        {
            var results = await _foodSecurity
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/genderICare")]
        public async Task<IActionResult> GetGenderICareByDistrict(string districtId)
        {
            var results = await _genderICare
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/healthService")]
        public async Task<IActionResult> GetHealthServiceByDistrict(string districtId)
        {
            var results = await _healthService
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/hhICare")]
        public async Task<IActionResult> GetHhICareByDistrict(string districtId)
        {
            var results = await _hhICare
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/pss")]
        public async Task<IActionResult> GetPssByDistrict(string districtId)
        {
            var results = await _pss
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }
    }
}
