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
    public class ProductImageManager : IProductImageService
    {
        IProductImageRepository _productImageRepository;

        public ProductImageManager(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }

        public IResult Add(ProductImage productImage)
        {
            _productImageRepository.Add(productImage);
            return new SuccessResult("Urun eklendi");
        }

        public IResult Delete(ProductImage productImage)
        {
            _productImageRepository.Delete(productImage);
            return new SuccessResult("Urun silindi");
        }

        public IDataResult<ProductImage> Get(ProductImage productImage)
        {
            return new SuccessDataResult<ProductImage>(_productImageRepository.Get(pp => pp.Id == productImage.Id));
        }

        

        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageRepository.GetAll());
        }

        public IResult Update(ProductImage productImage)
        {
            _productImageRepository.Update(productImage);
            return new SuccessResult("Urun guncellendi");
        }
    }
}
