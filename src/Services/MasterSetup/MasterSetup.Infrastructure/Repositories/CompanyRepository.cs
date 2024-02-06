using MasterSetup.Domain.Entities;
using MasterSetup.Domain.Interfaces;
using MasterSetup.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterSetup.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CompanyDbContext _companyDbContext;

        public CompanyRepository(CompanyDbContext companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public async Task<Company> CreateAsync(Company company)
        {
            await _companyDbContext.Companies.AddAsync(company);
            await _companyDbContext.SaveChangesAsync();
            return company;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _companyDbContext.Companies
                         .Where(model => model.CompanyId == id)
                         .ExecuteDeleteAsync();
        }
        public async Task<List<Company>> GetAllAsync()
        {
            return await _companyDbContext.Companies.ToListAsync();
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            return await _companyDbContext.Companies.AsNoTracking()
                .FirstOrDefaultAsync(b => b.CompanyId == id);
        }

        public async Task<int> UpdateAsync(int id, Company company)
        {
            return await _companyDbContext.Companies
                .Where(model => model.CompanyId == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Name, company.Name)
                );
        }
    }
}
