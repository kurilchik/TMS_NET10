using Account.DAL.DataModels;
using Account.DAL.Models;
using Account.DAL.Repositories.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Account.DAL.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private AccountDbContext _accountDbContext;
        private IMapper _mapper;

        public TransactionRepository(AccountDbContext accountDbContext, IMapper mapper)
        {
            _accountDbContext = accountDbContext;
            _mapper = mapper;
        }

        public void Add(TransactionDataModel transactionDataModel)
        {
            var transaction = _mapper.Map<Transaction>(transactionDataModel);
            _accountDbContext.Transactions.Add(transaction);
        }

        public List<TransactionDataModel> GetListByUserId(Guid userId)
        {
            var transactions = _accountDbContext.Transactions.Where(t => t.UserId == userId).ToList();
            var transactionDataModels = _mapper.Map<List<TransactionDataModel>>(transactions);

            return transactionDataModels;
        }
    }
}
