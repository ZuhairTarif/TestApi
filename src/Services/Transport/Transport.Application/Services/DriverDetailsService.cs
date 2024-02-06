using Transport.Domain.Entities;
using Transport.Domain.Interfaces;

namespace Transport.Application.Services
{
    public class DriverDetailsService : IDriverDetailsService
    {
        private readonly IDriverDetailsRepository _driverDetailsRepository;
        public DriverDetailsService(IDriverDetailsRepository driverDetailsRepository)
        {
            _driverDetailsRepository = driverDetailsRepository;
                
        }
        public async Task<DriverDetails> CreateAsync(DriverDetails driverDetails)
        {
            return await _driverDetailsRepository.CreateAsync(driverDetails);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _driverDetailsRepository.DeleteAsync(id);
        }

        public async Task<List<DriverDetails>> GetAllAsync()
        {
            return await _driverDetailsRepository.GetAllAsync();
        }

        public async Task<DriverDetails> GetByIdAsync(int id)
        {
            return await _driverDetailsRepository.GetIdByAsync(id);
        }
        public async Task<int> UpdateAsync(int id, DriverDetails driverDetails)
        {
            return await _driverDetailsRepository.UpdateAsync(id, driverDetails);
        }
    }
}
