using CarRegistration.BusinessLogicLayer.Services.Interfaces;
using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.DataAccessLayer.Repositories;
using CarRegistration.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.BusinessLogicLayer.Services
{
    public class DeveloperService : IDeveloperService
    {
        private IDeveloperRepository _developerRepository;
        private CarDbContext _carDbContext;

        public DeveloperService()
        {
            _carDbContext = new CarDbContext();
            _developerRepository = new DeveloperRepository(_carDbContext);
        }
        public void Add(string name, int age)
        {
            Develorer developer = new Develorer()
            {
                Name = name,
                Age = age
            };

            _developerRepository.Add(developer);
            _carDbContext.SaveChanges();
        }
    }
}
