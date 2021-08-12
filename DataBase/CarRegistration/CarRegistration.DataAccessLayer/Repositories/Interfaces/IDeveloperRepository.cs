using System.Collections.Generic;

namespace CarRegistration.DataAccessLayer.Repositories.Interfaces
{
    public interface IDeveloperRepository<T>
    {
        void Add(T developer);

        T GetByID(int id);

        List<T> GetList();

        void Update(T developer);

        void Delete(int id);

        List<T> GetLazyDevelopers();
    }
}
