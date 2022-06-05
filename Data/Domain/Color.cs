using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Domain
{
    public class Color : BaseEntity
    {
        public Color()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
