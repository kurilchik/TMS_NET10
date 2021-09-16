using System;
using System.Collections.Generic;

namespace Account.DAL.DataModels
{
    public class User
    {
        public User()
        {
            Transactions = new HashSet<Transaction>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
