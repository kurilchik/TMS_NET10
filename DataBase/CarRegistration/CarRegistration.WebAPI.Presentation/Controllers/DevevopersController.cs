using AutoMapper;
using CarRegistration.BusinessLogicLayer.Services.Interfaces;
using CarRegistration.WebAPI.Presentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRegistration.WebAPI.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevevopersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDeveloperService _developerService;

        public DevevopersController(IMapper mapper, IDeveloperService developerService)
        {
            _mapper = mapper;
            _developerService = developerService;
        }

        [HttpGet]
        public List<DeveloperDTO> GetDevelopers()
        {
            var developers = _developerService.GetList();
            var models = _mapper.Map<List<DeveloperDTO>>(developers);
            return models;
        }

        [HttpGet("{id}")]
        public DeveloperDTO GetDevelopers(int id)
        {
            var developer = _developerService.GetByID(id);
            var model = _mapper.Map<DeveloperDTO>(developer);
            return model;
        }

        [HttpPost]
        public void PostDeveloper([FromBody] AddDeveloperDTO developer)
        {
            _developerService.Add(developer.Name, developer.Age);
        }

        [HttpPut("{id}")]
        public void PutDeveloper(int id, [FromBody] UpdateDeveloperDTO developer)
        {
            var name = _developerService.GetByID(id).Name;
            _developerService.Update(id, name, developer.Age);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _developerService.Delete(id);
        }
    }
}
