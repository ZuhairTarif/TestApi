using MasterSetup.Domain.Entities;
using MasterSetup.Domain.Interfaces;

namespace MasterSetup.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public async Task<Company> CreateAsync(Company company)
        {
            return await _companyRepository.CreateAsync(company);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _companyRepository.DeleteAsync(id);
        }

        public async Task<List<Company>> GetAllAsync()
        {
            return await _companyRepository.GetAllAsync();
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            return await _companyRepository.GetByIdAsync(id);
        }

        public async Task<int> UpdateAsync(int id, Company company)
        {
            return await _companyRepository.UpdateAsync(id, company);
        }
    }
}
