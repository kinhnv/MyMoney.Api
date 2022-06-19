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
        public Guid UserId { get; set; }

        [StringLength(64)]
        public string UserName { get; set; }

        [StringLength(128)]
        public string Password { get; set; }

        public Guid GroupId { get; set; }
    }
}
