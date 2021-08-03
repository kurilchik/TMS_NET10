using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.DataAccessLayer.Repositories
{
    public class DeveloperRepository : IDeveloperRepository
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
    }
}
