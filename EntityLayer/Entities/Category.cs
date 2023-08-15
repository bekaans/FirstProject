using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }

        public  ICollection<Product> Products { get; set; }

    }
}
