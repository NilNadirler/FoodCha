using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class SocialLinks : IEntity
    {
        public int Id { get;  set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
