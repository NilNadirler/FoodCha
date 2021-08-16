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
    public class SocialLinkManager : ISocialLinkService
    {
        ISocialLinkRepository _socialLinkRepository;

        public SocialLinkManager(ISocialLinkRepository socialLinkRepository)
        {
            _socialLinkRepository = socialLinkRepository;
        }

        public IResult Add(SocialLink socialLink)
        {
            _socialLinkRepository.Add(socialLink);
            return new SuccessResult("Urun Eklendi");
        }

        public IResult Delete(SocialLink socialLink)
        {
            _socialLinkRepository.Delete(socialLink);
            return new SuccessResult("Urun Silindi");
        }

        public IDataResult<SocialLink> Get(Employee socialLink)
        {
            return new SuccessDataResult<SocialLink>(_socialLinkRepository.Get(s => s.Id == socialLink.Id));
        }

        public IDataResult<List<SocialLink>> GetAll()
        {
            return new SuccessDataResult<List<SocialLink>>(_socialLinkRepository.GetAll());
        }

        public IResult Update(SocialLink socialLink)
        {
            _socialLinkRepository.Update(socialLink);
            return new SuccessResult("Urun Guncellendi");
        }
    }
}
