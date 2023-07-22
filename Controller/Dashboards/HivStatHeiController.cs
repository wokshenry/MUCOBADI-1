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
    public class HivStatHeiController : ControllerBase
    {
        private IHivStatHei _hei;
        private IHivStatHeiEidNegative _heiNegative;
        private IHivStatHeiEidPositive _heiPositive;
        private IHivStatHeiPcr _heiPcr;

        public HivStatHeiController(
            IHivStatHei hei,
            IHivStatHeiEidNegative heiNegative,
            IHivStatHeiEidPositive heiPositive,
            IHivStatHeiPcr heiPcr)
        {
            _hei = hei;
            _heiNegative = heiNegative;
            _heiPositive = heiPositive;
            _heiPcr = heiPcr;
        }

        [HttpGet("{districtId}/district/")]
        public async Task<IActionResult> GetHeiByDistrict(string districtId)
        {
            var results = await _hei
                .GetInfantsByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/{subcountyId}/subcounty/")]
        public async Task<IActionResult> GetHeiBySubcounty(string districtId,
            string subcountyId)
        {
            var results = await _hei
                .GetInfantsBySubcounty(districtId, subcountyId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/positive")]
        public async Task<IActionResult> GetHeiPositiveByDistrict(string districtId)
        {
            var results = await _heiPositive
                .GetInfantsByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/{subcountyId}/subcounty/positive")]
        public async Task<IActionResult> GetHeiPositiveBySubcounty(string districtId,
            string subcountyId)
        {
            var results = await _heiPositive
                .GetInfantsBySubcounty(districtId, subcountyId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/negative")]
        public async Task<IActionResult> GetHeiNegativeByDistrict(string districtId)
        {
            var results = await _heiNegative
                .GetInfantsByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/{subcountyId}/subcounty/negative")]
        public async Task<IActionResult> GetHeiNegativeBySubcounty(string districtId,
            string subcountyId)
        {
            var results = await _heiNegative
                .GetInfantsBySubcounty(districtId, subcountyId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/pcr")]
        public async Task<IActionResult> GetHeiPcrByDistrict(string districtId)
        {
            var results = await _heiPcr
                .GetInfantsByDistrict(null, null, districtId);
            return Ok(results);
        }
        
        [HttpGet("{districtId}/{subcountyId}/subcounty/pcr")]
        public async Task<IActionResult> GetHeiPcrBySubcounty(string districtId,
            string subcountyId)
        {
            var results = await _heiPcr
                .GetInfantsBySubcounty(districtId, subcountyId);
            return Ok(results);
        }
    }
}
