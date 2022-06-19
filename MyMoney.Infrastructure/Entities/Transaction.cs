using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney.Infrastructure.Entities
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }

        public Guid CategoryId { get; set; }

        public double Price { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public Guid CreatedBy { get; set; }
    }
}
