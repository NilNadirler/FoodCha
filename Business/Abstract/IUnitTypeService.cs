using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUnitTypeService
    {
        IDataResult<List<UnitType>> GetAll();
        IDataResult<UnitType> Get(UnitType unitType);
        IResult Add(UnitType unitType);
        IResult Update(UnitType unitType);
        IResult Delete(UnitType unitType);
    }
}
