using PropfactMap.Models.DTOs;

namespace PropfactMap.Models.Services
{
    public interface IAddressPointService
    {
        Task<List<AddressPoint>> GetResults(AddressPointEntryDTO dto);
    }
}
