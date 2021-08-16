using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entity;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Location : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int ManagerId { get ; set; }
        public string PhoneNumber { get; set; }

    }
}
