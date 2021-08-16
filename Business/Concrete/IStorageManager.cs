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
    public class IStorageManager : IStorageService
    {

        IStorageRepository _storageRepository;

        public IStorageManager(IStorageRepository storageRepository)
        {
            _storageRepository = storageRepository;
        }

        public IResult Add(Storage storage)
        {
            _storageRepository.Add(storage);
            return new SuccessResult("Urun eklendi");
        }

        public IResult Delete(Storage storage)
        {
            _storageRepository.Delete(storage);
            return new SuccessResult("Urun silindi");
        }

        public IDataResult<Storage> Get(Storage storage)
        {
            return new SuccessDataResult<Storage>(_storageRepository.Get(s => s.Id == storage.Id));
        }

        public IDataResult<List<Storage>> GetAll()
        {
            return new SuccessDataResult<List<Storage>>(_storageRepository.GetAll());
        }

        public IResult Update(Storage storage)
        {
            _storageRepository.Update(storage);
            return new SuccessResult("Urun guncellendi");
        }
    }
}
