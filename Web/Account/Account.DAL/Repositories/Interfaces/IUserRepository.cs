using Account.DAL.Models;
using System.Collections.Generic;

namespace Account.DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Add(UserDataModel userDataModel);
        UserDataModel GetByEmail(string email);
        List<UserDataModel> GetList();
        void Update(UserDataModel userDataModel);
        void Delete(UserDataModel userDataModel);
    }
}
