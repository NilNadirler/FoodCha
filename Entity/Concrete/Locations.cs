using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity.Abstract;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Locations : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int ManagerId { get ; set; }
        public string PhoneNumber { get; set; }

    }
}
