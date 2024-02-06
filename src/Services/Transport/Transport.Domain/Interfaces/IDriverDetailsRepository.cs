using Transport.Domain.Entities;

namespace Transport.Domain.Interfaces
{
    public interface IDriverDetailsRepository
    {
        Task<List<DriverDetails>>GetAllAsync();
        Task<DriverDetails> GetIdByAsync(int id);
        Task<DriverDetails> CreateAsync(DriverDetails driver);
        Task<int> UpdateAsync(int id, DriverDetails driver);
        Task<int> DeleteAsync(int id);
    }
}
