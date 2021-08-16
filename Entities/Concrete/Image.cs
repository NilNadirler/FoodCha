using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Image: IEntity
    {
        public int Id { get; set; }
        public string CDN { get; set; }
    }
}
