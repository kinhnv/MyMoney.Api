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
        [Key]
        public Guid CategoryId { get; set; }

        [StringLength(64)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
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
