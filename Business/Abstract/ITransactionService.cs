using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransactionService
    {
        IDataResult<List<Transaction>> GetAll();
        IDataResult<Transaction> Get(Transaction transaction);
        IResult Add(Transaction transaction);
        IResult Update(Transaction transaction);
        IResult Delete(Transaction transaction);
    }
}
