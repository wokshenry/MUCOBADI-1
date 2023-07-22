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
    public class HivStatPositiveClientsController : ControllerBase
    {
        private IHivStatPositiveClients _clientsContext;
        private IHivStatPositiveClientsArt _artContext;
        private IHivStatPositiveClientsEligibleVL _eligibleVLContext;
        private IHivStatPositiveClientsReceivedVLResults _receivedVLResultsContext;
        private IHivStatPositiveClientsSuppressedResultsVL _suppressedResultsVLContext;
        private IHivStatPositiveClientsTakenVL _takenVLContext;

        public HivStatPositiveClientsController(IHivStatPositiveClients clientsContext, 
            IHivStatPositiveClientsArt artContext,
            IHivStatPositiveClientsEligibleVL eligibleVLContext,
            IHivStatPositiveClientsReceivedVLResults receivedVLResultsContext,
            IHivStatPositiveClientsSuppressedResultsVL suppressedResultsVLContext,
            IHivStatPositiveClientsTakenVL takenVLContext)
        {
            _clientsContext = clientsContext;
            _artContext = artContext;
            _eligibleVLContext = eligibleVLContext;
            _receivedVLResultsContext = receivedVLResultsContext;
            _suppressedResultsVLContext = suppressedResultsVLContext;
            _takenVLContext = takenVLContext;
        }

        [HttpGet("{districtId}/district")]
        public async Task<IActionResult> GetPositiveClientsByDistrict(string districtId)
        {
            var results = await _clientsContext
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/{subcountyId}/subcounty")]
        public async Task<IActionResult> GetPositiveClientsBySubcounty(string districtId, string subcountyId)
        {
            var results = await _clientsContext
                .GetBySubcounty(null, null, districtId, subcountyId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/art")]
        public async Task<IActionResult> GetPositiveClientsArtByDistrict(string districtId)
        {
            var results = await _artContext
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/{subcountyId}/subcounty/art")]
        public async Task<IActionResult> GetPositiveClientsArtBySubcounty(string districtId, string subcountyId)
        {
            var results = await _artContext
                .GetBySubcounty(null, null, districtId, subcountyId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/eligiblevl")]
        public async Task<IActionResult> GetPositiveClientsEligibleVLByDistrict(string districtId)
        {
            var results = await _eligibleVLContext
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/{subcountyId}/subcounty/eligiblevl")]
        public async Task<IActionResult> GetPositiveClientsEligibleVLBySubcounty(
            string districtId, string subcountyId)
        {
            var results = await _eligibleVLContext
                .GetBySubcounty(null, null, districtId, subcountyId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/receivedvl")]
        public async Task<IActionResult> GetPositiveClientsReceivedVLByDistrict(string districtId)
        {
            var results = await _receivedVLResultsContext
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/{subcountyId}/subcounty/receivedvl")]
        public async Task<IActionResult> GetPositiveClientsReceivedVLBySubcounty(
            string districtId, string subcountyId)
        {
            var results = await _receivedVLResultsContext
                .GetBySubcounty(null, null, districtId, subcountyId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/suppressedvl")]
        public async Task<IActionResult> GetPositiveClientsSuppressedVLByDistrict(string districtId)
        {
            var results = await _suppressedResultsVLContext
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }

        [HttpGet("{districtId}/{subcountyId}/subcounty/suppressedvl")]
        public async Task<IActionResult> GetPositiveClientsSuppressedVLBySubcounty(
            string districtId, string subcountyId)
        {
            var results = await _suppressedResultsVLContext
                .GetBySubcounty(null, null, districtId, subcountyId);
            return Ok(results);
        }

        [HttpGet("{districtId}/district/takenvl")]
        public async Task<IActionResult> GetPositiveClientsTakenVLByDistrict(string districtId)
        {
            var results = await _takenVLContext
                .GetByDistrict(null, null, districtId);
            return Ok(results);
        }
        
        [HttpGet("{districtId}/{subcountyId}/subcounty/takenvl")]
        public async Task<IActionResult> GetPositiveClientsTakenVLBySubcounty(
            string districtId, string subcountyId)
        {
            var results = await _takenVLContext
                .GetBySubcounty(null, null, districtId, subcountyId);
            return Ok(results);
        }

    }
}
