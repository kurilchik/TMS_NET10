using Account.DAL.DataModels;
using Account.DAL.Models;
using Account.DAL.Repositories.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace Account.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AccountDbContext _accountDbContext;
        private IMapper _mapper;

        public UserRepository(AccountDbContext accountDbContext, IMapper mapper)
        {
            _accountDbContext = accountDbContext;
            _mapper = mapper;
        }

        public void Add(UserDataModel userDataModel)
        {
            var user = _mapper.Map<User>(userDataModel);
            _accountDbContext.Users.Add(user);
        }

        public UserDataModel GetByEmail(string email)
        {
            var user = _accountDbContext.Users.FirstOrDefault(u => u.Email == email);
            var userDataModel = _mapper.Map<UserDataModel>(user);

            return userDataModel;
        }

        public List<UserDataModel> GetList()
        {
            var users = _accountDbContext.Users.ToList();
            var userDataModels = _mapper.Map<List<UserDataModel>>(users);

            return userDataModels;
        }

        public void Update(UserDataModel userDataModel)
        {
            var user = _accountDbContext.Users.FirstOrDefault(u => u.Id == userDataModel.Id);
            user = _mapper.Map<User>(userDataModel);
        }

        public void Delete(UserDataModel userDataModel)
        {
            var user = _accountDbContext.Users.FirstOrDefault(u => u.Id == userDataModel.Id);
            _accountDbContext.Users.Remove(user);
        }
    }
}
