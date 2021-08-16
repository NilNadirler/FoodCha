using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserImageService
    {
        IDataResult<List<UserImage>> GetAll();
        IDataResult<UserImage> Get(UserImage userImage);
        IResult Add(UserImage userImage);
        IResult Update(UserImage userImage);
        IResult Delete(UserImage userImage);
    }
}
