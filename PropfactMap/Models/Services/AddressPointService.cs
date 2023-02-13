using Microsoft.EntityFrameworkCore;
using PropfactMap.Models.DTOs;

namespace PropfactMap.Models.Services
{
    public class AddressPointService : IAddressPointService
    {
        private readonly AddressPointContext _dbContext;

        public AddressPointService(AddressPointContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<AddressPoint>> GetResults(AddressPointEntryDTO dto)
        {

            var maxLng = dto.SouthWest.Lng >= dto.NorthEast.Lng ? dto.SouthWest.Lng : dto.NorthEast.Lng;
            var minLng = dto.SouthWest.Lng <= dto.NorthEast.Lng ? dto.SouthWest.Lng : dto.NorthEast.Lng;
            var maxLat = dto.NorthEast.Lat >= dto.SouthWest.Lat ? dto.NorthEast.Lat : dto.SouthWest.Lat;
            var minLat = dto.NorthEast.Lat <= dto.SouthWest.Lat ? dto.NorthEast.Lat : dto.SouthWest.Lat;

            var data = await _dbContext.AddressPoints.ToListAsync();

            var results = await _dbContext.AddressPoints
                .Where(x => (x.PointX >= minLng && x.PointX <= maxLng) && (x.PointY >= minLat && x.PointY <= maxLat))
                .ToListAsync();

            if (!string.IsNullOrEmpty(dto.Search))
            {
                results = results.Where(x => (x.PropAddrL1 + " " + x.PropAddrL2).Contains(dto.Search, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return results;
        }
    }
}
