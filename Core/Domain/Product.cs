using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Product : BaseEntity
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountRatio { get; set; }
        public virtual Color Color { get; set; }
        public virtual int ColorId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual int BrandId { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
