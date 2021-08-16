using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concrete
{
    public class Transaction : IEntity
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int StorageId { get; set; }
        public int UserId { get; set; }
        public TransactionType Type { get; set; }
        public double Price { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
