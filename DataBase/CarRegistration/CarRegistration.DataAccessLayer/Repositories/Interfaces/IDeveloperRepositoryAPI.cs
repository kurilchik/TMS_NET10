using CarRegistration.DataAccessLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.DataAccessLayer.Repositories.Interfaces
{
    public interface IDeveloperRepositoryAPI
    {
        Task<Develorer> Add(Develorer develorer);
        Task<Develorer> GetById(int id);
        Task<IEnumerable<Develorer>> GetAll();
        Task Update(Develorer develorer);
        Task Delete(int id);
    }
}
