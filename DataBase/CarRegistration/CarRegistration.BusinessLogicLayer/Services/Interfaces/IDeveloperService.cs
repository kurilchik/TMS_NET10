using CarRegistration.DataAccessLayer.DataModels;
using System.Collections.Generic;

namespace CarRegistration.BusinessLogicLayer.Services.Interfaces
{
    public interface IDeveloperService
    {
        void Add(string name, int age);

        public Develorer GetByID(int id);

        public List<Develorer> GetList();

        public void Update(int id, string newName, int newAge);

        public void Delete(int id);
    }
}
