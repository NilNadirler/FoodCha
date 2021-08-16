using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Abstract;

namespace Test.Concrete
{
    public class IngCredit : ICredit
    {
        public int CheckBalance()
        {
            return 100;
        }

        public bool CheckDebit()
        {
            return true;
        }
    }
}
