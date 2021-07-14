using System;

namespace RegistrationWindowBLL
{
    public class User
    {
        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string AvatarPath { get; set; }

        public Gender Sex { get; set; }
    }
}
