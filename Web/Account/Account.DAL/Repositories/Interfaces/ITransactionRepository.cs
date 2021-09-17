using Account.DAL.Models;
using System;
using System.Collections.Generic;

namespace Account.DAL.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        void Add(TransactionDataModel transactionDataModel);
        List<TransactionDataModel> GetListByUserId(Guid userId);
    }
}
