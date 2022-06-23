using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney.Infrastructure.Entities
{
    public class Wallet
    {
        [Key]
        public Guid WalletId { get; set; }

        [StringLength(64)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public Guid GroupId { get; set; }
    }
}
