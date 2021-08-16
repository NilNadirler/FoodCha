using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<List<Image>> GetAll();
        IDataResult<Image> Get(Image image);
        IResult Add(Image image);
        IResult Update(Image image);
        IResult Delete(Image image);
    }
}
