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
    public class UnitTypeManager : IUnitTypeService
    {

        IUnitTypeRepository _unitTypeRepository;

        public UnitTypeManager(IUnitTypeRepository unitTypeRepository)
        {
            _unitTypeRepository = unitTypeRepository;
        }

        public IResult Add(UnitType unitType)
        {
            _unitTypeRepository.Add(unitType);
            return new SuccessResult("Urun eklendi");
        }

        public IResult Delete(UnitType unitType)
        {
            _unitTypeRepository.Delete(unitType);
            return new SuccessResult("Urun silindi");
        }

        public IDataResult<UnitType> Get(UnitType unitType)
        {
            return new SuccessDataResult<UnitType>(_unitTypeRepository.Get(ut => ut.Id == unitType.Id));
        }

        public IDataResult<List<UnitType>> GetAll()
        {
            return new SuccessDataResult<List<UnitType>>(_unitTypeRepository.GetAll());
        }

        public IResult Update(UnitType unitType)
        {
            _unitTypeRepository.Update(unitType);
            return new SuccessResult("Urun guncellendi");
        }
    }
}
