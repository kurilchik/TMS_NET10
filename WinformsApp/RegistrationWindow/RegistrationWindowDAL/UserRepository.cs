using System;
using RegistrationWindowBLL;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWindowDAL
{
    public class UserRepository
    {
        private readonly string _savePath = @"Users\";

        public UserRepository()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_savePath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        public void AddUser(User user)
        {
            string path = $"{_savePath}User_{user.Name}_ID_{Guid.NewGuid()}.txt";
            string str = $"Email address: {user.EmailAddress}\nPassword: {user.Password}\nName: {user.Name}\nGender: {user.Sex}\nDate of birth: {user.DateOfBirth.Date}\nPath of avatar: {user.AvatarPath}";
            File.WriteAllText(path, str);
        }
    }
}
