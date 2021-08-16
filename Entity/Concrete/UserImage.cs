using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class UserImage : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ImageId { get; set; }
    }
}
