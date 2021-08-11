using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.DataAccessLayer.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CarRegistration.DataAccessLayer.Repositories
{
    public class DeveloperRepository : IDeveloperRepository<Develorer>
    {
        private CarDbContext _carDbContext;

        public DeveloperRepository(CarDbContext carDbContext)
        {
            _carDbContext = carDbContext;
        }

        public void Add(Develorer developer)
        {
            _carDbContext.Develorers.Add(developer);
        }

        public Develorer GetByID(int id)
        {
            return _carDbContext.Develorers.SingleOrDefault(x => x.Id == id);
        }

        public List<Develorer> GetList()
        {
            return _carDbContext.Develorers.ToList();
        }

        public void Update(Develorer developer)
        {
            _carDbContext.Develorers.Update(developer);
        }

        public void Delete(int id)
        {
            var developer = _carDbContext.Develorers.SingleOrDefault(x => x.Id == id);
            _carDbContext.Develorers.Remove(developer);
        }

        private List<Develorer> GetSortedList(string name)
        {
            var dev = _carDbContext.Develorers.Where(x => x.Name == name);

            var dev1 = from developer in _carDbContext.Develorers
                       where developer.Name == name
                       select developer;

            var dev2 = _carDbContext.Develorers.Join(
                _carDbContext.CarDevelorers,
                d => d.Id,
                cd => cd.DevelorerId,
                (d, cd) => new
                {
                    DeveloperName = d.Name,
                    CarId = cd.CarId
                }).Join(
                _carDbContext.Cars,
                cd => cd.CarId,
                c => c.Id,
                (cd, c) => new
                {
                    DeveloperName = cd.DeveloperName,
                    IsAccident = c.Accident,
                    EngineTypeId = c.EngineTypeId
                }).Join(
                _carDbContext.EngineTypes,
                c => c.EngineTypeId,
                et => et.Id,
                (c, et) => new
                {
                    DeveloperName = c.DeveloperName,
                    EngineType = et.Name,
                    IsAccident = c.IsAccident
                }).Where(d => d.DeveloperName == name);

        var dev3 = (from developer in _carDbContext.Develorers
                        join carDeveloper in _carDbContext.CarDevelorers on developer.Id equals carDeveloper.DevelorerId
                        join car in _carDbContext.Cars on carDeveloper.CarId equals car.Id
                        join engineType in _carDbContext.EngineTypes on car.EngineTypeId equals engineType.Id
                        where developer.Name == name
                        select new
                        {
                            DeveloperName = developer.Name,
                            EngineType = engineType.Name,
                            IsAccident = car.Accident
                        }).ToList();

            var dev4 = dev3.Where(d => d.DeveloperName == name);

            return null;
        }
    }
}
