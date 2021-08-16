using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductImageService
    {
        IDataResult<List<ProductImage>> GetAll();
        IDataResult<ProductImage> Get(ProductImage productImage);
        IResult Add(ProductImage productImage);
        IResult Update(ProductImage productImage);
        IResult Delete(ProductImage productImage);
    }
}
