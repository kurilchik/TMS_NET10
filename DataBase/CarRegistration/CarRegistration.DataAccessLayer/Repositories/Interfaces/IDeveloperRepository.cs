using System.Collections.Generic;

namespace CarRegistration.DataAccessLayer.Repositories.Interfaces
{
    public interface IDeveloperRepository<T>
    {
        void Add(T developer);

        public T GetByID(int id);

        public List<T> GetList();

        public void Update(T developer);

        public void Delete(int id);
    }
}
