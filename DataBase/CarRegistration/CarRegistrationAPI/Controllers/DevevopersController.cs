using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.DataAccessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevevopersController : ControllerBase
    {
        private readonly IDeveloperRepositoryAPI _developerRepository;

        public DevevopersController(IDeveloperRepositoryAPI developerRepository)
        {
            _developerRepository = developerRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Develorer>> GetDevelopers()
        {
            return await _developerRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Develorer>> GetDeveloper(int id)
        {
            return await _developerRepository.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Develorer>> PostDeveloper([FromBody] Develorer developer)
        {
            var newDeveloper = await _developerRepository.Add(developer);
            return CreatedAtAction(nameof(GetDeveloper), new { id = newDeveloper.Id }, newDeveloper);
        }

        [HttpPut]
        public async Task<ActionResult> PutDeveloper(int id, [FromBody] Develorer developer)
        {
            if (id != developer.Id)
            {
                return BadRequest();
            }

            await _developerRepository.Update(developer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var developerDelete = await _developerRepository.GetById(id);
            if (developerDelete == null)
            {
                return NotFound();
            }

            await _developerRepository.Delete(developerDelete.Id);
            return NoContent();
        }
    }
}
