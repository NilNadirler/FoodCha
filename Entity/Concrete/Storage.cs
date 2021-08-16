﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class Storage : IEntity
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public int UnitNumber { get; set; }

    }
}