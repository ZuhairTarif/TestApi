using Transport.Domain.Entities;

namespace Transport.Application.Services
{
    public interface IDriverDetailsService 
    {
        Task<List<DriverDetails>>GetAllAsync();
        Task<DriverDetails> GetByIdAsync(int id);
        Task<DriverDetails> CreateAsync(DriverDetails driverDetails);
        Task<int> UpdateAsync(int id, DriverDetails driverDetails);
        Task<int> DeleteAsync(int id);

        
    }
}
