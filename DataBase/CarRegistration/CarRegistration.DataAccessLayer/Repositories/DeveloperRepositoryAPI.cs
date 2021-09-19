using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.DataAccessLayer.Repositories
{
    public class DeveloperRepositoryAPI : IDeveloperRepositoryAPI
    {
        private CarDbContext _carDbContext;

        public DeveloperRepositoryAPI(CarDbContext carDbContext)
        {
            _carDbContext = carDbContext;
        }

        public async Task<Develorer> Add(Develorer develorer)
        {
            _carDbContext.Develorers.Add(develorer);
            await _carDbContext.SaveChangesAsync();

            return develorer;
        }

        public async Task Delete(int id)
        {
            var develorerDelete = await _carDbContext.Develorers.FindAsync(id);
            _carDbContext.Develorers.Remove(develorerDelete);

            await _carDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Develorer>> GetAll()
        {
            return await _carDbContext.Develorers.ToListAsync();
        }

        public async Task<Develorer> GetById(int id)
        {
            return await _carDbContext.Develorers.FindAsync(id);
        }

        public async Task Update(Develorer develorer)
        {
            _carDbContext.Entry(develorer).State = EntityState.Modified;
            await _carDbContext.SaveChangesAsync();
        }
    }
}
