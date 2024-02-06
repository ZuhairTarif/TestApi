using MasterSetup.Domain.Entities;

namespace MasterSetup.Domain.Interfaces
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllAsync();
        Task<Company> GetByIdAsync(int id);
        Task<Company> CreateAsync(Company company);
        Task<int> UpdateAsync(int id, Company company);
        Task<int> DeleteAsync(int id);
        
    }
}
