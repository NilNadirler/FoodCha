using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Abstract;

namespace Test.Concrete
{
    class FinanceCredit : ICredit
    {
        public int CheckBalance()
        {
            return 0;
        }

        public bool CheckDebit()
        {
            return false;
        }
    }
}
