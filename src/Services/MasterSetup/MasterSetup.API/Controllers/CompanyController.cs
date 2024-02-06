using MasterSetup.Application.Services;
using MasterSetup.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MasterSetup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService) { 
            _companyService = companyService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var company = await _companyService.GetByIdAsync(id);
            if(company == null)
            {
                return NotFound();
            }
            return Ok(company);
        }
        [HttpPost]
        public async Task<ActionResult>Create(Company company)
        {
            var createCompany = await _companyService.CreateAsync(company);
            return CreatedAtAction(nameof(GetById),
                new { id = createCompany.CompanyId}
                ,createCompany);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Company updateCompany)
        {
            int exitingCompany = await _companyService.UpdateAsync(id, updateCompany);
            if(exitingCompany == 0)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id)
        {
            int company = await _companyService.DeleteAsync(id);
            if(company == 0)
            {
                return BadRequest();
            }
            return NoContent();
        }

    }
}
