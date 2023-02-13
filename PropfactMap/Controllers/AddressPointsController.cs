using PropfactMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropfactMap.Controllers.Models;
using PropfactMap.Models.Services;
using PropfactMap.Models.DTOs;

namespace PropfactMap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressPointsController : ControllerBase
    {
        private readonly IAddressPointService _service;

        public AddressPointsController(IAddressPointService service)
        {
            _service = service;
        }

        // POST: api/AddressPoints
        [HttpPost]
        public async Task<ActionResult<AddressPointWrapperVM>> PostAddressPoints(AddressPointEntryVM req)
        {
            var dto = new AddressPointEntryDTO()
            {
                Search = req.Search,
                Zoom = req.Zoom,
                NorthEast = new NorthEastDTO() { Lng = req.NorthEast.Lng, Lat = req.NorthEast.Lat },
                SouthWest = new SouthWestDTO() { Lng = req.SouthWest.Lng, Lat = req.SouthWest.Lat },
            };

            var results = await _service.GetResults(dto);

            return new AddressPointWrapperVM()
            {
                Results = results.Select(x => new AddressPointVM()
                {
                    Longitude = x.PointX,
                    Latitude = x.PointY,
                    Title = x.PropAddrL1 + " " + x.PropAddrL2
                }).ToList()
            };
        }

        
    }
}
