using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISocialLinkService
    {
        IDataResult<List<SocialLink>> GetAll();
        IDataResult<SocialLink> Get(Employee socialLink);
        IResult Add(SocialLink socialLink);
        IResult Update(SocialLink socialLink);
        IResult Delete(SocialLink socialLink);
    }
}
