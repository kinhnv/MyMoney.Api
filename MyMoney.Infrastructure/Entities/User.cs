using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney.Infrastructure.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [StringLength(64)]
        [Required]
        public string UserName { get; set; } = string.Empty;

        [StringLength(128)]
        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public Guid GroupId { get; set; }
    }
}
