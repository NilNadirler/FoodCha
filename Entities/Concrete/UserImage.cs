using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Entities.Concrete
{
    public class UserImage : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ImageId { get; set; }
    }
}
