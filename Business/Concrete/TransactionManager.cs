using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TransactionManager : ITransactionService
    {
        ITransactionRepository _transactionRepository;

        public TransactionManager(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public IResult Add(Transaction transaction)
        {
            _transactionRepository.Add(transaction);
            return new SuccessResult("Urun eklendi");
        }

        public IResult Delete(Transaction transaction)
        {
            _transactionRepository.Delete(transaction);
            return new SuccessResult("Urun silindi");
        }

        public IDataResult<Transaction> Get(Transaction transaction)
        {
            return new SuccessDataResult<Transaction>(_transactionRepository.Get(t => t.Id == transaction.Id));
        }

        public IDataResult<List<Transaction>> GetAll()
        {
            return new SuccessDataResult<List<Transaction>>(_transactionRepository.GetAll());


        }
        public IResult Update(Transaction transaction)
        {
            _transactionRepository.Update(transaction);
            return new SuccessResult("Urun silindi");
        }

    }
}
