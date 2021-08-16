
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Entities.Concrete
{
    public class SocialLink : IEntity
    {
        public int Id { get;  set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
