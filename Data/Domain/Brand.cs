using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Domain
{
    public class Brand : BaseEntity
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
