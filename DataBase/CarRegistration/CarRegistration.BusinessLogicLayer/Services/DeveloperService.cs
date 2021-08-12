using CarRegistration.BusinessLogicLayer.Services.Interfaces;
using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.DataAccessLayer.Repositories;
using CarRegistration.DataAccessLayer.Repositories.Interfaces;
using System.Collections.Generic;

namespace CarRegistration.BusinessLogicLayer.Services
{
    public class DeveloperService : IDeveloperService
    {
        private IDeveloperRepository<Develorer> _developerRepository;
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

        public Develorer GetByID(int id)
        {
            return _developerRepository.GetByID(id);
        }

        public List<Develorer> GetList()
        {
            _developerRepository.GetLazyDevelopers();
            return _developerRepository.GetList();
        }

        public void Update(int id, string newName, int newAge)
        {
            Develorer developer = GetByID(id);
            developer.Name = newName;
            developer.Age = newAge;

            _carDbContext.Develorers.Update(developer);
            _carDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _developerRepository.Delete(id);
            _carDbContext.SaveChanges();
        }
    }
}
