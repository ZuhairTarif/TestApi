using Microsoft.EntityFrameworkCore;
using Transport.Domain.Entities;
using Transport.Domain.Interfaces;
using Transport.Infrastructure.Data;

namespace Transport.Infrastructure.Repositories
{
    public class DriverDetailsRepository : IDriverDetailsRepository
    {
        private readonly DriverDetailsDbContext _driverDetailsDbContext;
        public DriverDetailsRepository(DriverDetailsDbContext driverDetailsDbContext)
        {
            _driverDetailsDbContext = driverDetailsDbContext;
               
        }
        public async Task<DriverDetails> CreateAsync(DriverDetails driver)
        {
           await _driverDetailsDbContext.AddAsync(driver);
           await _driverDetailsDbContext.SaveChangesAsync();
            return driver;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _driverDetailsDbContext.Drivers
                .Where(d => d.Id == id)
                .ExecuteDeleteAsync();
        }

        public async Task<List<DriverDetails>> GetAllAsync()
        {
           return await _driverDetailsDbContext.Drivers.ToListAsync();
        }

        public async Task<DriverDetails> GetIdByAsync(int id)
        {
            return await _driverDetailsDbContext.Drivers.AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<int> UpdateAsync(int id, DriverDetails driver)
        {
            return await _driverDetailsDbContext.Drivers
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Name, driver.Name)
                );
        }
    }
}
