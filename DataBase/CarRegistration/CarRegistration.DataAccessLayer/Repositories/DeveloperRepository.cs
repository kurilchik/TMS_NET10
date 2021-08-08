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
    }
}
