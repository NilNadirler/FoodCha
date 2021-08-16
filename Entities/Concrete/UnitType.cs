using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Entities.Concrete
{
    public class UnitType : IEntity
    {
        public int Id{ get; set; }
        public string UnitName { get; set; }

    }
}
