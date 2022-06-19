using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney.Infrastructure.Entities
{
    public class Group
    {
        public Guid GroupId { get; set; }

        [StringLength(64)]
        public string Name { get; set; }
    }
}
