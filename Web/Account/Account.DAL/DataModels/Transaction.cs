using System;

namespace Account.DAL.DataModels
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
    }
}
