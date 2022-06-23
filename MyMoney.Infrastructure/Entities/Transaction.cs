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

        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public double Price { get; set; }

        [StringLength(1024)]
        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid CreatedAt { get; set; }
    }
}
