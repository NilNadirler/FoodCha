using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class TransactionType
    {
        private TransactionType(string value)
        {
            this.Value = value;
        }
        public string Value {get; private set; }

        public static TransactionType Sell { get { return new TransactionType("Sell"); } }
        public static TransactionType Buy { get { return new TransactionType("Buy"); } }
        public static TransactionType Return { get { return new TransactionType("Return"); } }
    }
}
