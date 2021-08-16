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
    public class UserManager : IUserService
    {
        IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IResult Add(User user)
        {
            _userRepository.Add(user);
            return new SuccessResult("User is added.");
        }

        public IResult Delete(User user)
        {
            _userRepository.Delete(user);
            return new SuccessResult("User is deleted.");
        }

        public IDataResult<User> Get(User user)
        {
            return new SuccessDataResult<User>(_userRepository.Get(u=>u.Id==user.Id));
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userRepository.GetAll());
        }

        public IResult Update(User user)
        {
            _userRepository.Update(user);
            return new SuccessResult("User is updated.");
        }
    }
}
