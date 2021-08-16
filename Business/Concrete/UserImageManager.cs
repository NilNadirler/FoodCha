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
    public class UserImageManager : IUserImageService
        
    {
        IUserImageRepository _userImageRepository;

        public UserImageManager(IUserImageRepository userImageRepository)
        {
            _userImageRepository = userImageRepository;
        }

        public IResult Add(UserImage userImage)
        {
            _userImageRepository.Add(userImage);
            return new SuccessResult("urun eklendi");
        }

        public IResult Delete(UserImage userImage)
        {
            _userImageRepository.Delete(userImage);

            return new SuccessResult("urun silindi");
        }

        public IDataResult<UserImage> Get(UserImage userImage)
        {
            return new SuccessDataResult<UserImage>(_userImageRepository.Get(ui => ui.Id == userImage.Id));
        }

        public IDataResult<List<UserImage>> GetAll()
        {
            return new SuccessDataResult<List<UserImage>>(_userImageRepository.GetAll());
        }

        public IResult Update(UserImage userImage)
        {
            _userImageRepository.Update(userImage);
            return new SuccessResult("urun guncellendi");
        }
    }
}
