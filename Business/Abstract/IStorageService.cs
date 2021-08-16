using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStorageService
    {
        IDataResult<List<Storage>> GetAll();
        IDataResult<Storage> Get(Storage storage);
        IResult Add(Storage storage);
        IResult Update(Storage storage);
        IResult Delete(Storage storage);
    }
}
