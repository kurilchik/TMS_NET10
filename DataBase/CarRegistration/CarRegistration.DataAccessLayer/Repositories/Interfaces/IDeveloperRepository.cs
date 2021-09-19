using CarRegistration.DataAccessLayer.DataModels;
using System.Collections.Generic;

namespace CarRegistration.DataAccessLayer.Repositories.Interfaces
{
    public interface IDeveloperRepository
    {
        void Add(Develorer developer);

        Develorer GetByID(int id);

        List<Develorer> GetList();

        void Update(Develorer developer);

        void Delete(int id);

        List<Develorer> GetLazyDevelopers();

        List<Car> Stored(int owner);
    }
}
