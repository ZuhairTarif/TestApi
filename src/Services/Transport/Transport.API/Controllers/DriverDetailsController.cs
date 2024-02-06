using Microsoft.AspNetCore.Mvc;
using Transport.Application.Services;
using Transport.Domain.Entities;

namespace Transport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverDetailsController : ControllerBase
    {
        private readonly IDriverDetailsService _driverDetailsService;
        public DriverDetailsController(IDriverDetailsService driverDetailsService)
        {
              _driverDetailsService = driverDetailsService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var driver = await _driverDetailsService.GetByIdAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return Ok(driver);
        }
        [HttpPost]
        public async Task<ActionResult> Create(DriverDetails driver)
        {
            var createDriver = await _driverDetailsService.CreateAsync(driver);
            return CreatedAtAction(nameof(GetById),
                new { id = createDriver.Id }
                , createDriver);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, DriverDetails updateDriver)
        {
            int exisitingDriver = await _driverDetailsService.UpdateAsync(id, updateDriver);
            if (exisitingDriver == 0)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            int driver = await _driverDetailsService.DeleteAsync(id);
            if (driver == 0)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
