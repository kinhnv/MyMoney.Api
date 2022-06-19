using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney.Infrastructure.Entities
{
    public enum CategoryType
    {
        Earning,
        Consume
    }

    public class Category
    {
        public Guid CategoryId { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        public int Type { get; set; }

        [NotMapped]
        public CategoryType TypeAsEnum
        {
            get
            {
                return (CategoryType)Type;
            }
            set
            {
                Type = (int)value;
            }
        }
    }
}
