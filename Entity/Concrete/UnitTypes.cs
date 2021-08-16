using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class UnitTypes : IEntity
    {
        public int Id{ get; set; }
        public string UnitName { get; set; }

    }
}
