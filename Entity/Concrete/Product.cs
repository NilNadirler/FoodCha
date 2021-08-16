using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public int UnitTypeId { get; set; }
        public float Money { get; set; }
    }
}
