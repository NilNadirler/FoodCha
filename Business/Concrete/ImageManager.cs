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
    public class ImageManager : IImageService
    {
        IImageRepository _imageRepository;

        public ImageManager(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public IResult Add(Image image)
        {
            _imageRepository.Add(image);
            return new SuccessResult("Urun eklendi");

        }

        public IResult Delete(Image image)
        {
            _imageRepository.Delete(image);
            return new SuccessResult("Urun silindi");
        }

        public IDataResult<Image> Get(Image image)
        {
            return new SuccessDataResult<Image>(_imageRepository.Get(i => i.Id == image.Id));
        }
        public IDataResult<List<Image>> GetAll()
        {
                return new SuccessDataResult<List<Image>>(_imageRepository.GetAll());

         }

            public IResult Update(Image image)
        {
            _imageRepository.Update(image);
            return new SuccessResult("Urun guncellendi");
        }
    }
}
