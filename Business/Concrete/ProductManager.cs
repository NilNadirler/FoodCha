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
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IResult Add(Product product)
        {
            _productRepository.Add(product);
            return new SuccessResult("Urun eklendi");
        }

        public IResult Delete(Product product)
        {
            _productRepository.Delete(product);
            return new SuccessResult("Urun silindi");
        }

        public IDataResult<Product> Get(Product product)
        {
            return new SuccessDataResult<Product>(_productRepository.Get(p => p.Id == product.Id));
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productRepository.GetAll());
        }

        public IResult Update(Product product)
        {
            _productRepository.Update(product);
            return new SuccessResult("Urun guncellendi");
        }
    }
}
