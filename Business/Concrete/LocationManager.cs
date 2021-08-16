using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationRepository _locationRepository;

        public LocationManager(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public IResult Add(Location location)
        {
            _locationRepository.Add(location);
            return new SuccessResult("Urun eklendi");
        }

        public IResult Delete(Location location)
        {

            _locationRepository.Delete(location);
            return new SuccessResult("Urun silindi");
        }

        public IDataResult<Location> Get(Employee location)
        {
            return new SuccessDataResult<Location>(_locationRepository.Get(l => l.Id == location.Id));
        }

        public IDataResult<List<Location>> GetAll()
        {
            return new SuccessDataResult<List<Location>>(_locationRepository.GetAll());
        }

        public IResult Update(Location location)
        {

            _locationRepository.Add(location);
            return new SuccessResult("Urun guncellendi");
        }
    }
}
